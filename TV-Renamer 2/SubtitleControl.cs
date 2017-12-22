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

namespace TV_Renamer_2
{
   public partial class SubtitleControl : UserControl
   {
      public Subtitle Subtitle { get; private set; }

      private Image StopIcon => Design == FormDesign.Dark ? Icon_Stop : Icon_Stop_B;
      private Image EditIcon => Design == FormDesign.Dark ? Icon_Edit : Icon_Edit_B;
      private Image MainIcon => Design == FormDesign.Dark ? Icon_Sub  : Icon_Sub_B;

      public SubtitleControl(Subtitle subtitle)
      {
         InitializeComponent();
         Subtitle = subtitle;
         RefreshName();
         if (MovieMode)
         { P_MarginLeft.Width = 50; L_SubName.Location = new Point(100, 0); }
      }

      public override void Refresh()
      {
         BackColor = Design.BackColor;
         ForeColor = Design.TitleForeColor;
         PB_Del.Image = StopIcon;
         PB_Edit.Image = EditIcon;
         PB_Icon.Image = MainIcon;
      }

      public void RefreshName() => L_SubName.Text = Subtitle.ToString();

      private void PB_Del_MouseEnter(object sender, EventArgs e)
         => PB_Del.Image = Icon_Stop_A;
      private void PB_Del_MouseLeave(object sender, EventArgs e)
         => PB_Del.Image = StopIcon;

      private void PB_Edit_MouseEnter(object sender, EventArgs e)
         => PB_Edit.Image = Icon_Edit_A;
      private void PB_Edit_MouseLeave(object sender, EventArgs e)
         => PB_Edit.Image = EditIcon;

      private void PB_Del_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == MessageBox.Show("Are you sure you want to dismiss this Subtitle?", "Delete Subtitle?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
         {
            if (MovieMode)
            {
               Subtitle.Movie.Control.SubControlList.Remove(this);
               Subtitle.Movie.Control.Height -= Height;
               Subtitle.Movie.Subs.Remove(Subtitle);
               if (Subtitle.Movie.Subs.Count == 0)
                  Subtitle.Movie.Control.PB_Subs.Image = Icon_Sub_D;
            }
            else
            {
               Subtitle.Episode.Control.SubControlList.Remove(this);
               Subtitle.Episode.Control.Height -= Height;
               Subtitle.Episode.Subs.Remove(Subtitle);
               if (Subtitle.Episode.Subs.Count == 0)
                  Subtitle.Episode.Control.PB_Subs.Image = Icon_Sub_D;
            }
            Dispose();
         }
      }

      private void PB_Edit_Click(object sender, EventArgs e)
      {
         Subtitle.Name = DialogPrompt.Show("Enter the name of " + Subtitle.ToString(), "Edit Episode Name", Subtitle.Name);
         RefreshName();
      }
   }
}
