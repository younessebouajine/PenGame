namespace MySimpleProject_Pen_Book._
{
    partial class Form1
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
            this.radioButtonBoy = new System.Windows.Forms.RadioButton();
            this.radioButtonGirl = new System.Windows.Forms.RadioButton();
            this.radioButtonPen = new System.Windows.Forms.RadioButton();
            this.radioButtonBook = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBoy
            // 
            this.radioButtonBoy.AutoSize = true;
            this.radioButtonBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBoy.Location = new System.Drawing.Point(230, 595);
            this.radioButtonBoy.Name = "radioButtonBoy";
            this.radioButtonBoy.Size = new System.Drawing.Size(70, 29);
            this.radioButtonBoy.TabIndex = 0;
            this.radioButtonBoy.TabStop = true;
            this.radioButtonBoy.Text = "Boy";
            this.radioButtonBoy.UseVisualStyleBackColor = true;
            this.radioButtonBoy.CheckedChanged += new System.EventHandler(this.radioButtonBoy_CheckedChanged);
            // 
            // radioButtonGirl
            // 
            this.radioButtonGirl.AutoSize = true;
            this.radioButtonGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGirl.Location = new System.Drawing.Point(407, 595);
            this.radioButtonGirl.Name = "radioButtonGirl";
            this.radioButtonGirl.Size = new System.Drawing.Size(66, 29);
            this.radioButtonGirl.TabIndex = 1;
            this.radioButtonGirl.TabStop = true;
            this.radioButtonGirl.Tag = "Girl";
            this.radioButtonGirl.Text = "Girl";
            this.radioButtonGirl.UseVisualStyleBackColor = true;
            this.radioButtonGirl.CheckedChanged += new System.EventHandler(this.radioButtonGirl_CheckedChanged);
            // 
            // radioButtonPen
            // 
            this.radioButtonPen.AutoSize = true;
            this.radioButtonPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPen.Location = new System.Drawing.Point(580, 595);
            this.radioButtonPen.Name = "radioButtonPen";
            this.radioButtonPen.Size = new System.Drawing.Size(71, 29);
            this.radioButtonPen.TabIndex = 2;
            this.radioButtonPen.TabStop = true;
            this.radioButtonPen.Text = "Pen";
            this.radioButtonPen.UseVisualStyleBackColor = true;
            this.radioButtonPen.CheckedChanged += new System.EventHandler(this.radioButtonPen_CheckedChanged);
            // 
            // radioButtonBook
            // 
            this.radioButtonBook.AutoSize = true;
            this.radioButtonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBook.Location = new System.Drawing.Point(754, 595);
            this.radioButtonBook.Name = "radioButtonBook";
            this.radioButtonBook.Size = new System.Drawing.Size(82, 29);
            this.radioButtonBook.TabIndex = 3;
            this.radioButtonBook.TabStop = true;
            this.radioButtonBook.Text = "Book";
            this.radioButtonBook.UseVisualStyleBackColor = true;
            this.radioButtonBook.CheckedChanged += new System.EventHandler(this.radioButtonBook_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(449, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 56);
            this.label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(304, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 697);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBook);
            this.Controls.Add(this.radioButtonPen);
            this.Controls.Add(this.radioButtonGirl);
            this.Controls.Add(this.radioButtonBoy);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBoy;
        private System.Windows.Forms.RadioButton radioButtonGirl;
        private System.Windows.Forms.RadioButton radioButtonPen;
        private System.Windows.Forms.RadioButton radioButtonBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

