using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Renamer_2
{
   public class Season
   {
      public int SeasonNumber = 0;
      public string SeasonName = "";
      public List<Episode> Episodes;
      public SeasonControl Control;

      public Season(int SNumber, List<Episode> Eps)
      {
         SeasonNumber = SNumber;
         Episodes = Eps;
         foreach (var item in Eps)
            item.Season = this;
      }

      public static int[] GetSeasons(List<Episode> list)
      {
         var Out = new List<int>();
         foreach (var item in list)
            Out.Add(item.SeasonNumber);
         return Out.Distinct().ToArray();
      }

      public override string ToString() => "Season " + SeasonNumber + (SeasonName != "" ? " - " + SeasonName : "");  
   }
}
