using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public static class NameExtractor
   {
      public static string[] PreBlackList =
      {
         "ShAaNiG", @"\[.+\]", "[\\d\\.]+[mkg]b", "\\d+bit", "AAC", "AC\\d", "WEBRip", "WEB.?DL", "\\d\\.?\\d?[cC][Hh]",
         "BluRay", "HDTV", "E\\.Subs", "AM(Z|azo)N", "H.?\\d{3}", @"DD(P|.)?\d\.?\d?(.H)?",
         "HEVC", "EN", "WEB", "[Ii]NTERNAL", "REPACK", "PROPER", "BDRip", "BrRip", "YIFY", "Joy", "XviD",
         "MkvCage", "mkv", "opus", "bluury", "Qman", "3d", "R6", "hd"
      };

      static string[] LanguageCaptures =
      {
         "English", "French", "Arabic",
         "en", "fr", "ar", "ru",
         "(SDH)"
      };

      public static string GetEpisodeName(string S)
         => S.RemoveGeneralTorrentWords().Where(x => !CharBlackList.Contains(x.ToString())).RemoveSeriesAndNumbers().DotRemover().RemoveDoubleSpaces().ToCapital();

      public static string GetSeriesName(string S)
         => S.RemoveGeneralTorrentWords().Where(x => !CharBlackList.Contains(x.ToString())).ExtractSeriesName().DotRemover().RemoveDoubleSpaces().ToCapital();

      public static KeyValuePair<string, int> GetMovieNameYear(string S)
      {
         S = S.RemoveGeneralTorrentWords().DotRemover().Where(x => !CharBlackList.Contains(x.ToString()));
         return new KeyValuePair<string, int>(S.RegexRemover(new Regex("(?:[^\\w\\d\\s]|\\b)?\\d{4}(?:[^\\w\\d\\s]|\\b)?")).RemoveDoubleSpaces().ToCapital(), new Regex("\\b\\d{4}\\b").Match(S).ToString().SmartParse());
      }

      public static string GetSubtitleName(string S)
      {
         var SB = new StringBuilder();
         foreach (var item in LanguageCaptures)
         {
            if (Regex.IsMatch(S, $@"\b{Regex.Escape(item)}\b", RegexOptions.IgnoreCase))
               SB.Append(item);
         }
         return SB.ToString();
      }

      private static string DotRemover(this string S)
      {
         S = S.RegexRemover("\\.+$");
         if (S.Length < 3) return S;
         var SB = new StringBuilder(S.Length);
         SB.Append(S[0]);
         for (int i = 1; i < S.Length - 1; i++)
         {
            if (char.IsUpper(S[i - 1]) && S[i] == '.' && char.IsUpper(S[i + 1]))
               SB.Append(".");
            else if (S[i] != '.')
               SB.Append(S[i]);
            else
               SB.Append(' ');
         }
         SB.Append(S[S.Length - 1]);
         S = SB.ToString();
         var Matches = new Regex("([A-Z]\\.)+([A-Z]$)?").Matches(S);
         foreach (var item in Matches)
            S = S.Insert(S.IndexOf(item.ToString()) + item.ToString().Length, " ");
         S = S.RegexRemover(new Regex("^\\s?-\\s?"));
         S = S.RegexRemover(@"-$");
         return S;
      }

      private static string RegexRemover(this string S, string RX)
         => S.RegexRemover(new Regex(RX));

      private static string RegexRemover(this string S, Regex RX)
      {
         if (RX.IsMatch(S))
         {
            var Matches = RX.Matches(S);
            foreach (var item in Matches)
               S = S.Remove(item.ToString());
         }
         return S;
      }

      private static string RemoveGeneralTorrentWords(this string S)
      {
         foreach (var item in BlackList)
            S = S.RegexRemover(new Regex(item, RegexOptions.IgnoreCase));
         S = S.RegexRemover(new Regex("\\w?\\d{3,4}[pP]"));
         S = S.RegexRemover(new Regex("[Xx]\\d{3}"));
         S = S.RegexRemover(new Regex("\\.\\d{3}\\b"));
         S = S.RegexRemover(new Regex("-\\w+\\b"));
         S = S.RegexRemover(new Regex("\\d\\.\\d"));
         S = S.RegexRemover(new Regex(@"\(\s+?\)"));
         return S;
      }

      private static string RemoveSeriesAndNumbers(this string S)
      {
         foreach (var RX in Episode.Tests)
         {
            if (RX.IsMatch(S))
               return S.Substring(S.IndexOf(RX.Match(S).Groups[0].Value) + RX.Match(S).Groups[0].Value.Length).StartWithLetter();
         }

         return S;
      }

      private static string ExtractSeriesName(this string S)
      {
         Regex RX = new Regex("[sS](\\d+)(.+)?[eE](\\d+)");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         RX = new Regex("(\\d+)x(\\d+)");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         RX = new Regex("[Ss]eason\\s+?(\\d+)(.+)?[Ee]pisode\\s+?(\\d+)");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         RX = new Regex("[Ss]eason\\s+?(\\d+)(.+)?[Ee](\\d+)");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         RX = new Regex("[Ss](\\d+)(.+)?[Ee]pisode\\s+?(\\d+)");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         RX = new Regex("\\b(\\d)(\\d\\d)\\b");
         if (RX.IsMatch(S))
            return S.Remove(S.IndexOf(RX.Match(S).Groups[0].Value));

         return S;
      }

      private static string StartWithLetter(this string S)
      {
         for (int i = 0; i < S.Length; i++)
            if (char.IsLetter(S[i]))
               return S.Substring(i);
         return S;
      }
   }
}
