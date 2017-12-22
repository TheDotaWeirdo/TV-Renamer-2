using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TV_Renamer_2.MainForm.Data;
using System.IO;
using System.Threading;

namespace TV_Renamer_2
{
   public partial class RenameSubForm : UserControl
   {
      private string ErrorList = "";
      private int DoneCount => SeasonsDone + MoviesDone + EpisodesDone + SubsDone;
      private int SeasonsDone = 0;
      private int MoviesDone = 0;
      private int EpisodesDone = 0;
      private int SubsDone = 0;
      private int TotalCount => Seasons.Count + Movies.Count + EpisodeCount + SubsCount;
      private int EpisodeCount = 0;
      private int SubsCount = 0;
      private System.Timers.Timer LoadingTimer;

      public RenameSubForm() => InitializeComponent();

      public void RenameSubForm_Resize(object sender, EventArgs e)
      {
         P_CurrentWork.Height = (int)(Height / 7.25);
         progressBar.Font = new Font("Century Gothic", (float)(27.75).Scale(Math.Min(P_Main.Width, P_Main.Height) - 432, 27.75, 36, 0.014), FontStyle.Bold);
         progressBar.Size = new Size(250 + (Math.Min(P_Main.Width, P_Main.Height) - 432) * 25 / 100, 250 + (Math.Min(P_Main.Width, P_Main.Height) - 432) * 25 / 100);
         progressBar.OuterMargin = progressBar.Width / -10;
         progressBar.OuterWidth = progressBar.Width / 10;
         progressBar.ProgressWidth = progressBar.Width / 10 + 3;
         P_InfoTextContainer.Size = new Size(75 + P_Main.Width * 40 / 100, 100 + P_Main.Height * 40 / 100);
         P_InfoText.Size = new Size(P_InfoTextContainer.Width - 30, P_InfoTextContainer.Height - 30);
         P_InfoLeft.Size = new Size(P_InfoText.Width / 2, P_InfoText.Height);
         var h = P_InfoText.Height / (P_InfoLeft.Controls.Count - (MovieMode ? 2 : 1) - (O_IncludeSubs ? 0 : 1));
         foreach (var item in P_InfoLeft.Controls)
            if (item is Label)
               (item as Label).Height = h;
         foreach (var item in P_InfoRight.Controls)
            if (item is Label)
               (item as Label).Height = h;
         P_InfoTextContainer.Center(P_Main, .1);
         P_InfoText.Center(P_InfoTextContainer, 1);
         progressBar.Location = new Point((P_Main.Width - P_InfoTextContainer.Width - P_InfoTextContainer.Location.X - progressBar.Width) / 2 + P_InfoTextContainer.Width + P_InfoTextContainer.Location.X, (P_Main.Height - progressBar.Height) / 2);
         B_Done.Center(P_CurrentWork, .5, .9);
      }

      public void Prepare()
      {
         CurrentFormState = FormState.Working;
         ErrorList = "";
         L_CurrentWork.Text = "Preparing..";
         L_Mode.Text = MovieMode ? "Movies" : "TV Series";
         L_Reorder.Text = O_ReOrderFolders ? "Yes" : "No";
         L_CleanFolders.Text = O_CleanFolders ? "Yes" : "No";
         if (MovieMode)
         {
            EpisodeCount = 0;
            SubsCount = Movies.Sum(s => s.Subs.Count);
            L_Movies.Text = $"0 / {Movies.Count}";
            L_Subs.Text = $"0 / {SubsCount}";
            labelSeason.Visible = labelEpisode.Visible = L_Seasons.Visible = L_Episodes.Visible = !(labelMovie.Visible = L_Movies.Visible = true);
         }
         else
         {
            EpisodeCount = Seasons.Sum(s => s.Episodes.Count);
            SubsCount = Seasons.Sum(s => s.Episodes.Sum(e => e.Subs.Count));
            L_Seasons.Text = $"0 / {Seasons.Count}";
            L_Episodes.Text = $"0 / {EpisodeCount}";
            L_Subs.Text = $"0 / {SubsCount}";
            labelSeason.Visible = labelEpisode.Visible = L_Seasons.Visible = L_Episodes.Visible = !(labelMovie.Visible = L_Movies.Visible = false);
         }
         L_Subs.Visible = labelSubs.Visible = O_IncludeSubs;
         L_Errors.Text = "0";
         L_Errors.ForeColor = Color.FromArgb(82, 148, 226);
         progressBar.ProgressColor = Color.FromArgb(101, 223, 107);
         progressBar.Value = SeasonsDone = MoviesDone = EpisodesDone = SubsDone = 0;
         progressBar.Text = "0";
         progressBar.Maximum = Seasons.Count + Movies.Count + EpisodeCount + SubsCount;
         progressBar.StartAngle = 270;
         LoadingTimer = new System.Timers.Timer(16);
         LoadingTimer.Elapsed += LoadingTimer_Elapsed;
         RenameSubForm_Resize(this, null);
      }

      private void LoadingTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
         => Invoke(new Action(() => progressBar.StartAngle += 2));

