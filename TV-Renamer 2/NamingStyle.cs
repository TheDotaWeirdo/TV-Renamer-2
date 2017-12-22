using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public class NamingStyle
   {
      private string preSeason  = " ";
      private string preEpisode = " ";
      private string preName    = " ";

      public string PreSeason  { get => preSeason;  set => preSeason  = (value == "" ? " " : value); }
      public string PreEpisode { get => preEpisode; set => preEpisode = (value == "" ? " " : value); }
      public string PreName    { get => preName;    set => preName    = (value == "" ? " " : value); }

      public NamingStyle() { }

      public NamingStyle(string preSeason, string preEpisode, string preName)
      { PreSeason = preSeason; PreEpisode = preEpisode; PreName = preName; }

      public string GetEpName(Episode Ep)
         => $"{(SeriesName == "" ? "Series" : SeriesName)}{(O_ShowSeason ? PreSeason + Ep.SeasonNumber.AddZeros() : (PreEpisode[0] == ' ' ? "" : " "))}{PreEpisode}{Ep.EpisodeNumber.AddZeros()}{(Ep.EpisodeName != "" ? PreName + Ep.EpisodeName : "")}";

      public string GetSubName(Subtitle Sub, Movie Movie)
         => (Sub != null && Movie != null ? GetMovieName(Movie) + (Sub.Name != "" ? " - " : "") + Sub.Name : "Subtitle");

      public string GetSubName(Subtitle Sub, Episode Episode)
         => (Sub != null && Episode != null ? GetEpName(Episode) + (Sub.Name != "" ? " - " : "") + Sub.Name : "Subtitle");

      public string GetMovieName(Movie Movie)
         => $"{(Movie.Name == "" ? "Movie Name" : Movie.Name)}{(Movie.Year > 0 ? PreSeason + Movie.Year + PreEpisode : "")}";
   }
}
