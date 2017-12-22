using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static TV_Renamer_2.MainForm.Data;
using System.Text.RegularExpressions;

namespace TV_Renamer_2
{
   public partial class MainSubForm : UserControl
   {
      private string[] LastSpecificPathText = { "", "" };
      private bool DisableTextChange = false;

      public MainSubForm() => InitializeComponent();

      private void MainSubForm_Load(object sender, EventArgs e)
         => RadioButtonGroup = RB_Style1.RadioButtonGroups = RB_Style2.RadioButtonGroups = RB_Style3.RadioButtonGroups = RB_Style4.RadioButtonGroups =
            new List<MyRadioButton> { RB_CName, RB_Style1, RB_Style2, RB_Style3, RB_Style4 };

      public void MainSubForm_Resize(object sender, EventArgs e)
      {
         P_IconPath.Height = P_SpecificFolder.Height = P_SeasonsEpsSubs.Height = P_TotEps.Height = (int)(P_Main.Height / 8.5);
         P_Options.Height = P_NameStyle.Height = (int)(P_Main.Height / 4.25);
         P_RB_L.Width = P_NS.Width / 2;
         RB_Style1.Height = RB_Style3.Height = P_RB_L.Height / 2;
         CB_ShowSeason.Width = CB_IncSubs.Width = CB_CleanFolders.Width = CB_CustomName.Width = P_Options_Checkboxes.Width / 3;
         P_Top_Checkboxes.Height = P_Options_Checkboxes.Height / 2;
         TB_FolderPath.Width = TB_SeriesName.Width = P_TB_FolderPath.Width * 85 / 100;
         TB_FolderPath.Center(P_TB_FolderPath);
         TB_SeriesName.Center(P_TB_SeriesName);
         B_Browse.Center(P_B_Browse);
         if (O_IncludeSubs)
            P_TotEps.Center(P_SeasonsEpsSubs);
         B_Continue.Location = new Point((P_Buttons.Width - B_Continue.Width) * 7 / 10, (16 + P_Buttons.Height - B_Continue.Height) / 2);
         B_Rename.Location = new Point((P_Buttons.Width - B_Continue.Width) * 3 / 10, (16 + P_Buttons.Height - B_Continue.Height) / 2);
         PB_Refresh.Location = new Point((P_B_Browse.Location.X - PB_Refresh.Width - TB_FolderPath.Width - P_TB_FolderPath.Location.X - TB_FolderPath.Location.X) / 2 + P_TB_FolderPath.Location.X + TB_FolderPath.Width + TB_FolderPath.Location.X, (P_Refresh.Height - PB_Refresh.Height) / 2);

         //Custom Name
         RB_CName.Height = P_CustomName.Height / 2;
         TB_CN_1.Width = TB_CN_2.Width = TB_CN_3.Width = (int)(RB_CName.Width * .85 - L_CN_1.Width - L_CN_2.Width - L_CN_3.Width - L_CN_4.Width - 15) / 3;
         L_CN_1.Location = new Point((P_CustomName.Width - L_CN_1.Width - TB_CN_1.Width - L_CN_2.Width - TB_CN_2.Width - (MovieMode ? 0 : L_CN_3.Width + L_CN_4.Width + TB_CN_3.Width)) / 2, P_CustomName.Height * 2 / 10);
         TB_CN_1.Location = new Point(L_CN_1.Location.X + L_CN_1.Width, L_CN_1.Location.Y - 5);
         L_CN_2.Location = new Point(TB_CN_1.Location.X + TB_CN_1.Width + 5, L_CN_1.Location.Y);
         TB_CN_2.Location = new Point(L_CN_2.Location.X + L_CN_2.Width, L_CN_1.Location.Y - 5);
         L_CN_3.Location = new Point(TB_CN_2.Location.X + TB_CN_2.Width + 5, L_CN_1.Location.Y);
         TB_CN_3.Location = new Point(L_CN_3.Location.X + L_CN_3.Width, L_CN_1.Location.Y - 5);
         L_CN_4.Location = new Point(TB_CN_3.Location.X + TB_CN_3.Width + 5, L_CN_1.Location.Y);
      }

