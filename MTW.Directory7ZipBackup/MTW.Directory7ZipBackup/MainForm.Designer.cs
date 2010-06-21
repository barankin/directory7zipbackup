using System.Windows.Forms;
namespace MTW.Directory7ZipBackup
{
    partial class MainForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._sourceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._backupSourceTextBox = new System.Windows.Forms.TextBox();
            this._backupDestTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._destButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._sourceOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._compressionProgressBar = new System.Windows.Forms.ProgressBar();
            this._percentageLabel = new System.Windows.Forms.Label();
            this._messageLabel = new System.Windows.Forms.Label();
            this._currentFileDirLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _sourceButton
            // 
            this._sourceButton.Location = new System.Drawing.Point(158, 15);
            this._sourceButton.Name = "_sourceButton";
            this._sourceButton.Size = new System.Drawing.Size(75, 23);
            this._sourceButton.TabIndex = 0;
            this._sourceButton.Text = "Select";
            this._sourceButton.UseVisualStyleBackColor = true;
            this._sourceButton.Click += new System.EventHandler(this._sourceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory to Backup";
            // 
            // _backupSourceTextBox
            // 
            this._backupSourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._backupSourceTextBox.Location = new System.Drawing.Point(12, 44);
            this._backupSourceTextBox.Name = "_backupSourceTextBox";
            this._backupSourceTextBox.Size = new System.Drawing.Size(920, 20);
            this._backupSourceTextBox.TabIndex = 2;
            this._backupSourceTextBox.Text = "F:\\Visual Studio 2008";
            // 
            // _backupDestTextBox
            // 
            this._backupDestTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._backupDestTextBox.Location = new System.Drawing.Point(12, 105);
            this._backupDestTextBox.Name = "_backupDestTextBox";
            this._backupDestTextBox.Size = new System.Drawing.Size(920, 20);
            this._backupDestTextBox.TabIndex = 5;
            this._backupDestTextBox.Text = "C:\\Documents and Settings\\rankb\\My Documents\\Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Backup Storage Location";
            // 
            // _destButton
            // 
            this._destButton.Location = new System.Drawing.Point(158, 76);
            this._destButton.Name = "_destButton";
            this._destButton.Size = new System.Drawing.Size(75, 23);
            this._destButton.TabIndex = 3;
            this._destButton.Text = "Select";
            this._destButton.UseVisualStyleBackColor = true;
            this._destButton.Click += new System.EventHandler(this._destButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Run Backup";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(12, 164);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(322, 20);
            this._passwordTextBox.TabIndex = 9;
            this._passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._passwordTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password (Optional)";
            // 
            // _compressionProgressBar
            // 
            this._compressionProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._compressionProgressBar.Location = new System.Drawing.Point(12, 264);
            this._compressionProgressBar.Name = "_compressionProgressBar";
            this._compressionProgressBar.Size = new System.Drawing.Size(920, 23);
            this._compressionProgressBar.TabIndex = 10;
            // 
            // _percentageLabel
            // 
            this._percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._percentageLabel.AutoSize = true;
            this._percentageLabel.Location = new System.Drawing.Point(26, 248);
            this._percentageLabel.Name = "_percentageLabel";
            this._percentageLabel.Size = new System.Drawing.Size(0, 13);
            this._percentageLabel.TabIndex = 11;
            this._percentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _messageLabel
            // 
            this._messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._messageLabel.AutoSize = true;
            this._messageLabel.Location = new System.Drawing.Point(105, 248);
            this._messageLabel.Name = "_messageLabel";
            this._messageLabel.Size = new System.Drawing.Size(0, 13);
            this._messageLabel.TabIndex = 12;
            this._messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _currentFileDirLabel
            // 
            this._currentFileDirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._currentFileDirLabel.AutoSize = true;
            this._currentFileDirLabel.Location = new System.Drawing.Point(177, 248);
            this._currentFileDirLabel.Name = "_currentFileDirLabel";
            this._currentFileDirLabel.Size = new System.Drawing.Size(0, 13);
            this._currentFileDirLabel.TabIndex = 13;
            this._currentFileDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 303);
            this.Controls.Add(this._currentFileDirLabel);
            this.Controls.Add(this._messageLabel);
            this.Controls.Add(this._percentageLabel);
            this.Controls.Add(this._compressionProgressBar);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this._backupDestTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._destButton);
            this.Controls.Add(this._backupSourceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._sourceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "My Backup";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sourceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _backupSourceTextBox;
        private System.Windows.Forms.TextBox _backupDestTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _destButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog _sourceOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar _compressionProgressBar;
        private System.Windows.Forms.Label _percentageLabel;
        private System.Windows.Forms.Label _messageLabel;
        private System.Windows.Forms.Label _currentFileDirLabel;
    }
}

