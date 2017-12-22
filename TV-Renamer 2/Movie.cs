using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public class Movie
   {
      public string FilePath { get; private set; }
      public string Name;
      public int Year;
      public List<Subtitle> Subs = new List<Subtitle>();
      public MovieControl Control;

      public Movie(string path)
      {
         FilePath = path;
         var NY = NameExtractor.GetMovieNameYear(Path.GetFileNameWithoutExtension(path));
         Name = NY.Key;
         Year = NY.Value;
      }

      public Movie(string N, int Y)
      {
         Name = N;
         Year = Y;
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

      public string Destination
      {
         get
         {
            if (!O_ReOrderFolders)
               return Path.Combine(Directory.GetParent(FilePath).FullName, ToString() + Path.GetExtension(FilePath));
            Directory.CreateDirectory(Path.Combine(FolderPath, Name));
            return Path.Combine(FolderPath, Name, ToString() + Path.GetExtension(FilePath));
         }
      }

      public string ExtractName() => NameExtractor.GetEpisodeName(Path.GetFileNameWithoutExtension(FilePath));

      public override string ToString() => (SelectedNamingStyle == -1 ? "" : NamingStyles[SelectedNamingStyle].GetMovieName(this));
   }
}
