namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(133, 92);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(109, 37);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.GameScreen);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(133, 185);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(109, 38);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutScreen);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.ResumeLayout(false);

        }

        #endregion

        private Button startButton;
        private Button aboutButton;
    }
}