using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Renamer_2
{
   public class FormState
   {
      private int Type;
      public static FormState N_Unfocused = new FormState(0);
      public static FormState N_Focused   = new FormState(1);
      public static FormState Busy        = new FormState(2);
      public static FormState Working     = new FormState(3);
      public static FormState Running     = new FormState(4);

      public bool IsNormal => Type == 0 || Type == 1;
      public static FormState Normal => MainForm.Data.FormIsActive ? N_Focused : N_Unfocused;

      private FormState(int Type)
      { this.Type = Type; }

      public override bool Equals(object obj) => Type == (obj as FormState).Type;

      public override int GetHashCode() => base.GetHashCode();

      public Color Color
      {
         get
         {
            switch (Type)
            {
               case 1: return Color.FromArgb(82, 148, 226);
               case 2: return Color.FromArgb(242, 60, 53);
               case 3: return Color.FromArgb(255, 236, 64);
               case 4: return Color.FromArgb(101, 223, 107);
               default:
                  return MainForm.Data.Design.TitleColor;
            }
         }
      }
   }
}