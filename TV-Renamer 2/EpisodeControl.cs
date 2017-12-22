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
   public partial class EpisodeControl : UserControl
   {
      public Episode Episode { get; private set; }
      public List<SubtitleControl> SubControlList = new List<SubtitleControl>();

      private Image StopIcon => Design == FormDesign.Dark ? Icon_Stop : Icon_Stop_B;
      private Image EditIcon => Design == FormDesign.Dark ? Icon_Edit : Icon_Edit_B;
      private Image SubIcon => Design == FormDesign.Dark ? Icon_Sub : Icon_Sub_B;
      private Image MainIcon => Design == FormDesign.Dark ? Icon_TV : Icon_TV_B;

      public EpisodeControl(Episode episode)
      {
         InitializeComponent();
         Episode = episode;
         AddSubs();
         RefreshName();
      }

      public override void Refresh()
      {
         BackColor = Design.BackColor;
         ForeColor = Design.TitleForeColor;
         PB_Del.Image = StopIcon;
         PB_Edit.Image = EditIcon;
         PB_Icon.Image = MainIcon;
         if (Episode.Subs.Count > 0)
            PB_Subs.Image = SubIcon;
      }

      public void AddSubs()
      {
         foreach (var item in SubControlList)
            item.Dispose();

         foreach (var Sub in Episode.Subs)
         {
            Sub.Control = new SubtitleControl(Sub) { Dock = DockStyle.Top };
            P_Subs.Controls.Add(Sub.Control);
            SubControlList.Add(Sub.Control);
            Sub.Control.Show();
            PB_Subs.Image = SubIcon;
         }
      }

      public void ClearSubs()
      {
         foreach (var item in SubControlList)
            item.Dispose();
         SubControlList.Clear();
      }

      public void RefreshName() => L_EpName.Text = Episode.ToString();

      private void PB_Del_MouseEnter(object sender, EventArgs e)
         => PB_Del.Image = Icon_Stop_A;
      private void PB_Del_MouseLeave(object sender, EventArgs e)
         => PB_Del.Image = StopIcon;

      private void PB_Edit_MouseEnter(object sender, EventArgs e)
         => PB_Edit.Image = Icon_Edit_A;
      private void PB_Edit_MouseLeave(object sender, EventArgs e)
         => PB_Edit.Image = EditIcon;

      private void PB_Subs_MouseEnter(object sender, EventArgs e)
         => PB_Subs.Image = Episode.Subs.Count == 0 ? Icon_Sub_D : Icon_Sub_A;
      private void PB_Subs_MouseLeave(object sender, EventArgs e)
         => PB_Subs.Image = Episode.Subs.Count == 0 ? Icon_Sub_D : SubIcon;

      private void PB_Icon_Click(object sender, EventArgs e)
      {
         if (SubControlList.Count == 0) return;

         if (Height > 51)
         {
            Height = 50;
            Episode.Season.Control.Height -= SubControlList.Sum(x => x.Height);
            PB_Icon.Image = MainIcon;
            ActiveEpisodeControl = null;
         }
         else
         {
            if (ActiveEpisodeControl != null)
               ActiveEpisodeControl.PB_Icon_Click(this, e);
            ActiveEpisodeControl = this;
            Height = 50 + SubControlList.Sum(x => x.Height);
            Episode.Season.Control.Height += SubControlList.Sum(x => x.Height);
            PB_Icon.Image = Icon_TV_A;
         }
      }

      private void PB_Edit_Click(object sender, EventArgs e)
      {
         Episode.EpisodeName = DialogPrompt.Show("Enter the name of " + new Episode(Episode.SeasonNumber, Episode.EpisodeNumber, "").ToString(), "Edit Episode Name", Episode.EpisodeName);
         RefreshName();
         foreach (var Sub in SubControlList)
            Sub.RefreshName();
      }

      private void PB_Del_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == MessageBox.Show("Are you sure you want to dismiss this Episode and its Subtitles?", "Delete Episode?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
         {
            Episode.Season.Control.Height -= Height;
            Episode.Season.Control.EpControlList.Remove(this);
            if(Episode.Season.Control.EpControlList.Count == 0)
            {
               Episode.Season.Control.Dispose();
               Seasons.Remove(Episode.Season);
            }
            else
            {
               Episode.Season.Episodes.Remove(Episode);
               Dispose();
            }
         }
      }
   }
}
