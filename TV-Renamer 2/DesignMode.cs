using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Renamer_2
{
   public class FormDesign
   {
      public static FormDesign Dark = new FormDesign()
      {
         BackColor  = Color.FromArgb(65, 71, 87),
         TitleColor = Color.FromArgb(61, 65, 77),
         TitleForeColor = Color.White,
         ForeColor  = Color.FromArgb(250, 250, 250),
         LightColor = Color.FromArgb(70, 76, 93),
         DarkColor  = Color.FromArgb(61, 65, 77),
      };

      public static FormDesign Light = new FormDesign()
      {
         BackColor  = Color.FromArgb(242, 244, 247),
         TitleColor = Color.FromArgb(233, 234, 240),
         TitleForeColor = Color.FromArgb(85, 92, 110),
         ForeColor  = Color.FromArgb(52, 54, 62),
         LightColor = Color.FromArgb(247, 247, 249),
         DarkColor  = Color.FromArgb(228, 230, 234),
      };

      private FormDesign() { }

      public Color BackColor;
      public Color TitleColor;
      public Color TitleForeColor;
      public Color ForeColor;
      public Color LightColor;
      public Color DarkColor;

   }
}