      private string[] FormatBlackList(string[] array)
      {
         for (int i = 0; i < array.Length; i++)
         {
            if (char.IsLetterOrDigit(array[i][0]))
               array[i] = "(\\b|$)" + array[i];
            if (char.IsLetterOrDigit(array[i].Last()))
               array[i] = array[i] + "(\\b|^)";
         }
         return array;
      }

      public void ClearFiles()
      {
         foreach (var Season in Seasons)
         {
            foreach (var Episode in Season.Episodes)
            {
               foreach (var Sub in Episode.Subs)
                  Sub.Control.Dispose();
               Episode.Control.Dispose();
            }
            Season.Control.Dispose();
         }

         foreach (var Movie in Movies)
         {
            foreach (var Sub in Movie.Subs)
               Sub.Control.Dispose();
            Movie.Control.Dispose();
         }

         Seasons.Clear();
         Movies.Clear();
         JunkFiles.Clear();
      }

      public void RefreshFolder()
      {
         if (TB_FolderPath.Text == "") return;

         Cursor.Current = Cursors.WaitCursor;

         ClearFiles();
         
         try
         {
            BlackList = NameExtractor.PreBlackList;
            if (File.Exists("RenamerBlackList.txt"))
            {
               var pb = new List<string>();
               foreach (var item in File.ReadAllLines("RenamerBlackList.txt"))
               {
                  if (!BlackList.Contains(item))
                     pb.Add(Regex.Escape(item));
               }
               BlackList = FormatBlackList(BlackList.Union(pb).ToArray());
            }
            else
            {
               File.WriteAllText("RenamerBlackList.txt", "");
            }
         }
         catch (Exception) { BlackList = FormatBlackList(NameExtractor.PreBlackList); }

         try
         {
            var Files = new List<string>();
            var VideoFiles = new List<string>();

            foreach (var item in Directory.EnumerateFiles(TB_FolderPath.Text, "*.*", SearchOption.AllDirectories))
            {
               if (IsVideoFile(item) && (MovieMode || Episode.PathIsValid(item)))
               {
                  VideoFiles.Add(item);
                  if (VideoFiles.Count > 650)
                     throw new StackOverflowException("File Count exceeded Limit");
               }
               else
                  Files.Add(item);
            }

            if (MovieMode) // Movie Mode
            {
               foreach (var Video in VideoFiles)
                  Movies.Add(new Movie(Video));

               L_SeasonCount.Text = Movies.Count.ToString();

               foreach (var Movie in Movies.OrderByDescending(x => x.Name))
               {
                  Movie.Control = new MovieControl(Movie) { Dock = DockStyle.Top };
                  Form1.reviewSubForm.P_Main.Controls.Add(Movie.Control);
                  Movie.Control.Show();
               }
            }
            else // Series Mode
            {
               var Episodes = new List<Episode>();
               foreach (var item in VideoFiles)
                  Episodes.Add(new Episode(item));
               foreach (var SNumber in Season.GetSeasons(Episodes))
                  Seasons.Add(new Season(SNumber, Episodes.Where(x => x.SeasonNumber == SNumber).ToList()));

               L_SeasonCount.Text = Seasons.Count.ToString();
               L_EpCount.Text = Episodes.Count.ToString();

               foreach (var Season in Seasons.OrderByDescending(x => x.SeasonNumber))
               {
                  Season.Control = new SeasonControl(Season) { Dock = DockStyle.Top };
                  Form1.reviewSubForm.P_Main.Controls.Add(Season.Control);
                  Season.Control.Show();
               }
            }

            if (O_IncludeSubs)
               AddSubtitles();

            JunkFiles = Files.Where(f => Movies.All(m => m.FilePath != f && m.Subs.All(s => s.FilePath != f))
               && Seasons.All(S => S.Episodes.All(e => e.FilePath != f && e.Subs.All(sub => sub.FilePath != f)))
               && !(new FileInfo(f).Attributes.HasFlag(FileAttributes.Hidden))).ToList();

            if (!O_IncludeSubs)
               JunkFiles.RemoveAll(x => x.EndsWith(".srt"));

            L_SeasonCount.ForeColor = L_EpCount.ForeColor = L_SubCount.ForeColor = FormState.N_Focused.Color;
            CurrentFormState = GetFormState();
         }
         catch (Exception ex)
         {
            ClearFiles();
            Form1.ShowError(ex.Message);
            L_SeasonCount.Text = L_EpCount.Text = L_SubCount.Text = "0";
            L_SeasonCount.ForeColor = L_EpCount.ForeColor = L_SubCount.ForeColor = Color.FromArgb(242, 60, 53);
            Clipboard.SetText(ex.ToString());
            CurrentFormState = FormState.Busy;
         }
         Cursor.Current = Cursors.Default;
      }

