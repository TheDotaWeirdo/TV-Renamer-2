namespace TV_Renamer_2
{
   partial class MyRadioButton
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
         this.CB_Label = new System.Windows.Forms.Label();
         this.Box = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
         this.SuspendLayout();
         // 
         // CB_Label
         // 
         this.CB_Label.AutoSize = true;
         this.CB_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.CB_Label.Location = new System.Drawing.Point(41, 8);
         this.CB_Label.Name = "CB_Label";
         this.CB_Label.Size = new System.Drawing.Size(131, 22);
         this.CB_Label.TabIndex = 1;
         this.CB_Label.Text = "MyCheckBox";
         this.CB_Label.Click += new System.EventHandler(this.Box_Click);
         // 
         // Box
         // 
         this.Box.Image = global::TV_Renamer_2.Properties.Resources.Radio_Unhecked;
         this.Box.Location = new System.Drawing.Point(7, 6);
         this.Box.Margin = new System.Windows.Forms.Padding(5);
         this.Box.Name = "Box";
         this.Box.Size = new System.Drawing.Size(26, 26);
         this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.Box.TabIndex = 0;
         this.Box.TabStop = false;
         this.Box.Click += new System.EventHandler(this.Box_Click);
         // 
         // MyRadioButton
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.Transparent;
         this.Controls.Add(this.CB_Label);
         this.Controls.Add(this.Box);
         this.Font = new System.Drawing.Font("Century Gothic", 12F);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
         this.Margin = new System.Windows.Forms.Padding(5);
         this.Name = "MyRadioButton";
         this.Size = new System.Drawing.Size(192, 41);
         this.Load += new System.EventHandler(this.MyCheckBox_Load);
         this.FontChanged += new System.EventHandler(this.MyCheckBox_FontChanged);
         this.Click += new System.EventHandler(this.Box_Click);
         this.Resize += new System.EventHandler(this.MyRadioButton_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox Box;
      private System.Windows.Forms.Label CB_Label;
   }
}
