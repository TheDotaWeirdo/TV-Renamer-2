using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Renamer_2
{
   [DefaultEvent("CheckChanged")]
   public partial class MyRadioButton : UserControl
   {
      public event EventHandler CheckChanged;
      public List<MyRadioButton> RadioButtonGroups = new List<MyRadioButton>();
      private int iconSize = 32;
      private int iconXmultiplier = 8;
      private bool _checked = false;
      private int _ID = 0;

      [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Bindable(true)]
      public override string Text { get => CB_Label.Text; set => CB_Label.Text = value; }

      [Category("Design")]
      public int IconSize { get => iconSize; set { iconSize = Math.Max(0, value); MyRadioButton_Resize(this, null); } }

      [Category("Data")]
      public bool Checked
      {
         get => _checked;
         set
         {
            if (value)
               foreach (var item in RadioButtonGroups)
                  item.Checked = false;

            _checked = value;
            if (MainForm.Data.Design == FormDesign.Dark)
               Box.Image = (value) ? Properties.Resources.Radio_Checked : Properties.Resources.Radio_Unhecked;
            else
               Box.Image = (value) ? Properties.Resources.Radio_Checked_B : Properties.Resources.Radio_Unhecked_B;

            CheckChanged?.Invoke(this, new EventArgs());
         }
      }

      [Category("Data")]
      public int ID { get => _ID; set => _ID = value; }
      [Category("Design")]
      public int IconXmultiplier { get => iconXmultiplier; set { iconXmultiplier = value; MyRadioButton_Resize(this, null); } }

      public MyRadioButton() => InitializeComponent();

      private void MyCheckBox_Load(object sender, EventArgs e) { }

      public void SetTooltip(ToolTip T, string Text)
      {
         T.SetToolTip(this, Text);
         T.SetToolTip(CB_Label, Text);
         T.SetToolTip(Box, Text);
      }

      private void Box_Click(object sender, EventArgs e) => Checked = !Checked;

      private void MyCheckBox_FontChanged(object sender, EventArgs e)
      {
         CB_Label.Font = Font;
         MyRadioButton_Resize(this, e);
      }

      public override void Refresh()
      {
         if (MainForm.Data.Design == FormDesign.Dark)
            Box.Image = (Checked) ? Properties.Resources.Radio_Checked : Properties.Resources.Radio_Unhecked;
         else
            Box.Image = (Checked) ? Properties.Resources.Radio_Checked_B : Properties.Resources.Radio_Unhecked_B;
      }

      public void ForceResize() => MyRadioButton_Resize(null, null);

      private void MyRadioButton_Resize(object sender, EventArgs e)
      {
         Box.Height = Box.Width = Math.Min(iconSize, Height - 6);
         CB_Label.Location = new Point(Math.Max((Width - CB_Label.Width) / 2, (Width / 15 * 2) + Box.Width), (Height - CB_Label.Height) / 2);
         Box.Location = new Point(Math.Max(0, Math.Min(CB_Label.Location.X - Box.Width - 6, (Width - Box.Width) / IconXmultiplier)), (Height - Box.Height) / 2);
      }
   }
}