      internal void ToggleDesignMode() 
      {
         ForeColor = Design.ForeColor;
         BackColor = Design.BackColor;
         TB_CN_1.ForeColor = TB_CN_2.ForeColor = TB_CN_3.ForeColor = TB_FolderPath.ForeColor = TB_SeriesName.ForeColor = Design.ForeColor;
         TB_CN_1.BackColor = TB_CN_2.BackColor = TB_CN_3.BackColor = TB_FolderPath.BackColor = TB_SeriesName.BackColor = Design.BackColor;
         foreach (var item in RadioButtonGroup)
         { item.ForeColor = Design.ForeColor; item.Refresh(); }
         P_Space_1.BackColor = P_Space_2.BackColor = P_Space_3.BackColor = P_Space_4.BackColor =
            P_Space_5.BackColor = Design.DarkColor;
         CB_Add0.ForeColor = CB_CleanFolders.ForeColor = CB_CustomName.ForeColor = CB_ShowSeason.ForeColor =
            CB_IncSubs.ForeColor = CB_ReOrderFolders.ForeColor = CB_MovieMode.ForeColor = Design.ForeColor;
         CB_Add0.Refresh();
         CB_CleanFolders.Refresh();
         CB_CustomName.Refresh();
         CB_ShowSeason.Refresh();
         CB_IncSubs.Refresh();
         CB_ReOrderFolders.Refresh();
         CB_MovieMode.Refresh();
         PB_Refresh.Image = Design == FormDesign.Dark ? Properties.Resources.Icon_Refresh : Properties.Resources.Icon_Refresh_B;
      }

      public void AddSubtitles()
      {
         DeleteSubtitles();

         try
         {
            var SubFiles = Directory.GetFiles(TB_FolderPath.Text, "*.srt", SearchOption.AllDirectories);            
            var Subs = new List<Subtitle>();

            if (MovieMode)
            {
               foreach (var item in SubFiles)
                  Subs.Add(new Subtitle(item));

               foreach (var Movie in Movies)
                  Movie.AddSubs(Subs.Where(x => MatchMovieAndSubs(x, Movie)));

               foreach (var Movie in Movies)
                  foreach (var Sub in Movie.Subs)
                     Sub.Movie = Movie;

               L_SubCount.Text = (Movies.Sum(x => x.Subs.Count)).ToString();
            }
            else
            {
               foreach (var item in SubFiles.Where(x => Episode.PathIsValid(x)))
                  Subs.Add(new Subtitle(item));

               foreach (var Season in Seasons)
                  foreach (var Episode in Season.Episodes)
                     Episode.AddSubs(Subs.Where(s => s.EpisodeNumber == Episode.EpisodeNumber && s.SeasonNumber == Episode.SeasonNumber));

               foreach (var Season in Seasons)
                  foreach (var Episode in Season.Episodes)
                     foreach (var Sub in Episode.Subs)
                        Sub.Episode = Episode;

               L_SubCount.Text = (Seasons.Sum(e => e.Episodes.Sum(x => x.Subs.Count))).ToString();
            }
         }
         catch (Exception ex)
         {
            DeleteSubtitles();
            Form1.ShowError(ex.Message);
            L_SeasonCount.Text = L_EpCount.Text = L_SubCount.Text = "0";
            L_SeasonCount.ForeColor = L_EpCount.ForeColor = L_SubCount.ForeColor = Color.FromArgb(242, 60, 53);
            Clipboard.SetText(ex.ToString());
            CurrentFormState = FormState.Busy;
         }
      }

      private bool MatchMovieAndSubs(Subtitle sub, Movie movie)
      {
         if (Path.GetFileNameWithoutExtension(movie.FilePath).SpellCheck(Path.GetFileNameWithoutExtension(sub.FilePath), 3, false))
            return true;
         if (Path.GetFileNameWithoutExtension(sub.FilePath).Contains(Path.GetFileNameWithoutExtension(movie.FilePath)))
            return true;
         if (Directory.GetFiles(Directory.GetParent(movie.FilePath).FullName, "*.srt", SearchOption.AllDirectories).Count() <= 3
            && Directory.GetFiles(Directory.GetParent(movie.FilePath).FullName, "*.srt", SearchOption.AllDirectories).Any(x => x.ToLower() == sub.FilePath.ToLower()))
            return true;

         return false;
      }

