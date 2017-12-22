namespace TV_Renamer_2
{
   partial class MovieControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieControl));
         this.P_Mov = new System.Windows.Forms.Panel();
         this.L_MovieName = new System.Windows.Forms.Label();
         this.P_Subs = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.PB_Icon = new System.Windows.Forms.PictureBox();
         this.PB_Subs = new System.Windows.Forms.PictureBox();
         this.PB_Edit = new System.Windows.Forms.PictureBox();
         this.PB_Del = new System.Windows.Forms.PictureBox();
         this.P_Mov.SuspendLayout();
         this.P_Subs.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Subs)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).BeginInit();
         this.SuspendLayout();
         // 
         // P_Mov
         // 
         this.P_Mov.Controls.Add(this.PB_Icon);
         this.P_Mov.Controls.Add(this.PB_Subs);
         this.P_Mov.Controls.Add(this.PB_Edit);
         this.P_Mov.Controls.Add(this.PB_Del);
         this.P_Mov.Controls.Add(this.L_MovieName);
         this.P_Mov.Dock = System.Windows.Forms.DockStyle.Top;
         this.P_Mov.Location = new System.Drawing.Point(0, 0);
         this.P_Mov.Name = "P_Mov";
         this.P_Mov.Size = new System.Drawing.Size(934, 55);
         this.P_Mov.TabIndex = 1;
         // 
         // L_MovieName
         // 
         this.L_MovieName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
         this.L_MovieName.Location = new System.Drawing.Point(70, 0);
         this.L_MovieName.Name = "L_MovieName";
         this.L_MovieName.Size = new System.Drawing.Size(2000, 55);
         this.L_MovieName.TabIndex = 5;
         this.L_MovieName.Text = "Movie";
         this.L_MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.L_MovieName.Click += new System.EventHandler(this.PB_Icon_Click);
         // 
         // P_Subs
         // 
         this.P_Subs.Controls.Add(this.panel1);
         this.P_Subs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.P_Subs.Location = new System.Drawing.Point(0, 55);
         this.P_Subs.Name = "P_Subs";
         this.P_Subs.Size = new System.Drawing.Size(934, 5);
         this.P_Subs.TabIndex = 3;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(934, 5);
         this.panel1.TabIndex = 1;
         // 
         // PB_Icon
         // 
         this.PB_Icon.Dock = System.Windows.Forms.DockStyle.Left;
         this.PB_Icon.Image = global::TV_Renamer_2.Properties.Resources.Icon_Movie;
         this.PB_Icon.Location = new System.Drawing.Point(0, 0);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(70, 55);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Icon.TabIndex = 11;
         this.PB_Icon.TabStop = false;
         this.PB_Icon.Click += new System.EventHandler(this.PB_Icon_Click);
         // 
         // PB_Subs
         // 
         this.PB_Subs.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Subs.Image = global::TV_Renamer_2.Properties.Resources.Icon_Sub_D;
         this.PB_Subs.Location = new System.Drawing.Point(784, 0);
         this.PB_Subs.Name = "PB_Subs";
         this.PB_Subs.Size = new System.Drawing.Size(50, 55);
         this.PB_Subs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Subs.TabIndex = 9;
         this.PB_Subs.TabStop = false;
         this.PB_Subs.Click += new System.EventHandler(this.PB_Icon_Click);
         this.PB_Subs.MouseEnter += new System.EventHandler(this.PB_Subs_MouseEnter);
         this.PB_Subs.MouseLeave += new System.EventHandler(this.PB_Subs_MouseLeave);
         // 
         // PB_Edit
         // 
         this.PB_Edit.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("PB_Edit.Image")));
         this.PB_Edit.Location = new System.Drawing.Point(834, 0);
         this.PB_Edit.Name = "PB_Edit";
         this.PB_Edit.Size = new System.Drawing.Size(50, 55);
         this.PB_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Edit.TabIndex = 7;
         this.PB_Edit.TabStop = false;
         this.PB_Edit.Click += new System.EventHandler(this.PB_Edit_Click);
         this.PB_Edit.MouseEnter += new System.EventHandler(this.PB_Edit_MouseEnter);
         this.PB_Edit.MouseLeave += new System.EventHandler(this.PB_Edit_MouseLeave);
         // 
         // PB_Del
         // 
         this.PB_Del.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Del.Image = global::TV_Renamer_2.Properties.Resources.Icon_Stop;
         this.PB_Del.Location = new System.Drawing.Point(884, 0);
         this.PB_Del.Name = "PB_Del";
         this.PB_Del.Size = new System.Drawing.Size(50, 55);
         this.PB_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Del.TabIndex = 6;
         this.PB_Del.TabStop = false;
         this.PB_Del.Click += new System.EventHandler(this.PB_Del_Click);
         this.PB_Del.MouseEnter += new System.EventHandler(this.PB_Del_MouseEnter);
         this.PB_Del.MouseLeave += new System.EventHandler(this.PB_Del_MouseLeave);
         // 
         // MovieControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.Controls.Add(this.P_Subs);
         this.Controls.Add(this.P_Mov);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "MovieControl";
         this.Size = new System.Drawing.Size(934, 60);
         this.P_Mov.ResumeLayout(false);
         this.P_Subs.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Subs)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel P_Mov;
      private System.Windows.Forms.Label L_MovieName;
      private System.Windows.Forms.PictureBox PB_Edit;
      private System.Windows.Forms.PictureBox PB_Del;
      private System.Windows.Forms.PictureBox PB_Icon;
      private System.Windows.Forms.Panel P_Subs;
      private System.Windows.Forms.Panel panel1;
      public System.Windows.Forms.PictureBox PB_Subs;
   }
}
