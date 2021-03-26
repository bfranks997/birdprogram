
namespace Birds
{
    partial class mainMenu
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
            this.learnFromCalls = new System.Windows.Forms.Button();
            this.learnFromPictures = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // learnFromCalls
            // 
            this.learnFromCalls.Enabled = false;
            this.learnFromCalls.Location = new System.Drawing.Point(104, 330);
            this.learnFromCalls.Name = "learnFromCalls";
            this.learnFromCalls.Size = new System.Drawing.Size(205, 42);
            this.learnFromCalls.TabIndex = 0;
            this.learnFromCalls.Text = "Learn From Calls";
            this.learnFromCalls.UseVisualStyleBackColor = true;
            // 
            // learnFromPictures
            // 
            this.learnFromPictures.Location = new System.Drawing.Point(372, 330);
            this.learnFromPictures.Name = "learnFromPictures";
            this.learnFromPictures.Size = new System.Drawing.Size(205, 42);
            this.learnFromPictures.TabIndex = 1;
            this.learnFromPictures.Text = "Learn From Pictures";
            this.learnFromPictures.UseVisualStyleBackColor = true;
            this.learnFromPictures.Click += new System.EventHandler(this.learnFromPictures_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Birds.Properties.Resources._63740061_480px;
            this.pictureBox1.Location = new System.Drawing.Point(104, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.learnFromPictures);
            this.Controls.Add(this.learnFromCalls);
            this.Name = "mainMenu";
            this.Text = "Bird Learner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button learnFromCalls;
        private System.Windows.Forms.Button learnFromPictures;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