      public void DeleteSubtitles()
      {
         foreach (var Season in Seasons)
            foreach (var Episode in Season.Episodes)
            { Episode.Control?.ClearSubs(); Episode.Subs.Clear(); }
         foreach (var Movie in Movies)
         { Movie.Control?.ClearSubs(); Movie.Subs.Clear(); }
      }

      private bool FolderContains(string P1, string P2)
      {
         P1 = Path.GetFullPath(P1); P2 = Path.GetFullPath(P2);
         while(P1 != P2)
         {
            if (Directory.GetParent(P2) != null)
               P2 = Directory.GetParent(P2).FullName;
            else
               return false;
         }
         return true;
      }

      private void B_Browse_Click(object sender, EventArgs e)
      {
         if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            TB_FolderPath.Text = folderBrowserDialog.SelectedPath;
      }

      private void TB_FolderPath_TextChanged(object sender, EventArgs e)
      {
         if (TB_FolderPath.Text.EndsWith("\\") && !Directory.Exists(TB_FolderPath.Text.RemoveAt(TB_FolderPath.Text.Length - 1)))
         { DisableTextChange = true; TB_FolderPath.Text = LastSpecificPathText[1] + "\\"; TB_FolderPath.Select(TB_FolderPath.Text.Length, 0); DisableTextChange = false; }
         if (!DisableTextChange && (TB_FolderPath.Text.EndsWith("\\") || !Directory.Exists(TB_FolderPath.Text)) && TB_FolderPath.Text.ToLower() != LastSpecificPathText[0].ToLower())
         {
            try
            {
               LastSpecificPathText[0] = TB_FolderPath.Text;
               var SelectIndex = TB_FolderPath.SelectionStart;
               var NextDirectories = Directory.GetDirectories(Directory.GetParent(TB_FolderPath.Text).FullName);
               var NextDirectory = NextDirectories.Where(x => x.ToLower().StartsWith(TB_FolderPath.Text.ToLower())).FirstOrDefault();
               if (NextDirectory != null)
               { TB_FolderPath.Text = NextDirectory; TB_FolderPath.Select(SelectIndex, NextDirectory.Length - SelectIndex); }
            }
            catch (Exception) { }
         }
         LastSpecificPathText[1] = TB_FolderPath.Text;
         CurrentFormState = GetFormState();
         if (TB_FolderPath.Text == "" || (Directory.Exists(TB_FolderPath.Text) && Directory.GetParent(TB_FolderPath.Text) != null))
         {
            Form1.ClearError();

            RefreshFolder();

            if (!MovieMode)
            {
               if (TB_FolderPath.Text.DirectoryName().ToLower().Contains("season"))
                  TB_SeriesName.Text = NameExtractor.GetSeriesName(TB_FolderPath.Text.Parent().DirectoryName());
               else
                  TB_SeriesName.Text = NameExtractor.GetSeriesName(TB_FolderPath.Text.DirectoryName());
            }
         }
         else
         {
            if(Directory.Exists(TB_FolderPath.Text) && Directory.GetParent(TB_FolderPath.Text) == null)
               Form1.ShowError("Directory can not be Drive Root");
            CurrentFormState = FormState.Busy;
         }
      }

      private void RB_Style_CheckChanged(object sender, EventArgs e)
      {
         if(MovieMode)
         {
            if (!(sender as MyRadioButton).Checked)
               (sender as MyRadioButton).Checked = true;
            return;
         }
         if ((sender as MyRadioButton).Checked)
         {
            SelectedNamingStyle = (sender as MyRadioButton).ID;
         }
         else if (SelectedNamingStyle == (sender as MyRadioButton).ID)
            SelectedNamingStyle = -1;
         if (CB_CustomName.Checked && !(sender as MyRadioButton).Checked && (sender as MyRadioButton).ID == 0)
            CB_CustomName.Checked = false;
         CurrentFormState = GetFormState();
      }

      private void PB_Refresh_Click(object sender, EventArgs e) => RefreshFolder();

