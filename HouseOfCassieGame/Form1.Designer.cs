namespace HouseOfCassieGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureDisplay = new System.Windows.Forms.PictureBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.storyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDisplay
            // 
            this.pictureDisplay.Image = global::HouseOfCassieGame.Properties.Resources.page1;
            this.pictureDisplay.Location = new System.Drawing.Point(13, -4);
            this.pictureDisplay.Name = "pictureDisplay";
            this.pictureDisplay.Size = new System.Drawing.Size(775, 417);
            this.pictureDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDisplay.TabIndex = 0;
            this.pictureDisplay.TabStop = false;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(13, 459);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(180, 111);
            this.leftButton.TabIndex = 1;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(608, 459);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(180, 111);
            this.rightButton.TabIndex = 2;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Location = new System.Drawing.Point(10, 427);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(0, 13);
            this.storyLabel.TabIndex = 3;
            this.storyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.pictureDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The House of Cassie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDisplay;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Label storyLabel;
    }
}

