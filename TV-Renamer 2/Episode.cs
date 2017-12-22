using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public class Episode
   {
      private static Regex[] _Tests = new Regex[]
      {
         new Regex(@"s(\d+)(?:.+)?e(\d+)", RegexOptions.IgnoreCase),
         new Regex(@"(\d+)x(\d+)", RegexOptions.IgnoreCase),
         new Regex(@"season\s+?(\d+)(?:.+)?episode\s+?(\d+)", RegexOptions.IgnoreCase),
         new Regex(@"season\s+?(\d+)(?:.+)?e(\d+)", RegexOptions.IgnoreCase),
         new Regex(@"s(\d+)(?:.+)?episode\s+?(\d+)", RegexOptions.IgnoreCase),
         new Regex(@"\b(\d)\s?(\d\d)\b"),
      };

      public static Regex[] Tests
      { get
         {
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "NamingStyles.dll")))
            {
               var tests = new List<Regex>(_Tests);
               foreach (var item in File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "NamingStyles.dll")))
                  tests.Add(new Regex(item));
               return tests.ToArray();
            }
            return _Tests;
         }
      }

      public string FilePath { get; private set; }
      public int SeasonNumber { get; private set; }
      public int EpisodeNumber { get; private set; }
      public string EpisodeName = "";
      public Season Season;
      public List<Subtitle> Subs = new List<Subtitle>();
      public EpisodeControl Control;

      public Episode(string path)
      {
         FilePath = path;
         var filename = Path.GetFileNameWithoutExtension(path);
         foreach (var RX in Tests)
         {
            if (RX.IsMatch(filename))
            {
               SeasonNumber = RX.Match(filename).Groups[1].Value.SmartParse();
               EpisodeNumber = RX.Match(filename).Groups[2].Value.SmartParse();
               EpisodeName = ExtractName();
               return;
            }
         }
         throw new Exception("Given File is not Valid");
      }

      public void AddSubs(IEnumerable<Subtitle> subtitles)
      {
         try
         {
            if (subtitles != null && subtitles.Count() > 0)
            {
               Subs.AddRange(subtitles);
               if (Control != null)
                  Control.AddSubs();
            }
         }
         catch (Exception) { }
      }

      public Episode(int S, int E, string N)
      {
         SeasonNumber = S;
         EpisodeNumber = E;
         EpisodeName = N;
      }

      public string Destination
      {
         get
         {
            if (!O_ReOrderFolders)
               return Path.Combine(Directory.GetParent(FilePath).FullName, ToString() + Path.GetExtension(FilePath));
            Directory.CreateDirectory(Path.Combine(FolderPath, Season.ToString()));
            return Path.Combine(FolderPath, Season.ToString(), ToString() + Path.GetExtension(FilePath));
         }
      }

      public string ExtractName() => NameExtractor.GetEpisodeName(Path.GetFileNameWithoutExtension(FilePath));

      public override string ToString() => (SelectedNamingStyle == -1 ? "" : NamingStyles[SelectedNamingStyle].GetEpName(this));

      public static bool PathIsValid(string path)
         => Tests.Any(rx => rx.IsMatch(Path.GetFileNameWithoutExtension(path)));
      public static bool EpIsValid(string episodeName)
         => Tests.Any(rx => rx.IsMatch(episodeName));
   }
}