      private void TB_SeriesName_TextChanged(object sender, EventArgs e)
      {
         CurrentFormState = GetFormState();
         foreach (var item in RadioButtonGroup)
         {
            item.Text = NamingStyles[item.ID].GetEpName(new Episode(2, 13, "EpName"));
            item.ForceResize();
         }
      }

      private void CB_IncSubs_CheckChanged(object sender, EventArgs e)
      {
         if (CB_IncSubs.Checked)
         {
            AddSubtitles();
            LabelSubs.Show();
            L_SubCount.Show();
            P_TotEps.Dock = DockStyle.None;
         }
         else
         {
            DeleteSubtitles();
            LabelSubs.Hide();
            L_SubCount.Hide();
            P_TotEps.Dock = DockStyle.Right;
         }
      }

      private void CB_CustomName_CheckChanged(object sender, EventArgs e)
      {
         if (SelectedNamingStyle > 0)
         {
            TB_CN_1.Text = NamingStyles[SelectedNamingStyle].PreSeason;
            TB_CN_2.Text = NamingStyles[SelectedNamingStyle].PreEpisode;
            TB_CN_3.Text = NamingStyles[SelectedNamingStyle].PreName;
            RadioButtonGroup[SelectedNamingStyle].Checked = false;
         }
         RB_CName.Checked = CB_CustomName.Checked;
         P_CustomName.Visible = CB_CustomName.Checked;
         SelectedNamingStyle = RB_CName.Checked ? 0 : -1;
         RB_CName.ForceResize();
      }

      private void TB_CN_TextChanged(object sender, EventArgs e)
      {
         NamingStyles[0].PreSeason  = TB_CN_1.Text;
         NamingStyles[0].PreEpisode = TB_CN_2.Text;
         NamingStyles[0].PreName    = TB_CN_3.Text;
         if(MovieMode)
            RB_CName.Text = NamingStyles[0].GetMovieName(new Movie("", 2017));
         else
            RB_CName.Text = NamingStyles[0].GetEpName(new Episode(2, 13, "EpName"));
         RB_CName.ForceResize();
      }

      private void CB_MovieMode_CheckChanged(object sender, EventArgs e)
      {
         if (CB_MovieMode.Checked)
         {
            SelectedNamingStyle = 0;
            CB_CustomName.Checked = true;
            TitleName = "Movies Re-Namer v2";
            L_CN_1.Text = "Movie Name ";
            L_CN_2.Text = "Year ";
            TB_CN_1.Text = " (";
            TB_CN_2.Text = ")";
            LabelSeasons.Text = "Movies:";
            TB_SeriesName.Text = "Movie Mode";
            TB_SeriesName.TextAlign = HorizontalAlignment.Center;
            RB_CName.Text = NamingStyles[0].GetMovieName(new Movie("", 2017));
         }
         else
         {
            TitleName = "TV Series Re-Namer v2";
            L_CN_1.Text = "Series Name ";
            L_CN_2.Text = "Season № ";
            TB_CN_1.Text = " - S";
            TB_CN_2.Text = "E";
            TB_CN_3.Text = " - ";
            LabelSeasons.Text = "Seasons:";
            TB_SeriesName.Text = "";
            TB_SeriesName.TextAlign = HorizontalAlignment.Left;
         }

         Form1.L_Title.Text = TitleName;
         Form1.Text = TitleName.Remove(" v2");
         TB_CN_3.Visible = L_CN_3.Visible = L_CN_4.Visible = TB_SeriesName.Enabled = P_TotEps.Visible =
            CB_Add0.Enabled = CB_CustomName.Enabled = CB_ShowSeason.Enabled = !CB_MovieMode.Checked;

         RefreshFolder();

         MainSubForm_Resize(this, e);
      }

