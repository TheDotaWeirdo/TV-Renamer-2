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
using static TV_Renamer_2.MainForm.Data;
using System.Windows.Input;

namespace TV_Renamer_2
{
   [DefaultEvent("Click")]
   public partial class MyButton : UserControl
   {
      [EditorBrowsable(EditorBrowsableState.Always)]
      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Bindable(true)]
      public new event EventHandler Click;
      [EditorBrowsable(EditorBrowsableState.Always)]
      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      [Bindable(true)]
      public override string Text { get => L_Label.Text; set => L_Label.Text = value; }

      private Image _activeimage;
      private Image _normalimage;
      [Category("Design")]
      public Image Image { get => _normalimage; set => PB_Icon.Image = _normalimage = value; }
      [Category("Design")]
      public Image ActiveImage { get => _activeimage; set => _activeimage = value; }
      [Category("Design")]
      public PictureBoxSizeMode SizeMode { get => PB_Icon.SizeMode; set => PB_Icon.SizeMode = value; }

      public Image Normal => Design == FormDesign.Dark ? Button_Normal : Button_Normal_B;
      public Image Hover => Design == FormDesign.Dark ? Button_Hover : Button_Hover_B;
      public Image Pressed => Design == FormDesign.Dark ? Button_Press : Button_Press_B;

      public Color Color_Normal  => Design == FormDesign.Dark ? Color.FromArgb(250, 250, 250)   : Color.FromArgb(242, 244, 247);
      public Color Color_Hover   => Design == FormDesign.Dark ? Color.FromArgb(234, 238, 246)   : Color.FromArgb(242, 244, 247);
      public Color Color_Pressed => Design == FormDesign.Dark ? Color.FromArgb(243, 247, 255)   : Color.FromArgb(242, 244, 247);

      public MyButton() => InitializeComponent();

      public void ForceResize() => MyButton_Resize(null, null);

      private void MyButton_Resize(object sender, EventArgs e)
      {
         PB_Icon.Height = PB_Icon.Width = Math.Min(32, Height - 12);
         PB_Icon.Location = new Point(Width / 15, (Height - PB_Icon.Height) / 2);
         L_Label.Location = new Point(Math.Max((Width - L_Label.Width) / 2, (Width / 15 * 2) + PB_Icon.Width), (Height - L_Label.Height) / 2);
      }

      public void SetTooltip(ToolTip T, string Text)
      {
         T.SetToolTip(this, Text);
         T.SetToolTip(L_Label, Text);
         T.SetToolTip(PB_Icon, Text);
         T.SetToolTip(PB_Back, Text);
      }

      private void OnClick(object sender, EventArgs e)
         => Click?.Invoke(this, e);

      private void MyButton_FontChanged(object sender, EventArgs e)
      {
         L_Label.Font = Font;
         MyButton_Resize(this, e);
      }

      public override void Refresh()
      {
         PB_Back.Image = Normal;
         if (_normalimage != null)
            PB_Icon.Image = _normalimage;
         L_Label.ForeColor = Design == FormDesign.Dark ? Design.BackColor : Design.ForeColor;
         L_Label.BackColor = PB_Icon.BackColor = Color_Normal;
      }

      private void On_MouseEnter(object sender, EventArgs e)
      {
         PB_Back.Image = Hover;
         if (_normalimage != null)
            PB_Icon.Image = _normalimage;
         L_Label.ForeColor = Design == FormDesign.Dark ? Design.BackColor : Design.ForeColor;
         L_Label.BackColor = PB_Icon.BackColor = Color_Hover;
      }

      private void On_MouseLeave(object sender, EventArgs e)
      {
         PB_Back.Image = Normal;
         if (_normalimage != null)
            PB_Icon.Image = _normalimage;
         L_Label.ForeColor = Design == FormDesign.Dark ? Design.BackColor : Design.ForeColor;
         L_Label.BackColor = PB_Icon.BackColor = Color_Normal;
      }

      private void On_MouseDown(object sender, MouseEventArgs e)
      {
         PB_Back.Image = Pressed;
         if (_activeimage != null)
            PB_Icon.Image = _activeimage;
         L_Label.ForeColor = Color.FromArgb(82, 148, 226);
         L_Label.BackColor = PB_Icon.BackColor = Color_Pressed;
      }

      private void On_MouseUp(object sender, MouseEventArgs e)
      {
         PB_Back.Image = Hover;
         if (_normalimage != null)
            PB_Icon.Image = _normalimage;
         L_Label.ForeColor = Design == FormDesign.Dark ? Design.BackColor : Design.ForeColor;
         L_Label.BackColor = PB_Icon.BackColor = Color_Hover;
      }

      private void MyButton_Load(object sender, EventArgs e)
      {
         var T = new System.Timers.Timer(100);
         T.Start();
         T.Elapsed += (s, t) => { try { Invoke(new Action(() => { if (MouseButtons == MouseButtons.None && !ClientRectangle.Contains(PointToClient(MousePosition))) Refresh(); })); } catch (Exception) { } };
         MyButton_Resize(this, e);
      }
   }
}
