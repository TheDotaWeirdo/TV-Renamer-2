namespace TV_Renamer_2
{
   partial class MyCheckBox
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
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
         this.SuspendLayout();
         // 
         // L_Label
         // 
         this.L_Label.AutoSize = true;
         this.L_Label.BackColor = System.Drawing.Color.Transparent;
         this.L_Label.Location = new System.Drawing.Point(62, 11);
         this.L_Label.Name = "L_Label";
         this.L_Label.Size = new System.Drawing.Size(99, 22);
         this.L_Label.TabIndex = 1;
         this.L_Label.Text = "MyButton";
         this.L_Label.Click += new System.EventHandler(this.OnClick);
         // 
         // PB_Icon
         // 
         this.PB_Icon.BackColor = System.Drawing.Color.Transparent;
         this.PB_Icon.Image = global::TV_Renamer_2.Properties.Resources.Check_Unchecked;
         this.PB_Icon.Location = new System.Drawing.Point(5, 3);
         this.PB_Icon.Name = "PB_Icon";
         this.PB_Icon.Size = new System.Drawing.Size(39, 39);
         this.PB_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_Icon.TabIndex = 2;
         this.PB_Icon.TabStop = false;
         this.PB_Icon.EnabledChanged += new System.EventHandler(this.PB_Icon_EnabledChanged);
         this.PB_Icon.Click += new System.EventHandler(this.OnClick);
         // 
         // MyCheckBox
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.Transparent;
         this.Controls.Add(this.PB_Icon);
         this.Controls.Add(this.L_Label);
         this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Name = "MyCheckBox";
         this.Size = new System.Drawing.Size(210, 45);
         this.Load += new System.EventHandler(this.MyCheckBox_Resize);
         this.FontChanged += new System.EventHandler(this.MyButton_FontChanged);
         this.ForeColorChanged += new System.EventHandler(this.MyCheckBox_ForeColorChanged);
         this.Click += new System.EventHandler(this.OnClick);
         this.Resize += new System.EventHandler(this.MyCheckBox_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label L_Label;
      private System.Windows.Forms.PictureBox PB_Icon;
   }
}
