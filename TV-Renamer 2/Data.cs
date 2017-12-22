using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Renamer_2
{
   public partial class MainForm
   {
      public static class Data
      {
         public static Version Version = new Version(2, 3, 6);
         public static string TitleName = "TV Series Re-Namer v2";
         public static FormDesign Design = FormDesign.Dark;

         public static MainForm Form1;

         private static FormState currentFormState = FormState.N_Focused;

         public static FormState CurrentFormState
         {
            get => currentFormState;
            set { currentFormState = value; Form1?.Invoke(new Action(() => { Form1.BackColor = value.Color; })); }
         }

         public static EpisodeControl ActiveEpisodeControl;
         public static SeasonControl ActiveSeasonControl;
         public static MovieControl ActiveMovieControl;

         public static NamingStyle[] NamingStyles =
         {
            new NamingStyle(),
            new NamingStyle(" - S", "E", " - "),
            new NamingStyle(" ", "x", " "),
            new NamingStyle(" Season ", " - E", " - "),
            new NamingStyle(" S", " - Episode ", " - "),
         };

         public static int SelectedNamingStyle = -1;

         public static List<MyRadioButton> RadioButtonGroup;

         public static List<Season> Seasons = new List<Season>();
         public static List<Movie>  Movies  = new List<Movie>();
         public static List<string> JunkFiles = new List<string>();

         public static bool FormIsActive = true;

         public static string[] BlackList;
         public static string FolderPath => (Form1 != null ? Form1.mainSubForm.TB_FolderPath.Text : "");
         public static string SeriesName => (Form1 != null ? Form1.mainSubForm.TB_SeriesName.Text : "");

         public static bool MovieMode        => Form1 != null && Form1.mainSubForm.CB_MovieMode.Checked;
         public static bool O_ShowSeason     => Form1 != null && Form1.mainSubForm.CB_ShowSeason.Checked;
         public static bool O_AddZeros       => Form1 != null && Form1.mainSubForm.CB_Add0.Checked;
         public static bool O_CleanFolders   => Form1 != null && Form1.mainSubForm.CB_CleanFolders.Checked;
         public static bool O_IncludeSubs    => Form1 != null && Form1.mainSubForm.CB_IncSubs.Checked;
         public static bool O_ReOrderFolders => Form1 != null && Form1.mainSubForm.CB_ReOrderFolders.Checked;

         public static string[] CharBlackList =
         {
            "\\", "/", ":", "?", "\"", "<", ">", "|"
         };

         private static string[] VideoExtensions =
         {
            ".mkv"  , ".webm" , ".flv"  , "vob"   , ".ogv",
            ".ogg"  , ".drc"  , ".mng"  , ".avi"  , ".mov",
            ".wmv"  , ".amv"  , ".mp4"  , ".m4p"  , ".m4v",
            ".mpg"  , ".mpeg" , ".3gp"  , ".f4v"  , ".amv"
         };
         public static bool IsVideoFile(string File) => VideoExtensions.Any(x => File.EndsWith(x));
      }
   }
}
