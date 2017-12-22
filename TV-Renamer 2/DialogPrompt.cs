using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV_Renamer_2
{
   public class DialogPrompt
   {
      public static string Show(string Message, string Title = "", string DefaultText = "")
      {
         PromptForm promptForm = new PromptForm(Title, Message, DefaultText);

         promptForm.B_Done.Click += (sender, e) => { promptForm.Close(); };
         promptForm.Deactivate += (s, E) => { promptForm.Close(); };
         promptForm.B_Close.Click += (S, t) => { promptForm.inputBox.Text = DefaultText; promptForm.Close(); };
         promptForm.Refresh();
         promptForm.ShowDialog();
         return promptForm.inputBox.Text;
      }

      public static KeyValuePair<string, int> Show(string Message, string Title, KeyValuePair<string, int> DefValues)
      {
         MoviePromptForm promptForm = new MoviePromptForm(Title, Message, DefValues);

         promptForm.B_Done.Click += (sender, e) => { promptForm.Close(); };
         promptForm.Deactivate += (s, E) => { promptForm.Close(); };
         promptForm.B_Close.Click += (S, t) => { promptForm.inputboxName.Text = DefValues.Key; promptForm.inputBoxYear.Text = DefValues.Value.ToString(); promptForm.Close(); };
         promptForm.Refresh();
         promptForm.ShowDialog();
         return new KeyValuePair<string, int>(promptForm.inputboxName.Text, promptForm.inputBoxYear.Text.SmartParse());
      }
   }
}
