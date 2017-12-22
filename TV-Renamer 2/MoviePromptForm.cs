using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public partial class MoviePromptForm : Form
   {
      public MoviePromptForm(string Title, string Message, KeyValuePair<string, int> Def)
      {
         InitializeComponent();
         L_Title.Text = Title;
         L_Message.Text = Message;
         inputboxName.Text = Def.Key;
         inputBoxYear.Text = Def.Value.ToString();
      }

      public const int WM_NCLBUTTONDOWN = 0xA1;
      public const int HT_CAPTION = 0x2;

      [System.Runtime.InteropServices.DllImport("user32.dll")]
      public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
      [System.Runtime.InteropServices.DllImport("user32.dll")]
      public static extern bool ReleaseCapture();

      public override void Refresh()
      {
         P_Main.BackColor = inputboxName.BackColor = inputBoxYear.BackColor = Design.BackColor;
         ForeColor = inputboxName.ForeColor = inputBoxYear.ForeColor = Design.ForeColor;
         L_Message.ForeColor = Design.TitleForeColor;
         B_Done.Refresh();
      }

      private void Form_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
         {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
         }
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if(keyData == Keys.Enter) Close();
         return base.ProcessCmdKey(ref msg, keyData);
      }

      private static string[] CharBlackList =
      {
         "\\", "/", ":", "?", "\"", "<", ">", "|"
      };

      private void inputboxName_TextChanged(object sender, EventArgs e)
      {
         if (inputboxName.Text.Any(x => CharBlackList.Contains(x.ToString())))
            inputboxName.Text = inputboxName.Text.Where(x => !CharBlackList.Contains(x.ToString()));
      }
   }
}