      public void Start()
      {
         LoadingTimer.Start();
         new Action(() =>
         {
            CurrentFormState = FormState.Running;
            if (MovieMode)
            {
               foreach (var Movie in Movies.OrderBy(x => x.Name))
               {
                  try
                  {
                     foreach (var Sub in Movie.Subs)
                     {
                        try
                        {
                           if (!File.Exists(Sub.Destination))
                              File.Move(Sub.FilePath, Sub.Destination);
                           SubsDone++;
                           UpdateNumbers(Sub.ToString());
                           Thread.Sleep(100);
                        }
                        catch (Exception ex)
                        { IncreaseError(ex); }
                     }
                     if (!File.Exists(Movie.Destination))
                        File.Move(Movie.FilePath, Movie.Destination);
                     MoviesDone++;
                     UpdateNumbers(Movie.ToString());
                     Thread.Sleep(100);
                  }
                  catch (Exception ex)
                  { IncreaseError(ex); }
               }
            }
            else
            {
               foreach (var Season in Seasons.OrderBy(x => x.SeasonNumber))
               {
                  foreach (var Episode in Season.Episodes.OrderBy(x => x.EpisodeNumber)) 
                  {
                     try
                     {
                        foreach (var Sub in Episode.Subs)
                        {
                           try
                           {
                              if(!File.Exists(Sub.Destination))
                                 File.Move(Sub.FilePath, Sub.Destination);
                              SubsDone++;
                              UpdateNumbers(Sub.ToString());
                              Thread.Sleep(100);
                           }
                           catch (Exception ex)
                           { IncreaseError(ex); }
                        }
                        if (!File.Exists(Episode.Destination))
                           File.Move(Episode.FilePath, Episode.Destination);
                        EpisodesDone++;
                        UpdateNumbers(Episode.ToString());
                        Thread.Sleep(100);
                     }
                     catch (Exception ex)
                     { IncreaseError(ex); }
                  }
                  SeasonsDone++;
                  UpdateNumbers(Season.ToString());
               }
            }
            Invoke(new Action(() => { L_CurrentWork.Text = "Cleaning Up..."; }));

            if (O_CleanFolders)
            {

               try
               {
                  foreach (var item in JunkFiles)
                  {
                     try
                     {
                        var file = new FileInfo(item);
                        file.Attributes = file.Attributes & ~FileAttributes.ReadOnly;
                        file.Delete();
                     }
                     catch (Exception ex) { IncreaseError(ex); }
                  }
                     

                  foreach (var item in Directory.GetDirectories(FolderPath, "*", SearchOption.AllDirectories))
                  {
                     if (DirectoryIsEmpty(item))
                     {
                        try
                        {
                           var dir = new DirectoryInfo(item);
                           dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                           foreach (var fil in Directory.GetFiles(item, "*", SearchOption.AllDirectories))
                           {
                              var file = new FileInfo(fil);
                              file.Attributes = file.Attributes & ~FileAttributes.ReadOnly;
                              file.Delete();
                           }
                           dir.Delete();
                        }
                        catch (Exception ex) { IncreaseError(ex); }
                     }
                  }
                  
                  if (!MovieMode && !Directory.Exists(Directory.GetParent(FolderPath).FullName + "\\" + SeriesName))
                     Directory.Move(FolderPath, Directory.GetParent(FolderPath).FullName + "\\" + SeriesName);
               }
               catch (Exception ex) { IncreaseError(ex); }
            }

            Invoke(new Action(() =>
            {
               CurrentFormState = FormState.Normal;
               B_Done.Show();
               L_CurrentWork.Text = "";
               if (L_Errors.Text != "0")
               {
                  progressBar.Value = progressBar.Maximum;
                  progressBar.Text = "100";
                  progressBar.ProgressColor = Color.FromArgb(242, 60, 53);
                  LoadingTimer.Dispose();
                  LoadingTimer = null;
               }
               if (ErrorList != "")
               {
#if DEBUG
                  File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Renamer Log.txt", ErrorList);
#else
                  if (MessageBox.Show("Errors Occured, would you like to save the Error Log?", "Save Error Log?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                     File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Renamer Log.txt", ErrorList);
#endif
               }
            }));
         }).RunInBackground(1250);
      }

      internal void ToggleDesignMode()
      {
         BackColor = Design.BackColor;
         panel1.BackColor = Design.DarkColor;
         if(Design == FormDesign.Dark)
         {
            progressBar.InnerColor = Color.FromArgb(209, 213, 224);
            progressBar.OuterColor = Color.FromArgb(143, 150, 169);
            P_InfoTextContainer.BackColor = Design.LightColor;
            ForeColor = Design.ForeColor;
         }
         else
         {
            progressBar.InnerColor = Design.TitleColor;
            progressBar.OuterColor = Color.FromArgb(209, 213, 224);
            P_InfoTextContainer.BackColor = Design.TitleColor;
            ForeColor = Color.FromArgb(70, 76, 93);
         }
      }

      private bool DirectoryIsEmpty(string item)
         => (!Directory.GetFiles(item, "*", SearchOption.AllDirectories).Any() || Directory.GetFiles(item, "*", SearchOption.AllDirectories).All(x => new FileInfo(x).Attributes.HasFlag(FileAttributes.Hidden)));

      private void UpdateNumbers(string current)
      {
         Invoke(new Action(() =>
         {
            L_CurrentWork.Text = current;
            L_Seasons.Text = SeasonsDone + " / " + Seasons.Count;
            L_Episodes.Text = EpisodesDone + " / " + EpisodeCount;
            L_Movies.Text = MoviesDone + " / " + Movies.Count;
            L_Subs.Text = SubsDone + " / " + SubsCount;
            progressBar.Value = Math.Min(TotalCount, DoneCount);
            progressBar.Text = (100 * progressBar.Value / progressBar.Maximum).ToString();
         }));
      }

      private void IncreaseError(Exception ex)
      {
         Invoke(new Action(() => 
         {
            L_Errors.Text = (L_Errors.Text.SmartParse() + 1).ToString();
            L_Errors.ForeColor = Color.FromArgb(242, 60, 53);
         }));
#if DEBUG
         ErrorList += ex.ToString() + "\n";
#endif
      }
      
      private void B_Done_Click(object sender, EventArgs e)
      {
         Form1.mainSubForm.RefreshFolder();
         Form1.mainSubForm.Show();
         Hide();
         B_Done.Hide();
         progressBar.Value = 0;
      }
   }
}
