
namespace Birds
{
    partial class learnFromPictures
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.birdImage = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(103, 177);
            this.userInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(189, 20);
            this.userInput.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(152, 205);
            this.submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(88, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // birdImage
            // 
            this.birdImage.Location = new System.Drawing.Point(103, 24);
            this.birdImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.birdImage.Name = "birdImage";
            this.birdImage.Size = new System.Drawing.Size(188, 149);
            this.birdImage.TabIndex = 2;
            this.birdImage.TabStop = false;
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(103, 269);
            this.Continue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(188, 21);
            this.Continue.TabIndex = 3;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // learnFromPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.birdImage);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.userInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "learnFromPictures";
            this.Text = "Learn From Pictures";
            this.Load += new System.EventHandler(this.learnFromPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox birdImage;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label1;
    }
}