      private void B_Continue_Click(object sender, EventArgs e)
      {
         if (TB_FolderPath.Text.Length < 3 || !Directory.Exists(TB_FolderPath.Text))
         { MessageBox.Show("Folder Path is not Valid", "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (L_SeasonCount.Text == "0") 
         { MessageBox.Show("No " + (MovieMode ? "movies" : "episodes") + " were detected, choose another folder", "No Files Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (SelectedNamingStyle == -1) 
         { MessageBox.Show("No Naming Style is selected, choose a naming style before continuing", "No Naming Style", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (TB_SeriesName.Text == "") 
         { MessageBox.Show("Series Name can not be Empty", "No Series Name", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (!MovieMode && !Episode.EpIsValid(NamingStyles[SelectedNamingStyle].GetEpName(new Episode(2, 13, "Ep Name"))))
         {
            if (DialogResult.Cancel == MessageBox.Show("The current Naming Style will not be \ndetectable by the App after the Re-Name.\n\nDo you want to continue anyway?", "Naming Style Undetectable", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
               if (!AddNamingRule())
                  return;
            }
            else
               AddNamingRule();
         }

         Cursor.Current = Cursors.WaitCursor;
         foreach (var Season in Seasons)
         {
            Season.Control?.RefreshName();
            foreach (var Episode in Season.Episodes)
            {
               Episode.Control?.RefreshName();
               foreach (var Sub in Episode.Subs)
                  Sub.Control?.RefreshName();
            }
         }

         foreach (var Movie in Movies)
         {
            Movie.Control?.RefreshName();
            foreach (var Sub in Movie.Subs)
               Sub.Control?.RefreshName();
         }

         Form1.reviewSubForm.CB_CleanFolders.Checked = O_CleanFolders;
         Form1.reviewSubForm.CB_ReOrderFolders.Checked = O_ReOrderFolders;
         Form1.reviewSubForm.ToggleDesignMode();
         Form1.reviewSubForm.Show();
         Hide();
         Cursor.Current = Cursors.Default;
      }

      private void B_Rename_Click(object sender, EventArgs e)
      {
         if (TB_FolderPath.Text.Length < 3 || !Directory.Exists(TB_FolderPath.Text))
         { MessageBox.Show("Folder Path is not Valid", "Invalid Folder Path", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (L_SeasonCount.Text == "0")
         { MessageBox.Show("No " + (MovieMode ? "movies" : "episodes") + " were detected, choose another folder", "No Files Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (SelectedNamingStyle == -1)
         { MessageBox.Show("No Naming Style is selected, choose a naming style before continuing", "No Naming Style", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (TB_SeriesName.Text == "")
         { MessageBox.Show("Series Name can not be Empty", "No Series Name", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
         if (!MovieMode && !Episode.EpIsValid(NamingStyles[SelectedNamingStyle].GetEpName(new Episode(2, 13, "Ep Name"))))
         {
            if (DialogResult.Cancel == MessageBox.Show("The current Naming Style will not be \ndetectable by the App after the Re-Name.\n\nDo you want to continue anyway?", "Naming Style Undetectable", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
            {
               if (!AddNamingRule())
                  return;
            }
            else
               AddNamingRule();
         }

         Form1.renameSubForm.Prepare();
         Form1.renameSubForm.Show();
         Hide();
         Form1.renameSubForm.Start();
      }

      private bool AddNamingRule()
      {
         if (DialogResult.No == MessageBox.Show("Do you want to save this Naming Style\nso the app can recognize it in the future?", "Save Naming Style?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            return false;
         List<string> SavedStyles;
         if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "NamingStyles.dll")))
            SavedStyles = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "NamingStyles.dll")).ToList();
         else
            SavedStyles = new List<string>();

         if(O_ShowSeason)
            SavedStyles.Add($@"{Regex.Escape(NamingStyles[SelectedNamingStyle].PreSeason)}(\d+)(?:.+)?{Regex.Escape(NamingStyles[SelectedNamingStyle].PreEpisode)}(\d+)");
         else
            SavedStyles.Add($@"([a-z])(?:.+)?{Regex.Escape(NamingStyles[SelectedNamingStyle].PreEpisode)}(\d+)");

         File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "NamingStyles.dll"), SavedStyles.ToArray());
         return true;
      }

      private FormState GetFormState()
      {
         if (TB_FolderPath.Text == "")
            return FormState.Normal;
         if (TB_FolderPath.Text.Length < 3 || !Directory.Exists(TB_FolderPath.Text))
            return FormState.Busy;
         if (L_SeasonCount.Text == "0")
         {
            L_SeasonCount.ForeColor = L_EpCount.ForeColor = L_SubCount.ForeColor = FormState.Working.Color;
            return FormState.Working;
         }
         if (SelectedNamingStyle == -1 || TB_SeriesName.Text == "")
            return FormState.Working;
         return FormState.Normal;
      }
   }
}
