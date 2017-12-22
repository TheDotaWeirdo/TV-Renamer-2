using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public partial class ReviewSubForm : UserControl
   {
      public ReviewSubForm()
      {
         InitializeComponent();
      }

      public void ReviewSubForm_Resize(object sender, EventArgs e)
      {
         CB_CleanFolders.Size = CB_ReOrderFolders.Size = new Size(P_Buttons.Width / 4, P_Buttons.Height);
         CB_CleanFolders.Location = new Point(P_Buttons.Width / 2, 0);
         CB_ReOrderFolders.Location = new Point(P_Buttons.Width / 4, 0);
         B_Back.Location = new Point((P_Buttons.Width / 4 - B_Back.Width) / 2, (P_Buttons.Height - B_Back.Height) / 2);
         B_Rename.Location = new Point(CB_CleanFolders.Width * 3 + (P_Buttons.Width / 4 - B_Back.Width) / 2, (P_Buttons.Height - B_Back.Height) / 2);
      }

      private void B_Back_Click(object sender, EventArgs e)
      {
         Form1.mainSubForm.Show();
         Hide();
      }

      private void CB_ReOrderFolders_CheckChanged(object sender, EventArgs e)
      {
         Form1.mainSubForm.CB_ReOrderFolders.Checked = CB_ReOrderFolders.Checked;
      }

      private void CB_CleanFolders_CheckChanged(object sender, EventArgs e)
      {
         Form1.mainSubForm.CB_CleanFolders.Checked = CB_CleanFolders.Checked;
      }

      private void B_Rename_Click(object sender, EventArgs e)
      {
         Form1.renameSubForm.Prepare();
         Form1.renameSubForm.Show();
         Hide();
         Form1.renameSubForm.Start();
      }

      internal void ToggleDesignMode()
      {
         BackColor = Design.BackColor;
         ForeColor = CB_CleanFolders.ForeColor = CB_ReOrderFolders.ForeColor = Design.ForeColor;
         panel1.BackColor = Design.DarkColor;
         CB_ReOrderFolders.Refresh();
         CB_CleanFolders.Refresh();
         foreach (var Season in Seasons)
         {
            Season.Control?.Refresh();
            foreach (var Episode in Season.Episodes)
            {
               Episode.Control?.Refresh();
               foreach (var Sub in Episode.Subs)
                  Sub.Control?.Refresh();
            }
         }

         foreach (var Movie in Movies)
         {
            Movie.Control?.Refresh();
            foreach (var Sub in Movie.Subs)
               Sub.Control?.Refresh();
         }
      }
   }
}
