namespace TV_Renamer_2
{
   partial class PromptForm
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
         this.B_Done = new TV_Renamer_2.MyButton();
         this.inputBox = new System.Windows.Forms.TextBox();
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
         this.P_Main.Controls.Add(this.B_Done);
         this.P_Main.Controls.Add(this.inputBox);
         this.P_Main.Controls.Add(this.L_Message);
         this.P_Main.Controls.Add(this.L_Title);
         this.P_Main.Controls.Add(this.B_Close);
         this.P_Main.Location = new System.Drawing.Point(3, 3);
         this.P_Main.Name = "P_Main";
         this.P_Main.Size = new System.Drawing.Size(494, 269);
         this.P_Main.TabIndex = 0;
         this.P_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
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
         // inputBox
         // 
         this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.inputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.inputBox.Location = new System.Drawing.Point(47, 156);
         this.inputBox.Name = "inputBox";
         this.inputBox.Size = new System.Drawing.Size(400, 31);
         this.inputBox.TabIndex = 5;
         this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
         // 
         // L_Message
         // 
         this.L_Message.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.L_Message.Location = new System.Drawing.Point(22, 59);
         this.L_Message.Name = "L_Message";
         this.L_Message.Size = new System.Drawing.Size(450, 66);
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
         // PromptForm
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
         this.Name = "PromptForm";
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
      public System.Windows.Forms.TextBox inputBox;
      public MyButton B_Done;
      public System.Windows.Forms.PictureBox B_Close;
   }
}