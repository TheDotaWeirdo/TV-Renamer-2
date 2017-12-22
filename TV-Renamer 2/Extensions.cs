using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Renamer_2
{
   public static class ExtensionClass
   {
      public static string AddZeros(this int i)
      {
         var Out = i.ToString();
         if (MainForm.Data.O_AddZeros && Out.Length < 2)
            return "0" + Out;
         return Out;            
      }

      public static string Parent(this string S)
         => Directory.GetParent(S).FullName;

      public static string DirectoryName(this string S)
         => Path.GetFileName(S);

      //***********************************************************************//

      private static Random RNG = new Random(Guid.NewGuid().GetHashCode());

      public static int Scale(this int Base, int Scale, int Min, int Max, double Multiplier = 1)
         => (int)Math.Min(Math.Max(Min, Base * Scale * Multiplier), Max);

      public static double Scale(this double Base, double Scale, double Min, double Max, double Multiplier = 1)
         => Math.Min(Math.Max(Min, Base * Scale * Multiplier), Max);

      public static float Scale(this float Base, float Scale, float Min, float Max, double Multiplier = 1)
         => (float)Math.Min(Math.Max(Min, Base * Scale * Multiplier), Max);

      public static void Swap<T>(ref T O1, ref T O2)
      { T O = O1; O1 = O2; O2 = O; }

      public static T Random<T>(this List<T> L)
         => L[RNG.Next(L.Count)];

      public static T Random<T>(this T[] A)
         => A[RNG.Next(A.Length)];

      public static string RemoveAt(this string S, int index)
         => S.Remove(index, 1);

      public static bool ContainsWord(this string S, string Word)
         => Regex.IsMatch(S, @"\b" + Regex.Escape(Word) + @"\b");

      public static string Remove(this string S, string text)
         => S.IndexOf(text) >= 0 ? S.Remove(S.IndexOf(text), text.Length) : S;

      public static string ToCapital(this string S, bool ForceLowerCase = true)
         => Regex.Replace(ForceLowerCase ? S.ToLower() : S, @"\b(([A-z])(\w+)?)", new MatchEvaluator(x => ToUpper(x, S)));

      private static string ToUpper(Match match, string Base)
      { var low = match.Value.ToLower();
         if (!(match.Index > 0 && char.IsLetter(low[0]) && Base[match.Index - 1] == '\'') &&
            ((match.Index == 0) || (!(low == "the" || low == "in" || low == "of" || low == "at" || low == "and"))))
            return match.Value[0].ToString().ToUpper() + (match.Length == 0 ? "" : match.Value.Substring(1));
         return match.Value;
      }
      
      public static void Center(this Control C, Control Control, double Xoffset = 0.5, double Yoffset = 0.5)
         => C.Location = new System.Drawing.Point((int)((Control.Bounds.Width - C.Bounds.Width) * Xoffset), (int)((Control.Bounds.Height - C.Bounds.Height) * Yoffset));

      public static void Center(this Control C, System.Drawing.Rectangle Bounds, double Xoffset = 0.5, double Yoffset = 0.5)
         => C.Location = new System.Drawing.Point((int)((Bounds.Width - C.Bounds.Width) * Xoffset), (int)((Bounds.Height - C.Bounds.Height) * Yoffset));

      public static int SmartParse(this string S)
         => (int.TryParse(S.Where(c => char.IsDigit(c)), out var i)) ? i : 0;

      public static string RegexReplace(this string S, string Pattern, string Replacement = "", bool IgnoreCase = true)
         => IgnoreCase ? Regex.Replace(S, Pattern, Replacement, RegexOptions.IgnoreCase) : Regex.Replace(S, Pattern, Replacement);

      public static string RegexRemove(this string S, string Pattern, int Group = 0, bool IgnoreCase = true)
         => IgnoreCase ? Regex.Replace(S, Pattern, x => x.Value.Remove(x.Groups[Group].Value), RegexOptions.IgnoreCase) : Regex.Replace(S, Pattern, x => x.Value.Remove(x.Groups[Group].Value));
      
      public static bool IsFolder(this string S)
         => (Directory.Exists(S)) && File.GetAttributes(S).HasFlag(FileAttributes.Directory);

      public static string ToReadableString(this TimeSpan TS)
      {
         try
         {
            var Out =
               ((TS.Days > 0 ? TS.Days + " day" + (TS.Days != 1 ? "s" : "") + ", " : "") +
               (TS.Hours > 0 ? TS.Hours + " hour" + (TS.Hours != 1 ? "s" : "") + ", " : "") +
               (TS.Minutes > 0 ? TS.Minutes + " minute" + (TS.Minutes != 1 ? "s" : "") + ", " : "") +
               (TS.Seconds > 0 ? TS.Seconds + " second" + (TS.Seconds != 1 ? "s" : "") + ", " : ""));
            return Out.Substring(0, Out.Length - 2);
         }
         catch (Exception)
         { return "0 seconds"; }
      }

      private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
      { {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000} };
      public static int RomanToInteger(this string roman)
      {
         roman = Regex.Match(roman, "[IVXLCDM]+").Value;
         int number = 0;
         for (int i = 0; i < roman.Length; i++)
         {
            if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
               number -= RomanMap[roman[i]];
            else
               number += RomanMap[roman[i]];
         }
         return number;
      }

      public static bool AbreviationCheck(this string S, string S2)
      {
         if (S == "" || S2 == "") return false;
         S = S.ToLower().Replace("'s ", " ");
         S2 = S2.ToLower().Replace("'s ", " ");

         return S.Where(x => x != ' ') == S2.GetAbreviation() || S.GetAbreviation() == S2.Where(x => x != ' ');
      }

      public static string GetAbreviation(this string S)
      {
         var SB = new StringBuilder();
         foreach (var item in S.GetWords())
            SB.Append(item.All(x => char.IsDigit(x)) ? item : item[0].ToString());
         return SB.ToString();
      }

      public static string[] GetWords(this string S)
      {
         if (S == string.Empty) return null;
         var Matches = Regex.Matches(S, @"\b(\w+)(?:'\w+)?\b");
         var Out = new string[Matches.Count];
         for (int i = 0; i < Matches.Count; i++)
            Out[i] = Matches[i].Groups[1].ToString();
         return Out;
      }

      public static string Where(this string S, Func<char, bool> Test)
      {
         var Out = new StringBuilder(S.Length);
         foreach (var c in S)
            if (Test(c))
               Out.Append(c);
         return Out.ToString();
      }

      public static string RemoveDoubleSpaces(this string S)
         => S.RegexReplace(@" {2,}", " ").RegexReplace(@"^ ").RegexReplace(@" $");

      public static bool SpellCheck(this string S1, string S2, int MaxErrors = 2, bool CaseCheck = true)
      {
         if (!CaseCheck)
         { S1 = S1.ToLower(); S2 = S2.ToLower(); }
         S1 = S1.RemoveDoubleSpaces(); S2 = S2.RemoveDoubleSpaces();

         if (S1 == S2) return true;

         var index1 = 0;
         var index2 = 0;

         if (S2.Length > S1.Length)
            Swap(ref S1, ref S2);

         while (index1 < S1.Length)
         {
            if (S1[index1] != S2[index2])
            {
               MaxErrors--;
               if (index1 + 1 < S1.Length && index2 + 1 < S2.Length && S1[index1 + 1] == S2[index2] && S2[index2 + 1] == S1[index1])
               { index1++; index2++; }
               else if (index1 + 1 < S1.Length && S1[index1 + 1] == S2[index2])
                  index1++;
               else if (index2 + 1 < S2.Length && S2[index2 + 1] == S1[index1])
                  index2++;
            }
            index1++; index2++;
            if (index2 >= S2.Length)
            {
               MaxErrors -= index1 - index2;
               return (MaxErrors > 0);
            }
            if (MaxErrors <= 0)
               return false;
         }
         return true;
      }

      public static int SpellCheck(this string S1, string S2, bool CaseCheck = true)
      {
         if (!CaseCheck)
         { S1 = S1.ToLower(); S2 = S2.ToLower(); }
         S1 = S1.RemoveDoubleSpaces(); S2 = S2.RemoveDoubleSpaces();

         if (S1 == S2) return 0;

         var index1 = 0;
         var index2 = 0;
         var Errors = 0;

         if (S2.Length > S1.Length)
            Swap(ref S1, ref S2);

         while (index1 < S1.Length)
         {
            if (index2 >= S2.Length)
            {
               Errors += (S1.Length - index1);
               return Errors;
            }
            if (S1[index1] != S2[index2])
            {
               Errors++;
               if (index1 + 1 < S1.Length && index2 + 1 < S2.Length && S1[index1 + 1] == S2[index2] && S2[index2 + 1] == S1[index1])
               { index1++; index2++; }
               else if (index1 + 1 < S1.Length && S1[index1 + 1] == S2[index2])
                  index1++;
               else if (index2 + 1 < S2.Length && S2[index2 + 1] == S1[index1])
                  index2++;
            }
            index1++; index2++;
         }
         return Errors;
      }

      public static string Between(this string S, char Start, string End)
         => S.Between(Start.ToString(), End);
      public static string Between(this string S, string Start, char End)
         => S.Between(Start, End.ToString());
      public static string Between(this string S, char Start, char End)
         => S.Between(Start.ToString(), End.ToString());
      public static string Between(this string S, string Start, string End, bool IgnoreCase = false)
      {
         var RX = IgnoreCase ? new Regex($@"(?<={Regex.Escape(Start)}).+?(?={Regex.Escape(End)})", RegexOptions.IgnoreCase) : new Regex($@"(?<={Regex.Escape(Start)}).+?(?={Regex.Escape(End)})");
         return RX.IsMatch(S) ? RX.Match(S).Value : S;
      }

      public static void RunInBackground(this Action A, ThreadPriority Priority = ThreadPriority.Normal)
         => new Thread(new ThreadStart(A)) { IsBackground = true, Priority = Priority }.Start();

      public static void RunInBackground(this Action A, int Delay, bool RunOnce = true)
      {
         var T = new System.Timers.Timer(Math.Max(1, Delay)) { AutoReset = !RunOnce };
         T.Elapsed += (s, e) => A();
         T.Start();
      }
   }
}
