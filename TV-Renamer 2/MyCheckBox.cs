using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TV_Renamer_2.Properties.Resources;

namespace TV_Renamer_2
{
   [DefaultEvent("CheckChanged")]
   public partial class MyCheckBox : UserControl
   {
      private int iconSize = 32;
      private bool @checked = false;
      [EditorBrowsable(EditorBrowsableState.Always)]
      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Bindable(true)]
      public new event EventHandler Click;
      [EditorBrowsable(EditorBrowsableState.Always)]
      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Bindable(true)]
      public event EventHandler CheckChanged;
      [EditorBrowsable(EditorBrowsableState.Always)]
      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Bindable(true)]
      public override string Text { get => L_Label.Text; set => L_Label.Text = value; }
      [Category("Design")]
      public int IconSize { get => iconSize; set { iconSize = Math.Max(0, value); MyCheckBox_Resize(this, null); } }

      [Category("Data")]
      public bool Checked
      {
         get => @checked;
         set
         {
            @checked = value;
            CheckChanged?.Invoke(this, new EventArgs());
            PB_Icon_EnabledChanged(null, null);
         }
      }

      public MyCheckBox() => InitializeComponent();

      public void SetTooltip(ToolTip T, string Text)
      {
         T.SetToolTip(this, Text);
         T.SetToolTip(L_Label, Text);
         T.SetToolTip(PB_Icon, Text);
      }

      public void ForceResize() => MyCheckBox_Resize(null, null);

      private void MyCheckBox_Resize(object sender, EventArgs e)
      {
         PB_Icon.Height = PB_Icon.Width = Math.Min(iconSize, Height - 6);
         L_Label.Location = new Point(Math.Max((Width - L_Label.Width) / 2, (Width / 15 * 2) + PB_Icon.Width), (Height - L_Label.Height) / 2);
         PB_Icon.Location = new Point((Width - PB_Icon.Width) / 8, (Height - PB_Icon.Height) / 2);
      }

      private void OnClick(object sender, EventArgs e)
      { if (sender != null) { if (Enabled) Checked = !Checked; Click?.Invoke(null, e); } }

      private void MyButton_FontChanged(object sender, EventArgs e)
      { L_Label.Font = Font; MyCheckBox_Resize(this, e); }

      private void MyCheckBox_ForeColorChanged(object sender, EventArgs e)
         => L_Label.ForeColor = ForeColor;

      public override void Refresh()
      {
         PB_Icon_EnabledChanged(null, null);
      }

      private void PB_Icon_EnabledChanged(object sender, EventArgs e)
      {
         if (MainForm.Data.Design == FormDesign.Dark)
         {
            if (Enabled)
               PB_Icon.Image = @checked ? Check_Checked : Check_Unchecked;
            else
               PB_Icon.Image = @checked ? Check_Checked_Disabled : Check_Unchecked_Disabled;
         }
         else
         {
            if (Enabled)
               PB_Icon.Image = @checked ? Check_Checked_B : Check_Unchecked_B;
            else
               PB_Icon.Image = @checked ? Check_Checked_Disabled : Check_Unchecked_Disabled;
         }
      }
   }
}
