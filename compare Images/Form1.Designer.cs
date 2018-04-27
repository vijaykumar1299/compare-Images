namespace compare_Images
{
    partial class compareImages
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
            this.largeLabel = new System.Windows.Forms.LinkLabel();
            this.smallLabel = new System.Windows.Forms.LinkLabel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.largePicBox = new System.Windows.Forms.PictureBox();
            this.smallPicBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.outputMessage = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // largeLabel
            // 
            this.largeLabel.AutoSize = true;
            this.largeLabel.Location = new System.Drawing.Point(12, 19);
            this.largeLabel.Name = "largeLabel";
            this.largeLabel.Size = new System.Drawing.Size(99, 13);
            this.largeLabel.TabIndex = 0;
            this.largeLabel.TabStop = true;
            this.largeLabel.Text = "Select Large Image";
            this.largeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.largeLabel_LinkClicked);
            // 
            // smallLabel
            // 
            this.smallLabel.AutoSize = true;
            this.smallLabel.Location = new System.Drawing.Point(15, 36);
            this.smallLabel.Name = "smallLabel";
            this.smallLabel.Size = new System.Drawing.Size(94, 13);
            this.smallLabel.TabIndex = 1;
            this.smallLabel.TabStop = true;
            this.smallLabel.Text = "Select small image";
            this.smallLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.smallLabel_LinkClicked);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(18, 64);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(115, 23);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare Images";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // largePicBox
            // 
            this.largePicBox.Location = new System.Drawing.Point(18, 111);
            this.largePicBox.Name = "largePicBox";
            this.largePicBox.Size = new System.Drawing.Size(368, 192);
            this.largePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePicBox.TabIndex = 3;
            this.largePicBox.TabStop = false;
            // 
            // smallPicBox
            // 
            this.smallPicBox.Location = new System.Drawing.Point(414, 111);
            this.smallPicBox.Name = "smallPicBox";
            this.smallPicBox.Size = new System.Drawing.Size(163, 192);
            this.smallPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smallPicBox.TabIndex = 4;
            this.smallPicBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 343);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Location = new System.Drawing.Point(15, 309);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(35, 13);
            this.outputMessage.TabIndex = 6;
            this.outputMessage.Text = "label1";
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // compareImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 470);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.smallPicBox);
            this.Controls.Add(this.largePicBox);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.smallLabel);
            this.Controls.Add(this.largeLabel);
            this.Name = "compareImages";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.largePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel largeLabel;
        private System.Windows.Forms.LinkLabel smallLabel;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.PictureBox largePicBox;
        private System.Windows.Forms.PictureBox smallPicBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label outputMessage;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}

