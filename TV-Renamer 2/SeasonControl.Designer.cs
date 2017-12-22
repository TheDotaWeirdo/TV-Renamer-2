namespace TV_Renamer_2
{
   partial class SeasonControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeasonControl));
         this.P_Season = new System.Windows.Forms.Panel();
         this.L_SeasonName = new System.Windows.Forms.Label();
         this.P_Episodes = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.PB_Eps = new System.Windows.Forms.PictureBox();
         this.PB_Edit = new System.Windows.Forms.PictureBox();
         this.PB_Del = new System.Windows.Forms.PictureBox();
         this.PB_Icon = new System.Windows.Forms.PictureBox();
         this.P_Season.SuspendLayout();
         this.P_Episodes.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Eps)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         this.SuspendLayout();
         // 
         // P_Season
         // 
         this.P_Season.Controls.Add(this.PB_Eps);
         this.P_Season.Controls.Add(this.PB_Edit);
         this.P_Season.Controls.Add(this.PB_Del);
         this.P_Season.Controls.Add(this.PB_Icon);
         this.P_Season.Controls.Add(this.L_SeasonName);
         this.P_Season.Dock = System.Windows.Forms.DockStyle.Top;
         this.P_Season.Location = new System.Drawing.Point(0, 0);
         this.P_Season.Name = "P_Season";
         this.P_Season.Size = new System.Drawing.Size(934, 55);
         this.P_Season.TabIndex = 0;
         // 
         // L_SeasonName
         // 
         this.L_SeasonName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
         this.L_SeasonName.Location = new System.Drawing.Point(80, 0);
         this.L_SeasonName.Name = "L_SeasonName";
         this.L_SeasonName.Size = new System.Drawing.Size(2000, 55);
         this.L_SeasonName.TabIndex = 1;
         this.L_SeasonName.Text = "Season";
         this.L_SeasonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.L_SeasonName.Click += new System.EventHandler(this.PB_Icon_Click);
         // 
         // P_Episodes
         // 
         this.P_Episodes.Controls.Add(this.panel1);
         this.P_Episodes.Dock = System.Windows.Forms.DockStyle.Fill;
         this.P_Episodes.Location = new System.Drawing.Point(0, 55);
         this.P_Episodes.Name = "P_Episodes";
         this.P_Episodes.Size = new System.Drawing.Size(934, 5);
         this.P_Episodes.TabIndex = 1;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(934, 5);
         this.panel1.TabIndex = 0;
         // 
         // PB_Eps
         // 
         this.PB_Eps.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Eps.Image = global::TV_Renamer_2.Properties.Resources.Icon_TV;
         this.PB_Eps.Location = new System.Drawing.Point(784, 0);
         this.PB_Eps.Name = "PB_Eps";
         this.PB_Eps.Size = new System.Drawing.Size(50, 55);
         this.PB_Eps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Eps.TabIndex = 12;
         this.PB_Eps.TabStop = false;
         this.PB_Eps.Click += new System.EventHandler(this.PB_Icon_Click);
         this.PB_Eps.MouseEnter += new System.EventHandler(this.PB_Eps_MouseEnter);
         this.PB_Eps.MouseLeave += new System.EventHandler(this.PB_Eps_MouseLeave);
         // 
         // PB_Edit
         // 
         this.PB_Edit.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("PB_Edit.Image")));
         this.PB_Edit.Location = new System.Drawing.Point(834, 0);
         this.PB_Edit.Name = "PB_Edit";
         this.PB_Edit.Size = new System.Drawing.Size(50, 55);
         this.PB_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Edit.TabIndex = 11;
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
         this.PB_Del.TabIndex = 10;
         this.PB_Del.TabStop = false;
         this.PB_Del.Click += new System.EventHandler(this.PB_Del_Click);
         this.PB_Del.MouseEnter += new System.EventHandler(this.PB_Del_MouseEnter);
         this.PB_Del.MouseLeave += new System.EventHandler(this.PB_Del_MouseLeave);
         // 
         // PB_Icon
         // 
         this.PB_Icon.Dock = System.Windows.Forms.DockStyle.Left;
         this.PB_Icon.Image = global::TV_Renamer_2.Properties.Resources.Icon_Season;
         this.PB_Icon.Location = new System.Drawing.Point(0, 0);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(80, 55);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Icon.TabIndex = 0;
         this.PB_Icon.TabStop = false;
         this.PB_Icon.Click += new System.EventHandler(this.PB_Icon_Click);
         // 
         // SeasonControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.Controls.Add(this.P_Episodes);
         this.Controls.Add(this.P_Season);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "SeasonControl";
         this.Size = new System.Drawing.Size(934, 60);
         this.P_Season.ResumeLayout(false);
         this.P_Episodes.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Eps)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel P_Season;
      private System.Windows.Forms.PictureBox PB_Icon;
      private System.Windows.Forms.Label L_SeasonName;
      private System.Windows.Forms.Panel P_Episodes;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.PictureBox PB_Eps;
      private System.Windows.Forms.PictureBox PB_Edit;
      private System.Windows.Forms.PictureBox PB_Del;
   }
}
