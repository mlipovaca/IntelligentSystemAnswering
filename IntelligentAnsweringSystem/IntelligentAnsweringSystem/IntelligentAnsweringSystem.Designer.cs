namespace IntelligentAnsweringSystem
{
    partial class IntelligentAnsweringSystemForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntelligentAnsweringSystemForm));
            this.MainTitleLabel = new System.Windows.Forms.Label();
            this.MicrophoneIcon = new System.Windows.Forms.PictureBox();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.TmrSpeaking = new System.Windows.Forms.Timer(this.components);
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.agentTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MicrophoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTitleLabel
            // 
            this.MainTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTitleLabel.BackColor = System.Drawing.Color.Black;
            this.MainTitleLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MainTitleLabel.Location = new System.Drawing.Point(12, 76);
            this.MainTitleLabel.Name = "MainTitleLabel";
            this.MainTitleLabel.Size = new System.Drawing.Size(747, 39);
            this.MainTitleLabel.TabIndex = 2;
            this.MainTitleLabel.Text = "Intelligent Answering System";
            this.MainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MicrophoneIcon
            // 
            this.MicrophoneIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MicrophoneIcon.BackColor = System.Drawing.SystemColors.InfoText;
            this.MicrophoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("MicrophoneIcon.Image")));
            this.MicrophoneIcon.Location = new System.Drawing.Point(18, 404);
            this.MicrophoneIcon.Name = "MicrophoneIcon";
            this.MicrophoneIcon.Size = new System.Drawing.Size(741, 67);
            this.MicrophoneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MicrophoneIcon.TabIndex = 3;
            this.MicrophoneIcon.TabStop = false;
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage.ErrorImage = null;
            this.BackgroundImage.InitialImage = null;
            this.BackgroundImage.Location = new System.Drawing.Point(-1, -60);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(773, 561);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage.TabIndex = 1;
            this.BackgroundImage.TabStop = false;
            // 
            // TmrSpeaking
            // 
            this.TmrSpeaking.Enabled = true;
            this.TmrSpeaking.Interval = 1000;
            this.TmrSpeaking.Tick += new System.EventHandler(this.TmrSpeaking_Tick);
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.Black;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(83, 329);
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(259, 69);
            this.userTextBox.TabIndex = 4;
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agentTextBox
            // 
            this.agentTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.agentTextBox.ForeColor = System.Drawing.Color.White;
            this.agentTextBox.Location = new System.Drawing.Point(434, 329);
            this.agentTextBox.Multiline = true;
            this.agentTextBox.Name = "agentTextBox";
            this.agentTextBox.ReadOnly = true;
            this.agentTextBox.Size = new System.Drawing.Size(259, 69);
            this.agentTextBox.TabIndex = 5;
            this.agentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntelligentAnsweringSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(771, 501);
            this.Controls.Add(this.agentTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.MicrophoneIcon);
            this.Controls.Add(this.MainTitleLabel);
            this.Controls.Add(this.BackgroundImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntelligentAnsweringSystemForm";
            this.Text = "Intelligent Answering System";
            this.Load += new System.EventHandler(this.IntelligentAnsweringSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MicrophoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BackgroundImage;
        private System.Windows.Forms.Label MainTitleLabel;
        private System.Windows.Forms.PictureBox MicrophoneIcon;
        private System.Windows.Forms.Timer TmrSpeaking;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox agentTextBox;
    }
}

