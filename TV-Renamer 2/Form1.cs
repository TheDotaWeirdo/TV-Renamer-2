using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TV_Renamer_2.MainForm.Data;

namespace TV_Renamer_2
{
   public partial class MainForm : Form
   {
      private System.Timers.Timer ErrorTimer= new System.Timers.Timer(6000) { AutoReset = false };

      public MainForm() => InitializeComponent();

      private void Form1_Resize(object sender, EventArgs e)
      {
         P_Main.Size = new Size(Width - 6, Height - 6);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         Form1 = this;
         mainSubForm.MainSubForm_Resize(this, e);
         reviewSubForm.ReviewSubForm_Resize(this, e);
         renameSubForm.RenameSubForm_Resize(this, e);
         mainSubForm.L_Version.Text = reviewSubForm.L_Version.Text = 
            renameSubForm.L_Version.Text = $"v {Data.Version.ToString()}";
         ErrorTimer.Elapsed += (s, t) => ClearError();
         if(File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "DesignMode.dll")))
            if(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "DesignMode.dll")) == "Light")
               ToggleDesignMode(null,null);
      }

      private void B_Close_Click(object sender, EventArgs e) => Close();

      private void B_Restore_Click(object sender, EventArgs e) => WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;

      private void B_Minimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

      private void MainForm_Activated(object sender, EventArgs e)
      {
         FormIsActive = true;
         if (CurrentFormState == FormState.N_Unfocused)
            CurrentFormState = FormState.N_Focused;
      }

      private void MainForm_Deactivate(object sender, EventArgs e)
      {
         FormIsActive = false;
         if(CurrentFormState == FormState.N_Focused)
            CurrentFormState = FormState.N_Unfocused;
      }

      public void ShowError(string Msg)
      {
         Invoke(new Action(() =>
         {
            L_Title.Text = Msg;
            L_Title.ForeColor = Color.FromArgb(242, 60, 53);
            L_Title.Font = new Font("Century Gothic", 16f);
            ErrorTimer.Stop();
            ErrorTimer.Start();
         }));
      }

      public void ClearError()
      {
         Invoke(new Action(() =>
         {
            L_Title.Text = TitleName;
            L_Title.Font = new Font("Century Gothic", 21.75f, FontStyle.Bold);
            L_Title.ForeColor = Design.TitleForeColor;
         }));
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

      protected override void WndProc(ref Message m)
      {
         const int RESIZE_HANDLE_SIZE = 10;

         switch (m.Msg)
         {
            case 0x0084/*NCHITTEST*/ :
               base.WndProc(ref m);

               if ((int)m.Result == 0x01/*HTCLIENT*/)
               {
                  Point screenPoint = new Point(m.LParam.ToInt32());
                  Point clientPoint = this.PointToClient(screenPoint);
                  if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                  {
                     if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                     else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                        m.Result = (IntPtr)12/*HTTOP*/ ;
                     else
                        m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                  }
                  else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                  {
                     if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)10/*HTLEFT*/ ;
                     else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                        m.Result = (IntPtr)2/*HTCAPTION*/ ;
                     else
                        m.Result = (IntPtr)11/*HTRIGHT*/ ;
                  }
                  else
                  {
                     if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                     else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                        m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                     else
                        m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                  }
               }
               return;
         }
         base.WndProc(ref m);
      }

      protected override CreateParams CreateParams
      {
         get
         {
            CreateParams cp = base.CreateParams;
            cp.Style |= 0x20000; // <--- use 0x20000
            return cp;
         }
      }

      private void ToggleDesignMode(object sender, EventArgs e)
      {
         Design = Design == FormDesign.Dark ? FormDesign.Light : FormDesign.Dark;

         P_Top.BackColor = Design.TitleColor;
         ForeColor = Design.ForeColor;
         L_Title.ForeColor = Design.TitleForeColor;
         PB_Icon.Image = Design == FormDesign.Dark ? Properties.Resources.Icon_W : Properties.Resources.Icon_B;


         mainSubForm.ToggleDesignMode();
         reviewSubForm.ToggleDesignMode();
         renameSubForm.ToggleDesignMode();

         if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer")))
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer"));
         File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TV Renamer", "DesignMode.dll"), Design == FormDesign.Dark ? "Dark" : "Light");
      }
   }
}
