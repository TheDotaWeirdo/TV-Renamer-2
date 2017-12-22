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
   public partial class SeasonControl : UserControl
   {
      public Season Season { get; private set; }
      public List<EpisodeControl> EpControlList = new List<EpisodeControl>();

      private Image StopIcon => Design == FormDesign.Dark ? Icon_Stop : Icon_Stop_B;
      private Image EditIcon => Design == FormDesign.Dark ? Icon_Edit : Icon_Edit_B;
      private Image TVIcon   => Design == FormDesign.Dark ? Icon_TV : Icon_TV_B;
      private Image MainIcon => Design == FormDesign.Dark ? Icon_Season : Icon_Season_B;

      public override void Refresh()
      {
         BackColor = Design.BackColor;
         ForeColor = Design.TitleForeColor;
         panel1.BackColor = Design.DarkColor;
         PB_Del.Image = StopIcon;
         PB_Edit.Image = EditIcon;
         PB_Icon.Image = MainIcon;
         PB_Eps.Image = TVIcon;
      }

      public SeasonControl(Season season)
      {
         InitializeComponent();
         Season = season;
         Season.Control = this;
         foreach (var Ep in Season.Episodes.OrderByDescending(x => x.EpisodeNumber)) 
         {
            Ep.Control = new EpisodeControl(Ep) { Dock = DockStyle.Top };
            P_Episodes.Controls.Add(Ep.Control);
            EpControlList.Add(Ep.Control);
            Ep.Control.Show();
         }
         RefreshName();
      }

      public void RefreshName() => L_SeasonName.Text = Season.ToString();

      private void PB_Del_MouseEnter(object sender, EventArgs e)
         => PB_Del.Image = Icon_Stop_A;
      private void PB_Del_MouseLeave(object sender, EventArgs e)
         => PB_Del.Image = StopIcon;

      private void PB_Edit_MouseEnter(object sender, EventArgs e)
         => PB_Edit.Image = Icon_Edit_A;
      private void PB_Edit_MouseLeave(object sender, EventArgs e)
         => PB_Edit.Image = EditIcon;

      private void PB_Eps_MouseEnter(object sender, EventArgs e)
         => PB_Eps.Image = Icon_TV_A;
      private void PB_Eps_MouseLeave(object sender, EventArgs e)
         => PB_Eps.Image = TVIcon;

      private void PB_Icon_Click(object sender, EventArgs e)
      {
         if (Height > 61)
         {
            Height = 60;
            PB_Icon.Image = MainIcon;
            ActiveSeasonControl = null;
         }
         else
         {
            if (ActiveSeasonControl != null)
               ActiveSeasonControl.PB_Icon_Click(this, e);
            ActiveSeasonControl = this;
            Height = 60 + EpControlList.Sum(x => x.Height);
            PB_Icon.Image = Icon_Season_A;
         }
      }

      private void PB_Edit_Click(object sender, EventArgs e)
      {
         Season.SeasonName = DialogPrompt.Show("Enter the name of " + Season.ToString(), "Edit Season Name", Season.SeasonName);
         RefreshName();
      }

      private void PB_Del_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == MessageBox.Show("Are you sure you want to dismiss this Season and all its Episodes and Subtitles?", "Delete Season?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
         {
            Seasons.Remove(Season);
            Dispose();
         }
      }
   }
}
