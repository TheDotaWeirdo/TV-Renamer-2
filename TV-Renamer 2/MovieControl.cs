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
   public partial class MovieControl : UserControl
   {
      public Movie Movie;
      public List<SubtitleControl> SubControlList = new List<SubtitleControl>();

      private Image StopIcon => Design == FormDesign.Dark ? Icon_Stop : Icon_Stop_B;
      private Image EditIcon => Design == FormDesign.Dark ? Icon_Edit : Icon_Edit_B;
      private Image SubIcon => Design == FormDesign.Dark ? Icon_Sub : Icon_Sub_B;
      private Image MainIcon => Design == FormDesign.Dark ? Icon_Movie : Icon_Movie_B;

      public MovieControl(Movie movie)
      {
         InitializeComponent();
         Movie = movie;
         Movie.Control = this;
         AddSubs();
         RefreshName();
      }

      public override void Refresh()
      {
         BackColor = Design.BackColor;
         ForeColor = Design.TitleForeColor;
         panel1.BackColor = Design.DarkColor;
         PB_Del.Image = StopIcon;
         PB_Edit.Image = EditIcon;
         PB_Icon.Image = MainIcon;
         if (Movie.Subs.Count > 0)
            PB_Subs.Image = SubIcon;
      }

      public void AddSubs()
      {
         foreach (var item in SubControlList)
            item.Dispose();

         foreach (var Sub in Movie.Subs)
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

      public void RefreshName() => L_MovieName.Text = Movie.ToString();

      private void PB_Del_MouseEnter(object sender, EventArgs e)
         => PB_Del.Image = Icon_Stop_A;
      private void PB_Del_MouseLeave(object sender, EventArgs e)
         => PB_Del.Image = StopIcon;

      private void PB_Edit_MouseEnter(object sender, EventArgs e)
         => PB_Edit.Image = Icon_Edit_A;
      private void PB_Edit_MouseLeave(object sender, EventArgs e)
         => PB_Edit.Image = EditIcon;

      private void PB_Subs_MouseEnter(object sender, EventArgs e)
         => PB_Subs.Image = Movie.Subs.Count == 0 ? Icon_Sub_D : Icon_Sub_A;
      private void PB_Subs_MouseLeave(object sender, EventArgs e)
         => PB_Subs.Image = Movie.Subs.Count == 0 ? Icon_Sub_D : SubIcon;

      private void PB_Icon_Click(object sender, EventArgs e)
      {
         if (SubControlList.Count == 0) return;
         if (Height > 61)
         {
            Height = 60;
            PB_Icon.Image = MainIcon;
            ActiveMovieControl = null;
         }
         else
         {
            if (ActiveMovieControl != null)
               ActiveMovieControl.PB_Icon_Click(this, e);
            ActiveMovieControl = this;
            Height = 60 + SubControlList.Sum(x => x.Height);
            PB_Icon.Image = Icon_Movie_A;
         }
      }

      private void PB_Edit_Click(object sender, EventArgs e)
      {
         var KVP = DialogPrompt.Show("Enter the name of " + Movie.ToString(), "Edit Movie Name/Year", new KeyValuePair<String, int>(Movie.Name, Movie.Year));
         Movie.Name = KVP.Key;
         Movie.Year = KVP.Value;
         RefreshName();
         foreach (var Sub in SubControlList)
            Sub.RefreshName();
      }

      private void PB_Del_Click(object sender, EventArgs e)
      {
         if (DialogResult.OK == MessageBox.Show("Are you sure you want to dismiss this Movie and its Subtitles?", "Delete Movie?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
         {
            Movies.Remove(Movie);
            Dispose();
         }
      }
   }
}
