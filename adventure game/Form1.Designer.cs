namespace adventure_game
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
            this.topButtonLabel = new System.Windows.Forms.Label();
            this.bottomButtonLabel = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.mainPictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // topButtonLabel
            // 
            this.topButtonLabel.AutoSize = true;
            this.topButtonLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topButtonLabel.Location = new System.Drawing.Point(150, 299);
            this.topButtonLabel.Name = "topButtonLabel";
            this.topButtonLabel.Size = new System.Drawing.Size(69, 24);
            this.topButtonLabel.TabIndex = 7;
            this.topButtonLabel.Text = "label1";
            // 
            // bottomButtonLabel
            // 
            this.bottomButtonLabel.AutoSize = true;
            this.bottomButtonLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomButtonLabel.Location = new System.Drawing.Point(150, 384);
            this.bottomButtonLabel.Name = "bottomButtonLabel";
            this.bottomButtonLabel.Size = new System.Drawing.Size(69, 24);
            this.bottomButtonLabel.TabIndex = 9;
            this.bottomButtonLabel.Text = "label1";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPictureBox.Location = new System.Drawing.Point(31, 108);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(436, 168);
            this.mainPictureBox.TabIndex = 11;
            this.mainPictureBox.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox1.Location = new System.Drawing.Point(31, 384);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(60, 54);
            this.imageBox1.TabIndex = 8;
            this.imageBox1.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(31, 299);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(60, 54);
            this.imageBox.TabIndex = 6;
            this.imageBox.TabStop = false;
            // 
            // mainPictureBox2
            // 
            this.mainPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPictureBox2.Location = new System.Drawing.Point(154, 108);
            this.mainPictureBox2.Name = "mainPictureBox2";
            this.mainPictureBox2.Size = new System.Drawing.Size(179, 168);
            this.mainPictureBox2.TabIndex = 12;
            this.mainPictureBox2.TabStop = false;
            this.mainPictureBox2.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(31, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(436, 81);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainPictureBox2);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.bottomButtonLabel);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.topButtonLabel);
            this.Controls.Add(this.imageBox);
            this.Name = "Form1";
            this.Text = "   Fortnite Battle Royale";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label topButtonLabel;
        private System.Windows.Forms.PictureBox imageBox1;
        private System.Windows.Forms.Label bottomButtonLabel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.PictureBox mainPictureBox2;
        private System.Windows.Forms.Label titleLabel;
    }
}

