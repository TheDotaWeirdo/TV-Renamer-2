namespace TV_Renamer_2
{
   partial class MyButton
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
         this.L_Label = new System.Windows.Forms.Label();
         this.PB_Icon = new System.Windows.Forms.PictureBox();
         this.PB_Back = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Back)).BeginInit();
         this.SuspendLayout();
         // 
         // L_Label
         // 
         this.L_Label.AutoSize = true;
         this.L_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.L_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
         this.L_Label.Location = new System.Drawing.Point(51, 8);
         this.L_Label.Name = "L_Label";
         this.L_Label.Size = new System.Drawing.Size(99, 22);
         this.L_Label.TabIndex = 1;
         this.L_Label.Text = "MyButton";
         this.L_Label.Click += new System.EventHandler(this.OnClick);
         this.L_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
         this.L_Label.MouseEnter += new System.EventHandler(this.On_MouseEnter);
         this.L_Label.MouseLeave += new System.EventHandler(this.On_MouseLeave);
         this.L_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.On_MouseUp);
         // 
         // PB_Icon
         // 
         this.PB_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.PB_Icon.Location = new System.Drawing.Point(5, 3);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(38, 38);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_Icon.TabIndex = 2;
         this.PB_Icon.TabStop = false;
         this.PB_Icon.Click += new System.EventHandler(this.OnClick);
         this.PB_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
         this.PB_Icon.MouseEnter += new System.EventHandler(this.On_MouseEnter);
         this.PB_Icon.MouseLeave += new System.EventHandler(this.On_MouseLeave);
         this.PB_Icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.On_MouseUp);
         // 
         // PB_Back
         // 
         this.PB_Back.BackColor = System.Drawing.Color.Transparent;
         this.PB_Back.Dock = System.Windows.Forms.DockStyle.Fill;
         this.PB_Back.Image = global::TV_Renamer_2.Properties.Resources.Button_Normal;
         this.PB_Back.Location = new System.Drawing.Point(0, 0);
         this.PB_Back.Name = "PB_Back";
         this.PB_Back.Size = new System.Drawing.Size(150, 37);
         this.PB_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.PB_Back.TabIndex = 0;
         this.PB_Back.TabStop = false;
         this.PB_Back.Click += new System.EventHandler(this.OnClick);
         this.PB_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.On_MouseDown);
         this.PB_Back.MouseEnter += new System.EventHandler(this.On_MouseEnter);
         this.PB_Back.MouseLeave += new System.EventHandler(this.On_MouseLeave);
         this.PB_Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.On_MouseUp);
         // 
         // MyButton
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.Transparent;
         this.Controls.Add(this.PB_Icon);
         this.Controls.Add(this.L_Label);
         this.Controls.Add(this.PB_Back);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Name = "MyButton";
         this.Size = new System.Drawing.Size(150, 37);
         this.Load += new System.EventHandler(this.MyButton_Load);
         this.FontChanged += new System.EventHandler(this.MyButton_FontChanged);
         this.Resize += new System.EventHandler(this.MyButton_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Back)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox PB_Back;
      private System.Windows.Forms.Label L_Label;
      private System.Windows.Forms.PictureBox PB_Icon;
   }
}
