namespace TV_Renamer_2
{
   partial class SubtitleControl
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtitleControl));
         this.P_Ep = new System.Windows.Forms.Panel();
         this.PB_Edit = new System.Windows.Forms.PictureBox();
         this.PB_Icon = new System.Windows.Forms.PictureBox();
         this.P_MarginLeft = new System.Windows.Forms.Panel();
         this.PB_Del = new System.Windows.Forms.PictureBox();
         this.L_SubName = new System.Windows.Forms.Label();
         this.P_Ep.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).BeginInit();
         this.SuspendLayout();
         // 
         // P_Ep
         // 
         this.P_Ep.Controls.Add(this.PB_Edit);
         this.P_Ep.Controls.Add(this.PB_Icon);
         this.P_Ep.Controls.Add(this.P_MarginLeft);
         this.P_Ep.Controls.Add(this.PB_Del);
         this.P_Ep.Controls.Add(this.L_SubName);
         this.P_Ep.Dock = System.Windows.Forms.DockStyle.Top;
         this.P_Ep.Location = new System.Drawing.Point(0, 0);
         this.P_Ep.Name = "P_Ep";
         this.P_Ep.Size = new System.Drawing.Size(934, 50);
         this.P_Ep.TabIndex = 1;
         // 
         // PB_Edit
         // 
         this.PB_Edit.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Edit.Image = ((System.Drawing.Image)(resources.GetObject("PB_Edit.Image")));
         this.PB_Edit.Location = new System.Drawing.Point(834, 0);
         this.PB_Edit.Name = "PB_Edit";
         this.PB_Edit.Size = new System.Drawing.Size(50, 50);
         this.PB_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Edit.TabIndex = 12;
         this.PB_Edit.TabStop = false;
         this.PB_Edit.Click += new System.EventHandler(this.PB_Edit_Click);
         this.PB_Edit.MouseEnter += new System.EventHandler(this.PB_Edit_MouseEnter);
         this.PB_Edit.MouseLeave += new System.EventHandler(this.PB_Edit_MouseLeave);
         // 
         // PB_Icon
         // 
         this.PB_Icon.Dock = System.Windows.Forms.DockStyle.Left;
         this.PB_Icon.Image = global::TV_Renamer_2.Properties.Resources.Icon_Sub;
         this.PB_Icon.Location = new System.Drawing.Point(100, 0);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(50, 50);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Icon.TabIndex = 11;
         this.PB_Icon.TabStop = false;
         // 
         // P_MarginLeft
         // 
         this.P_MarginLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.P_MarginLeft.Location = new System.Drawing.Point(0, 0);
         this.P_MarginLeft.Name = "P_MarginLeft";
         this.P_MarginLeft.Size = new System.Drawing.Size(100, 50);
         this.P_MarginLeft.TabIndex = 8;
         // 
         // PB_Del
         // 
         this.PB_Del.Dock = System.Windows.Forms.DockStyle.Right;
         this.PB_Del.Image = global::TV_Renamer_2.Properties.Resources.Icon_Stop;
         this.PB_Del.Location = new System.Drawing.Point(884, 0);
         this.PB_Del.Name = "PB_Del";
         this.PB_Del.Size = new System.Drawing.Size(50, 50);
         this.PB_Del.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.PB_Del.TabIndex = 6;
         this.PB_Del.TabStop = false;
         this.PB_Del.Click += new System.EventHandler(this.PB_Del_Click);
         this.PB_Del.MouseEnter += new System.EventHandler(this.PB_Del_MouseEnter);
         this.PB_Del.MouseLeave += new System.EventHandler(this.PB_Del_MouseLeave);
         // 
         // L_SubName
         // 
         this.L_SubName.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
         this.L_SubName.Location = new System.Drawing.Point(150, 0);
         this.L_SubName.Name = "L_SubName";
         this.L_SubName.Size = new System.Drawing.Size(2000, 50);
         this.L_SubName.TabIndex = 5;
         this.L_SubName.Text = "Subtitle";
         this.L_SubName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // SubtitleControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.Controls.Add(this.P_Ep);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "SubtitleControl";
         this.Size = new System.Drawing.Size(934, 50);
         this.P_Ep.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Edit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Del)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel P_Ep;
      private System.Windows.Forms.Label L_SubName;
      private System.Windows.Forms.Panel P_MarginLeft;
      private System.Windows.Forms.PictureBox PB_Del;
      private System.Windows.Forms.PictureBox PB_Icon;
      private System.Windows.Forms.PictureBox PB_Edit;
   }
}
