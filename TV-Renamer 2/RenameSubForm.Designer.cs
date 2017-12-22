namespace TV_Renamer_2
{
   partial class RenameSubForm
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
         this.P_InfoTextContainer = new System.Windows.Forms.Panel();
         this.P_InfoText = new System.Windows.Forms.Panel();
         this.P_InfoRight = new System.Windows.Forms.Panel();
         this.L_Errors = new System.Windows.Forms.Label();
         this.L_Subs = new System.Windows.Forms.Label();
         this.L_Movies = new System.Windows.Forms.Label();
         this.L_Episodes = new System.Windows.Forms.Label();
         this.L_Seasons = new System.Windows.Forms.Label();
         this.L_CleanFolders = new System.Windows.Forms.Label();
         this.L_Reorder = new System.Windows.Forms.Label();
         this.L_Mode = new System.Windows.Forms.Label();
         this.P_InfoLeft = new System.Windows.Forms.Panel();
         this.label8 = new System.Windows.Forms.Label();
         this.labelSubs = new System.Windows.Forms.Label();
         this.labelMovie = new System.Windows.Forms.Label();
         this.labelEpisode = new System.Windows.Forms.Label();
         this.labelSeason = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.progressBar = new CircularProgressBar.CircularProgressBar();
         this.P_CurrentWork = new System.Windows.Forms.Panel();
         this.B_Done = new TV_Renamer_2.MyButton();
         this.L_CurrentWork = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.P_Main.SuspendLayout();
         this.P_InfoTextContainer.SuspendLayout();
         this.P_InfoText.SuspendLayout();
         this.P_InfoRight.SuspendLayout();
         this.P_InfoLeft.SuspendLayout();
         this.P_CurrentWork.SuspendLayout();
         this.SuspendLayout();
         // 
         // P_Margin_Right
         // 
         this.P_Margin_Right.Dock = System.Windows.Forms.DockStyle.Right;
         this.P_Margin_Right.Location = new System.Drawing.Point(964, 16);
         this.P_Margin_Right.Name = "P_Margin_Right";
         this.P_Margin_Right.Size = new System.Drawing.Size(30, 512);
         this.P_Margin_Right.TabIndex = 12;
         // 
         // P_Margin_Left
         // 
         this.P_Margin_Left.Dock = System.Windows.Forms.DockStyle.Left;
         this.P_Margin_Left.Location = new System.Drawing.Point(0, 16);
         this.P_Margin_Left.Name = "P_Margin_Left";
         this.P_Margin_Left.Size = new System.Drawing.Size(30, 512);
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
         this.P_Main.Controls.Add(this.P_InfoTextContainer);
         this.P_Main.Controls.Add(this.progressBar);
         this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
         this.P_Main.Location = new System.Drawing.Point(30, 16);
         this.P_Main.Name = "P_Main";
         this.P_Main.Size = new System.Drawing.Size(934, 432);
         this.P_Main.TabIndex = 15;
         // 
         // P_InfoTextContainer
         // 
         this.P_InfoTextContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
         this.P_InfoTextContainer.Controls.Add(this.P_InfoText);
         this.P_InfoTextContainer.Location = new System.Drawing.Point(47, 28);
         this.P_InfoTextContainer.Name = "P_InfoTextContainer";
         this.P_InfoTextContainer.Size = new System.Drawing.Size(420, 370);
         this.P_InfoTextContainer.TabIndex = 4;
         // 
         // P_InfoText
         // 
         this.P_InfoText.Controls.Add(this.P_InfoRight);
         this.P_InfoText.Controls.Add(this.P_InfoLeft);
         this.P_InfoText.Location = new System.Drawing.Point(12, 8);
         this.P_InfoText.Name = "P_InfoText";
         this.P_InfoText.Size = new System.Drawing.Size(400, 350);
         this.P_InfoText.TabIndex = 3;
         // 
         // P_InfoRight
         // 
         this.P_InfoRight.Controls.Add(this.L_Errors);
         this.P_InfoRight.Controls.Add(this.L_Subs);
         this.P_InfoRight.Controls.Add(this.L_Movies);
         this.P_InfoRight.Controls.Add(this.L_Episodes);
         this.P_InfoRight.Controls.Add(this.L_Seasons);
         this.P_InfoRight.Controls.Add(this.L_CleanFolders);
         this.P_InfoRight.Controls.Add(this.L_Reorder);
         this.P_InfoRight.Controls.Add(this.L_Mode);
         this.P_InfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
         this.P_InfoRight.Location = new System.Drawing.Point(200, 0);
         this.P_InfoRight.Name = "P_InfoRight";
         this.P_InfoRight.Size = new System.Drawing.Size(200, 350);
         this.P_InfoRight.TabIndex = 5;
         // 
         // L_Errors
         // 
         this.L_Errors.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Errors.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Errors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Errors.Location = new System.Drawing.Point(0, 245);
         this.L_Errors.Name = "L_Errors";
         this.L_Errors.Size = new System.Drawing.Size(200, 35);
         this.L_Errors.TabIndex = 2;
         this.L_Errors.Text = "(1) ";
         this.L_Errors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Subs
         // 
         this.L_Subs.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Subs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Subs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Subs.Location = new System.Drawing.Point(0, 210);
         this.L_Subs.Name = "L_Subs";
         this.L_Subs.Size = new System.Drawing.Size(200, 35);
         this.L_Subs.TabIndex = 9;
         this.L_Subs.Text = "0/0";
         this.L_Subs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Movies
         // 
         this.L_Movies.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Movies.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Movies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Movies.Location = new System.Drawing.Point(0, 175);
         this.L_Movies.Name = "L_Movies";
         this.L_Movies.Size = new System.Drawing.Size(200, 35);
         this.L_Movies.TabIndex = 8;
         this.L_Movies.Text = "0/0";
         this.L_Movies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Episodes
         // 
         this.L_Episodes.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Episodes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Episodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Episodes.Location = new System.Drawing.Point(0, 140);
         this.L_Episodes.Name = "L_Episodes";
         this.L_Episodes.Size = new System.Drawing.Size(200, 35);
         this.L_Episodes.TabIndex = 7;
         this.L_Episodes.Text = "0/0";
         this.L_Episodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Seasons
         // 
         this.L_Seasons.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Seasons.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Seasons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Seasons.Location = new System.Drawing.Point(0, 105);
         this.L_Seasons.Name = "L_Seasons";
         this.L_Seasons.Size = new System.Drawing.Size(200, 35);
         this.L_Seasons.TabIndex = 6;
         this.L_Seasons.Text = "0/0";
         this.L_Seasons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_CleanFolders
         // 
         this.L_CleanFolders.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_CleanFolders.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_CleanFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_CleanFolders.Location = new System.Drawing.Point(0, 70);
         this.L_CleanFolders.Name = "L_CleanFolders";
         this.L_CleanFolders.Size = new System.Drawing.Size(200, 35);
         this.L_CleanFolders.TabIndex = 4;
         this.L_CleanFolders.Text = "No";
         this.L_CleanFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Reorder
         // 
         this.L_Reorder.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Reorder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Reorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Reorder.Location = new System.Drawing.Point(0, 35);
         this.L_Reorder.Name = "L_Reorder";
         this.L_Reorder.Size = new System.Drawing.Size(200, 35);
         this.L_Reorder.TabIndex = 3;
         this.L_Reorder.Text = "No";
         this.L_Reorder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Mode
         // 
         this.L_Mode.Dock = System.Windows.Forms.DockStyle.Top;
         this.L_Mode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Mode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.L_Mode.Location = new System.Drawing.Point(0, 0);
         this.L_Mode.Name = "L_Mode";
         this.L_Mode.Size = new System.Drawing.Size(200, 35);
         this.L_Mode.TabIndex = 1;
         this.L_Mode.Text = "TV Series";
         this.L_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // P_InfoLeft
         // 
         this.P_InfoLeft.Controls.Add(this.label8);
         this.P_InfoLeft.Controls.Add(this.labelSubs);
         this.P_InfoLeft.Controls.Add(this.labelMovie);
         this.P_InfoLeft.Controls.Add(this.labelEpisode);
         this.P_InfoLeft.Controls.Add(this.labelSeason);
         this.P_InfoLeft.Controls.Add(this.label10);
         this.P_InfoLeft.Controls.Add(this.label9);
         this.P_InfoLeft.Controls.Add(this.label1);
         this.P_InfoLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.P_InfoLeft.Location = new System.Drawing.Point(0, 0);
         this.P_InfoLeft.Name = "P_InfoLeft";
         this.P_InfoLeft.Size = new System.Drawing.Size(200, 350);
         this.P_InfoLeft.TabIndex = 4;
         // 
         // label8
         // 
         this.label8.Dock = System.Windows.Forms.DockStyle.Top;
         this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(0, 245);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(200, 35);
         this.label8.TabIndex = 5;
         this.label8.Text = "Errors:";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelSubs
         // 
         this.labelSubs.Dock = System.Windows.Forms.DockStyle.Top;
         this.labelSubs.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelSubs.Location = new System.Drawing.Point(0, 210);
         this.labelSubs.Name = "labelSubs";
         this.labelSubs.Size = new System.Drawing.Size(200, 35);
         this.labelSubs.TabIndex = 4;
         this.labelSubs.Text = "Subtitles Done:";
         this.labelSubs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelMovie
         // 
         this.labelMovie.Dock = System.Windows.Forms.DockStyle.Top;
         this.labelMovie.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelMovie.Location = new System.Drawing.Point(0, 175);
         this.labelMovie.Name = "labelMovie";
         this.labelMovie.Size = new System.Drawing.Size(200, 35);
         this.labelMovie.TabIndex = 3;
         this.labelMovie.Text = "Movies Done:";
         this.labelMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelEpisode
         // 
         this.labelEpisode.Dock = System.Windows.Forms.DockStyle.Top;
         this.labelEpisode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelEpisode.Location = new System.Drawing.Point(0, 140);
         this.labelEpisode.Name = "labelEpisode";
         this.labelEpisode.Size = new System.Drawing.Size(200, 35);
         this.labelEpisode.TabIndex = 2;
         this.labelEpisode.Text = "Episodes Done:";
         this.labelEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelSeason
         // 
         this.labelSeason.Dock = System.Windows.Forms.DockStyle.Top;
         this.labelSeason.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelSeason.Location = new System.Drawing.Point(0, 105);
         this.labelSeason.Name = "labelSeason";
         this.labelSeason.Size = new System.Drawing.Size(200, 35);
         this.labelSeason.TabIndex = 1;
         this.labelSeason.Text = "Seasons Done:";
         this.labelSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label10
         // 
         this.label10.Dock = System.Windows.Forms.DockStyle.Top;
         this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label10.Location = new System.Drawing.Point(0, 70);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(200, 35);
         this.label10.TabIndex = 7;
         this.label10.Text = "Clean Folders:";
         this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label9
         // 
         this.label9.Dock = System.Windows.Forms.DockStyle.Top;
         this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(0, 35);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(200, 35);
         this.label9.TabIndex = 6;
         this.label9.Text = "Re-Order Folders:";
         this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Top;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(200, 35);
         this.label1.TabIndex = 0;
         this.label1.Text = "Mode:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // progressBar
         // 
         this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
         this.progressBar.AnimationSpeed = 550;
         this.progressBar.BackColor = System.Drawing.Color.Transparent;
         this.progressBar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
         this.progressBar.InnerMargin = -1;
         this.progressBar.InnerWidth = -1;
         this.progressBar.Location = new System.Drawing.Point(578, 106);
         this.progressBar.MarqueeAnimationSpeed = 0;
         this.progressBar.Maximum = 1000;
         this.progressBar.Name = "progressBar";
         this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
         this.progressBar.OuterMargin = -25;
         this.progressBar.OuterWidth = 25;
         this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(223)))), ((int)(((byte)(107)))));
         this.progressBar.ProgressWidth = 28;
         this.progressBar.SecondaryFont = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.progressBar.Size = new System.Drawing.Size(250, 250);
         this.progressBar.StartAngle = 270;
         this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
         this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(224)))));
         this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(15, -35, 0, 0);
         this.progressBar.SubscriptText = "";
         this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(150)))), ((int)(((byte)(169)))));
         this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(7, 34, 0, 0);
         this.progressBar.SuperscriptText = "%";
         this.progressBar.TabIndex = 2;
         this.progressBar.Text = "0";
         this.progressBar.TextMargin = new System.Windows.Forms.Padding(10, 3, 0, 0);
         this.progressBar.Value = 68;
         // 
         // P_CurrentWork
         // 
         this.P_CurrentWork.Controls.Add(this.B_Done);
         this.P_CurrentWork.Controls.Add(this.L_CurrentWork);
         this.P_CurrentWork.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.P_CurrentWork.Location = new System.Drawing.Point(30, 453);
         this.P_CurrentWork.Name = "P_CurrentWork";
         this.P_CurrentWork.Size = new System.Drawing.Size(934, 75);
         this.P_CurrentWork.TabIndex = 17;
         // 
         // B_Done
         // 
         this.B_Done.ActiveImage = global::TV_Renamer_2.Properties.Resources.Icon_Checkmark_A;
         this.B_Done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.B_Done.BackColor = System.Drawing.Color.Transparent;
         this.B_Done.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.B_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.B_Done.Image = global::TV_Renamer_2.Properties.Resources.Icon_Checkmark;
         this.B_Done.Location = new System.Drawing.Point(377, 15);
         this.B_Done.Name = "B_Done";
         this.B_Done.Size = new System.Drawing.Size(200, 50);
         this.B_Done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.B_Done.TabIndex = 18;
         this.B_Done.Text = "Done";
         this.B_Done.Visible = false;
         this.B_Done.Click += new System.EventHandler(this.B_Done_Click);
         // 
         // L_CurrentWork
         // 
         this.L_CurrentWork.Dock = System.Windows.Forms.DockStyle.Fill;
         this.L_CurrentWork.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_CurrentWork.Location = new System.Drawing.Point(0, 0);
         this.L_CurrentWork.Name = "L_CurrentWork";
         this.L_CurrentWork.Size = new System.Drawing.Size(934, 75);
         this.L_CurrentWork.TabIndex = 1;
         this.L_CurrentWork.Text = "Working...";
         this.L_CurrentWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(30, 448);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(934, 5);
         this.panel1.TabIndex = 18;
         // 
         // panel2
         // 
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(994, 16);
         this.panel2.TabIndex = 19;
         // 
         // RenameSubForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.Controls.Add(this.P_Main);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.P_CurrentWork);
         this.Controls.Add(this.P_Margin_Left);
         this.Controls.Add(this.P_Margin_Right);
         this.Controls.Add(this.L_Version);
         this.Controls.Add(this.panel2);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "RenameSubForm";
         this.Size = new System.Drawing.Size(994, 544);
         this.Resize += new System.EventHandler(this.RenameSubForm_Resize);
         this.P_Main.ResumeLayout(false);
         this.P_InfoTextContainer.ResumeLayout(false);
         this.P_InfoText.ResumeLayout(false);
         this.P_InfoRight.ResumeLayout(false);
         this.P_InfoLeft.ResumeLayout(false);
         this.P_CurrentWork.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel P_Margin_Right;
      private System.Windows.Forms.Panel P_Margin_Left;
      public System.Windows.Forms.Label L_Version;
      public System.Windows.Forms.Panel P_CurrentWork;
      private System.Windows.Forms.Panel panel1;
      public System.Windows.Forms.Panel P_Main;
      public CircularProgressBar.CircularProgressBar progressBar;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel P_InfoText;
      private System.Windows.Forms.Panel P_InfoRight;
      private System.Windows.Forms.Panel P_InfoLeft;
      private System.Windows.Forms.Label L_Mode;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label L_Subs;
      private System.Windows.Forms.Label L_Movies;
      private System.Windows.Forms.Label L_Episodes;
      private System.Windows.Forms.Label L_Seasons;
      private System.Windows.Forms.Label L_CleanFolders;
      private System.Windows.Forms.Label L_Reorder;
      private System.Windows.Forms.Label L_Errors;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label labelSubs;
      private System.Windows.Forms.Label labelMovie;
      private System.Windows.Forms.Label labelEpisode;
      private System.Windows.Forms.Label labelSeason;
      private System.Windows.Forms.Label L_CurrentWork;
      private MyButton B_Done;
      private System.Windows.Forms.Panel P_InfoTextContainer;
   }
}
