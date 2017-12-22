namespace TV_Renamer_2
{
   partial class MoviePromptForm
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
         this.P_Main = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.inputboxName = new System.Windows.Forms.TextBox();
         this.B_Done = new TV_Renamer_2.MyButton();
         this.inputBoxYear = new System.Windows.Forms.TextBox();
         this.L_Message = new System.Windows.Forms.Label();
         this.L_Title = new System.Windows.Forms.Label();
         this.B_Close = new System.Windows.Forms.PictureBox();
         this.P_Main.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.B_Close)).BeginInit();
         this.SuspendLayout();
         // 
         // P_Main
         // 
         this.P_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.P_Main.Controls.Add(this.label2);
         this.P_Main.Controls.Add(this.label1);
         this.P_Main.Controls.Add(this.inputboxName);
         this.P_Main.Controls.Add(this.B_Done);
         this.P_Main.Controls.Add(this.inputBoxYear);
         this.P_Main.Controls.Add(this.L_Message);
         this.P_Main.Controls.Add(this.L_Title);
         this.P_Main.Controls.Add(this.B_Close);
         this.P_Main.Location = new System.Drawing.Point(3, 3);
         this.P_Main.Name = "P_Main";
         this.P_Main.Size = new System.Drawing.Size(494, 269);
         this.P_Main.TabIndex = 0;
         this.P_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(33, 162);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(57, 22);
         this.label2.TabIndex = 9;
         this.label2.Text = "Year:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(33, 123);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(71, 22);
         this.label1.TabIndex = 8;
         this.label1.Text = "Name:";
         // 
         // inputboxName
         // 
         this.inputboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.inputboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.inputboxName.Location = new System.Drawing.Point(133, 119);
         this.inputboxName.Name = "inputboxName";
         this.inputboxName.Size = new System.Drawing.Size(314, 31);
         this.inputboxName.TabIndex = 2;
         this.inputboxName.TextChanged += new System.EventHandler(this.inputboxName_TextChanged);
         // 
         // B_Done
         // 
         this.B_Done.ActiveImage = global::TV_Renamer_2.Properties.Resources.Icon_Checkmark_A;
         this.B_Done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.B_Done.BackColor = System.Drawing.Color.Transparent;
         this.B_Done.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.B_Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.B_Done.Image = global::TV_Renamer_2.Properties.Resources.Icon_Checkmark;
         this.B_Done.Location = new System.Drawing.Point(162, 207);
         this.B_Done.Name = "B_Done";
         this.B_Done.Size = new System.Drawing.Size(170, 43);
         this.B_Done.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.B_Done.TabIndex = 6;
         this.B_Done.Text = "Done";
         // 
         // inputBoxYear
         // 
         this.inputBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.inputBoxYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.inputBoxYear.Location = new System.Drawing.Point(133, 156);
         this.inputBoxYear.Name = "inputBoxYear";
         this.inputBoxYear.Size = new System.Drawing.Size(314, 31);
         this.inputBoxYear.TabIndex = 5;
         // 
         // L_Message
         // 
         this.L_Message.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Message.Location = new System.Drawing.Point(22, 59);
         this.L_Message.Name = "L_Message";
         this.L_Message.Size = new System.Drawing.Size(450, 46);
         this.L_Message.TabIndex = 4;
         this.L_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // L_Title
         // 
         this.L_Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Title.Location = new System.Drawing.Point(9, 9);
         this.L_Title.Name = "L_Title";
         this.L_Title.Size = new System.Drawing.Size(415, 25);
         this.L_Title.TabIndex = 3;
         this.L_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
         // 
         // B_Close
         // 
         this.B_Close.Image = global::TV_Renamer_2.Properties.Resources.B_Red;
         this.B_Close.Location = new System.Drawing.Point(460, 9);
         this.B_Close.Name = "B_Close";
         this.B_Close.Size = new System.Drawing.Size(25, 25);
         this.B_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.B_Close.TabIndex = 2;
         this.B_Close.TabStop = false;
         // 
         // MoviePromptForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(148)))), ((int)(((byte)(226)))));
         this.ClientSize = new System.Drawing.Size(500, 275);
         this.Controls.Add(this.P_Main);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
         this.Name = "MoviePromptForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "PromptForm";
         this.P_Main.ResumeLayout(false);
         this.P_Main.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.B_Close)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel P_Main;
      private System.Windows.Forms.Label L_Message;
      private System.Windows.Forms.Label L_Title;
      public System.Windows.Forms.TextBox inputBoxYear;
      public MyButton B_Done;
      public System.Windows.Forms.PictureBox B_Close;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      public System.Windows.Forms.TextBox inputboxName;
   }
}