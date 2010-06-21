using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MTW.Directory7ZipBackup
{
    public partial class MainForm
    {

        #region Public Methods

        public void UpdateBackupDestTextBox(string toUpdate)
        {
            if (this._passwordTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updateBackupDestTextBox);
                this.Invoke
                    (d, new object[] { toUpdate });
            }
            else
            {
                updateBackupDestTextBox(toUpdate);
            }
        }

        public void UpdateBackupSourceTextBox(string toUpdate)
        {
            if (this._passwordTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updateBackupSourceTextBox);
                this.Invoke
                    (d, new object[] { toUpdate });
            }
            else
            {
                updateBackupSourceTextBox(toUpdate);
            }
        }

        public void UpdatePercentage(string text)
        {
            if (this._passwordTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updatePercentage);
                this.Invoke
                    (d, new object[] { text });
            }
            else
            {
                updatePercentage(text);
            }
        }

        public void UpdateActionLabel(string text)
        {
            if (this._passwordTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updateActionLabel);
                this.Invoke
                    (d, new object[] { text });
            }
            else
            {
                updateActionLabel(text);
            }
        }

        public void UpdateCurrentFileDirLabel(string text)
        {
            if (this._passwordTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(updateCurrentFileDirLabel);
                this.Invoke
                    (d, new object[] { text });
            }
            else
            {
                updateCurrentFileDirLabel(text);
            }
        }

        #endregion

        #region Private Methods

        private delegate void SetTextCallback(string toAppend);
        private delegate void SetTextCallbackException(Exception e);

        private void updatePercentage(string text)
        {
            _percentageLabel.Text = "[" + text + "%]";
            int value = 0;
            Int32.TryParse(text, out value);
            _compressionProgressBar.Value = value;
        }

        private void updateActionLabel(string text)
        {
            _messageLabel.Text = text;
        }

        private void updateCurrentFileDirLabel(string text)
        {
            _currentFileDirLabel.Text = text;
        }

        private void updateBackupDestTextBox(string toUpdate)
        {
            _backupDestTextBox.Text = toUpdate;
        }

        private void updateBackupSourceTextBox(string toUpdate)
        {
            _backupSourceTextBox.Text = toUpdate;
        }

        #endregion
    }
}