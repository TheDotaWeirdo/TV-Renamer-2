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
   public partial class PromptForm : Form
   {
      public PromptForm(string Title, string Message, string Def)
      {
         InitializeComponent();
         L_Title.Text = Title;
         L_Message.Text = Message;
         inputBox.Text = Def;
      }

      public const int WM_NCLBUTTONDOWN = 0xA1;
      public const int HT_CAPTION = 0x2;

      [System.Runtime.InteropServices.DllImport("user32.dll")]
      public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
      [System.Runtime.InteropServices.DllImport("user32.dll")]
      public static extern bool ReleaseCapture();

      private void Form_MouseDown(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Left)
         {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
         }
      }

      public override void Refresh()
      {
         P_Main.BackColor = inputBox.BackColor = Design.BackColor;
         ForeColor = inputBox.ForeColor = Design.ForeColor;
         L_Message.ForeColor = Design.TitleForeColor;
         B_Done.Refresh();
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Enter) Close();
         return base.ProcessCmdKey(ref msg, keyData);
      }

      private static string[] CharBlackList =
      {
         "\\", "/", ":", "?", "\"", "<", ">", "|"
      };
      
      private void inputBox_TextChanged(object sender, EventArgs e)
      {
         if (inputBox.Text.Any(x => CharBlackList.Contains(x.ToString())))
            inputBox.Text = inputBox.Text.Where(x => !CharBlackList.Contains(x.ToString()));
      }
   }   
}
