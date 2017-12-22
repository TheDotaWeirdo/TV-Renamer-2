using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public class Subtitle
   {
      public string FilePath { get; private set; }
      public int SeasonNumber { get; private set; }
      public int EpisodeNumber { get; private set; }
      public Episode Episode;
      public Movie Movie;
      public SubtitleControl Control;

      public string Name;

      public Subtitle(string path)
      {
         FilePath = path;
         Name = NameExtractor.GetSubtitleName(Path.GetFileNameWithoutExtension(FilePath));
         if (MovieMode) return;
         var filename = Path.GetFileNameWithoutExtension(path);
         foreach (var RX in TV_Renamer_2.Episode.Tests)
         {
            if (RX.IsMatch(filename))
            {
               SeasonNumber = int.Parse(RX.Match(filename).Groups[1].Value);
               EpisodeNumber = int.Parse(RX.Match(filename).Groups[2].Value);
               return;
            }
         }
         throw new Exception("Given File is not Valid");
      }

      public string Destination
      {
         get
         {
            if (!O_ReOrderFolders)
               return Path.Combine(Directory.GetParent(FilePath).FullName, ToString() + ".srt");
            var Folder = Path.Combine(Directory.GetParent(MovieMode ? Movie.Destination : Episode.Destination).FullName, "Subtitles");
            Directory.CreateDirectory(Folder);
            return Path.Combine(Folder, ToString() + ".srt");
         }
      }

      public override string ToString() => (SelectedNamingStyle == -1 ? "Subtitle" : MovieMode ? NamingStyles[SelectedNamingStyle].GetSubName(this, Movie) : NamingStyles[SelectedNamingStyle].GetSubName(this, Episode)); 
   }
}
