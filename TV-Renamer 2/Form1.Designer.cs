namespace TV_Renamer_2
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.P_Main = new System.Windows.Forms.Panel();
         this.mainSubForm = new TV_Renamer_2.MainSubForm();
         this.renameSubForm = new TV_Renamer_2.RenameSubForm();
         this.reviewSubForm = new TV_Renamer_2.ReviewSubForm();
         this.P_Top = new System.Windows.Forms.Panel();
         this.L_Title = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.PB_Icon = new System.Windows.Forms.PictureBox();
         this.panel17 = new System.Windows.Forms.Panel();
         this.B_Minimize = new System.Windows.Forms.PictureBox();
         this.B_Restore = new System.Windows.Forms.PictureBox();
         this.B_Close = new System.Windows.Forms.PictureBox();
         this.P_Main.SuspendLayout();
         this.P_Top.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         this.panel17.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.B_Minimize)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.B_Restore)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.B_Close)).BeginInit();
         this.SuspendLayout();
         // 
         // P_Main
         // 
         this.P_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.P_Main.Controls.Add(this.mainSubForm);
         this.P_Main.Controls.Add(this.renameSubForm);
         this.P_Main.Controls.Add(this.reviewSubForm);
         this.P_Main.Controls.Add(this.P_Top);
         this.P_Main.Location = new System.Drawing.Point(3, 3);
         this.P_Main.Name = "P_Main";
         this.P_Main.Size = new System.Drawing.Size(994, 644);
         this.P_Main.TabIndex = 0;
         // 
         // mainSubForm
         // 
         this.mainSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.mainSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainSubForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.mainSubForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.mainSubForm.Location = new System.Drawing.Point(0, 100);
         this.mainSubForm.Margin = new System.Windows.Forms.Padding(5);
         this.mainSubForm.Name = "mainSubForm";
         this.mainSubForm.Size = new System.Drawing.Size(994, 544);
         this.mainSubForm.TabIndex = 19;
         // 
         // renameSubForm
         // 
         this.renameSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.renameSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
         this.renameSubForm.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.renameSubForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.renameSubForm.Location = new System.Drawing.Point(0, 100);
         this.renameSubForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.renameSubForm.Name = "renameSubForm";
         this.renameSubForm.Size = new System.Drawing.Size(994, 544);
         this.renameSubForm.TabIndex = 21;
         this.renameSubForm.Visible = false;
         // 
         // reviewSubForm
         // 
         this.reviewSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.reviewSubForm.Dock = System.Windows.Forms.DockStyle.Fill;
         this.reviewSubForm.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.reviewSubForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.reviewSubForm.Location = new System.Drawing.Point(0, 100);
         this.reviewSubForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.reviewSubForm.Name = "reviewSubForm";
         this.reviewSubForm.Size = new System.Drawing.Size(994, 544);
         this.reviewSubForm.TabIndex = 20;
         this.reviewSubForm.Visible = false;
         // 
         // P_Top
         // 
         this.P_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.P_Top.Controls.Add(this.L_Title);
         this.P_Top.Controls.Add(this.panel2);
         this.P_Top.Controls.Add(this.panel17);
         this.P_Top.Dock = System.Windows.Forms.DockStyle.Top;
         this.P_Top.Location = new System.Drawing.Point(0, 0);
         this.P_Top.Name = "P_Top";
         this.P_Top.Size = new System.Drawing.Size(994, 100);
         this.P_Top.TabIndex = 18;
         // 
         // L_Title
         // 
         this.L_Title.Dock = System.Windows.Forms.DockStyle.Fill;
         this.L_Title.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Title.Location = new System.Drawing.Point(94, 0);
         this.L_Title.Name = "L_Title";
         this.L_Title.Size = new System.Drawing.Size(806, 100);
         this.L_Title.TabIndex = 6;
         this.L_Title.Text = "TV Series Re-Namer v2";
         this.L_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.L_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.PB_Icon);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(94, 100);
         this.panel2.TabIndex = 9;
         this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
         // 
         // PB_Icon
         // 
         this.PB_Icon.Image = global::TV_Renamer_2.Properties.Resources.Icon_W;
         this.PB_Icon.Location = new System.Drawing.Point(3, 3);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(55, 41);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_Icon.TabIndex = 7;
         this.PB_Icon.TabStop = false;
         this.PB_Icon.Click += new System.EventHandler(this.ToggleDesignMode);
         // 
         // panel17
         // 
         this.panel17.AutoSize = true;
         this.panel17.Controls.Add(this.B_Minimize);
         this.panel17.Controls.Add(this.B_Restore);
         this.panel17.Controls.Add(this.B_Close);
         this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel17.Location = new System.Drawing.Point(900, 0);
         this.panel17.Name = "panel17";
         this.panel17.Size = new System.Drawing.Size(94, 100);
         this.panel17.TabIndex = 5;
         this.panel17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
         // 
         // B_Minimize
         // 
         this.B_Minimize.Image = global::TV_Renamer_2.Properties.Resources.B_Green;
         this.B_Minimize.Location = new System.Drawing.Point(4, 4);
         this.B_Minimize.Name = "B_Minimize";
         this.B_Minimize.Size = new System.Drawing.Size(25, 25);
         this.B_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.B_Minimize.TabIndex = 3;
         this.B_Minimize.TabStop = false;
         this.B_Minimize.Click += new System.EventHandler(this.B_Minimize_Click);
         // 
         // B_Restore
         // 
         this.B_Restore.Image = global::TV_Renamer_2.Properties.Resources.B_Yellow;
         this.B_Restore.Location = new System.Drawing.Point(35, 4);
         this.B_Restore.Name = "B_Restore";
         this.B_Restore.Size = new System.Drawing.Size(25, 25);
         this.B_Restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.B_Restore.TabIndex = 2;
         this.B_Restore.TabStop = false;
         this.B_Restore.Click += new System.EventHandler(this.B_Restore_Click);
         // 
         // B_Close
         // 
         this.B_Close.Image = global::TV_Renamer_2.Properties.Resources.B_Red;
         this.B_Close.Location = new System.Drawing.Point(66, 4);
         this.B_Close.Name = "B_Close";
         this.B_Close.Size = new System.Drawing.Size(25, 25);
         this.B_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.B_Close.TabIndex = 1;
         this.B_Close.TabStop = false;
         this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.ClientSize = new System.Drawing.Size(1000, 650);
         this.Controls.Add(this.P_Main);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MinimumSize = new System.Drawing.Size(1000, 650);
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "TV Series Re-Namer";
         this.Activated += new System.EventHandler(this.MainForm_Activated);
         this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.Resize += new System.EventHandler(this.Form1_Resize);
         this.P_Main.ResumeLayout(false);
         this.P_Top.ResumeLayout(false);
         this.P_Top.PerformLayout();
         this.panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         this.panel17.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.B_Minimize)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.B_Restore)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.B_Close)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel P_Main;
      private System.Windows.Forms.Panel P_Top;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.PictureBox PB_Icon;
      private System.Windows.Forms.Panel panel17;
      private System.Windows.Forms.PictureBox B_Minimize;
      private System.Windows.Forms.PictureBox B_Restore;
      private System.Windows.Forms.PictureBox B_Close;
      public MainSubForm mainSubForm;
      public ReviewSubForm reviewSubForm;
      public RenameSubForm renameSubForm;
      public System.Windows.Forms.Label L_Title;
   }
}

