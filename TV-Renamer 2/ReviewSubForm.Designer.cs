namespace TV_Renamer_2
{
   partial class ReviewSubForm
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
         this.P_Margin_Right = new System.Windows.Forms.Panel();
         this.P_Margin_Left = new System.Windows.Forms.Panel();
         this.L_Version = new System.Windows.Forms.Label();
         this.P_Main = new System.Windows.Forms.Panel();
         this.P_Buttons = new System.Windows.Forms.Panel();
         this.CB_ReOrderFolders = new TV_Renamer_2.MyCheckBox();
         this.CB_CleanFolders = new TV_Renamer_2.MyCheckBox();
         this.B_Rename = new TV_Renamer_2.MyButton();
         this.B_Back = new TV_Renamer_2.MyButton();
         this.panel1 = new System.Windows.Forms.Panel();
         this.P_Buttons.SuspendLayout();
         this.SuspendLayout();
         // 
         // P_Margin_Right
         // 
         this.P_Margin_Right.Dock = System.Windows.Forms.DockStyle.Right;
         this.P_Margin_Right.Location = new System.Drawing.Point(964, 0);
         this.P_Margin_Right.Name = "P_Margin_Right";
         this.P_Margin_Right.Size = new System.Drawing.Size(30, 528);
         this.P_Margin_Right.TabIndex = 12;
         // 
         // P_Margin_Left
         // 
         this.P_Margin_Left.Dock = System.Windows.Forms.DockStyle.Left;
         this.P_Margin_Left.Location = new System.Drawing.Point(0, 0);
         this.P_Margin_Left.Name = "P_Margin_Left";
         this.P_Margin_Left.Size = new System.Drawing.Size(30, 528);
         this.P_Margin_Left.TabIndex = 11;
         // 
         // L_Version
         // 
         this.L_Version.AutoSize = true;
         this.L_Version.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.L_Version.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Version.Location = new System.Drawing.Point(0, 528);
         this.L_Version.Name = "L_Version";
         this.L_Version.Size = new System.Drawing.Size(41, 16);
         this.L_Version.TabIndex = 13;
         this.L_Version.Text = "v. 2.0";
         // 
         // P_Main
         // 
         this.P_Main.AutoScroll = true;
         this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
         this.P_Main.Location = new System.Drawing.Point(30, 80);
         this.P_Main.Name = "P_Main";
         this.P_Main.Size = new System.Drawing.Size(934, 448);
         this.P_Main.TabIndex = 15;
         // 
         // P_Buttons
         // 
         this.P_Buttons.Controls.Add(this.CB_ReOrderFolders);
         this.P_Buttons.Controls.Add(this.CB_CleanFolders);
         this.P_Buttons.Controls.Add(this.B_Rename);
         this.P_Buttons.Controls.Add(this.B_Back);
         this.P_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
         this.P_Buttons.Location = new System.Drawing.Point(30, 0);
         this.P_Buttons.Name = "P_Buttons";
         this.P_Buttons.Size = new System.Drawing.Size(934, 75);
         this.P_Buttons.TabIndex = 17;
         // 
         // CB_ReOrderFolders
         // 
         this.CB_ReOrderFolders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.CB_ReOrderFolders.BackColor = System.Drawing.Color.Transparent;
         this.CB_ReOrderFolders.Checked = false;
         this.CB_ReOrderFolders.Font = new System.Drawing.Font("Century Gothic", 11.75F);
         this.CB_ReOrderFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.CB_ReOrderFolders.IconSize = 28;
         this.CB_ReOrderFolders.Location = new System.Drawing.Point(245, 14);
         this.CB_ReOrderFolders.Name = "CB_ReOrderFolders";
         this.CB_ReOrderFolders.Size = new System.Drawing.Size(228, 49);
         this.CB_ReOrderFolders.TabIndex = 18;
         this.CB_ReOrderFolders.Text = "Re-Order Folders";
         this.CB_ReOrderFolders.CheckChanged += new System.EventHandler(this.CB_ReOrderFolders_CheckChanged);
         // 
         // CB_CleanFolders
         // 
         this.CB_CleanFolders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.CB_CleanFolders.BackColor = System.Drawing.Color.Transparent;
         this.CB_CleanFolders.Checked = false;
         this.CB_CleanFolders.Font = new System.Drawing.Font("Century Gothic", 11.75F);
         this.CB_CleanFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.CB_CleanFolders.IconSize = 28;
         this.CB_CleanFolders.Location = new System.Drawing.Point(479, 14);
         this.CB_CleanFolders.Name = "CB_CleanFolders";
         this.CB_CleanFolders.Size = new System.Drawing.Size(207, 49);
         this.CB_CleanFolders.TabIndex = 19;
         this.CB_CleanFolders.Text = "Clean Folders";
         this.CB_CleanFolders.CheckChanged += new System.EventHandler(this.CB_CleanFolders_CheckChanged);
         // 
         // B_Rename
         // 
         this.B_Rename.ActiveImage = global::TV_Renamer_2.Properties.Resources.Icon_Next_A;
         this.B_Rename.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.B_Rename.BackColor = System.Drawing.Color.Transparent;
         this.B_Rename.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.B_Rename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.B_Rename.Image = global::TV_Renamer_2.Properties.Resources.Icon_Next;
         this.B_Rename.Location = new System.Drawing.Point(729, 14);
         this.B_Rename.Name = "B_Rename";
         this.B_Rename.Size = new System.Drawing.Size(180, 45);
         this.B_Rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.B_Rename.TabIndex = 17;
         this.B_Rename.Text = "Re-Name";
         this.B_Rename.Click += new System.EventHandler(this.B_Rename_Click);
         // 
         // B_Back
         // 
         this.B_Back.ActiveImage = global::TV_Renamer_2.Properties.Resources.Icon_Back_A;
         this.B_Back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.B_Back.BackColor = System.Drawing.Color.Transparent;
         this.B_Back.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.B_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.B_Back.Image = global::TV_Renamer_2.Properties.Resources.Icon_Back;
         this.B_Back.Location = new System.Drawing.Point(23, 14);
         this.B_Back.Name = "B_Back";
         this.B_Back.Size = new System.Drawing.Size(180, 45);
         this.B_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.B_Back.TabIndex = 16;
         this.B_Back.Text = "Back";
         this.B_Back.Click += new System.EventHandler(this.B_Back_Click);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(30, 75);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(934, 5);
         this.panel1.TabIndex = 18;
         // 
         // ReviewSubForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.Controls.Add(this.P_Main);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.P_Buttons);
         this.Controls.Add(this.P_Margin_Left);
         this.Controls.Add(this.P_Margin_Right);
         this.Controls.Add(this.L_Version);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "ReviewSubForm";
         this.Size = new System.Drawing.Size(994, 544);
         this.Resize += new System.EventHandler(this.ReviewSubForm_Resize);
         this.P_Buttons.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel P_Margin_Right;
      private System.Windows.Forms.Panel P_Margin_Left;
      public System.Windows.Forms.Label L_Version;
      private MyButton B_Back;
      private MyButton B_Rename;
      public MyCheckBox CB_ReOrderFolders;
      public MyCheckBox CB_CleanFolders;
      public System.Windows.Forms.Panel P_Buttons;
      private System.Windows.Forms.Panel panel1;
      public System.Windows.Forms.Panel P_Main;
   }
}
