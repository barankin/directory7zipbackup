using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MTW.Directory7ZipBackup.Threads;
using System.IO;

namespace MTW.Directory7ZipBackup
{
    public partial class MainForm : Form
    {
        private LoadConfigData _loadConfigData = null;
        private SaveConfigData _saveConfigData = null;
        private RunBackup _runBackup = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _passwordTextBox.PasswordChar = '*';
            _loadConfigData = new LoadConfigData();
            _saveConfigData = new SaveConfigData();
            _runBackup = new RunBackup();
            _compressionProgressBar.Minimum = 0;
            _compressionProgressBar.Maximum = 100;
            ThreadPool.QueueUserWorkItem(_loadConfigData.Execute, new object[] 
            { 
                    this, _backupDestTextBox.Text, _backupSourceTextBox.Text 
            });
        }

        private void _sourceButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region Get new Source from dialog
                FolderBrowserDialog sourceDirectoryDialog = new FolderBrowserDialog();
                //sourceDirectoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
                sourceDirectoryDialog.SelectedPath = _backupSourceTextBox.Text;
                if (sourceDirectoryDialog.ShowDialog() == DialogResult.OK)
                {
                    _backupSourceTextBox.Text = sourceDirectoryDialog.SelectedPath;

                    ThreadPool.QueueUserWorkItem(_saveConfigData.Execute, new object[] 
                    { 
                        this, _backupDestTextBox.Text, _backupSourceTextBox.Text 
                    });
                }
                #endregion
            }
            catch (Exception)
            {
            }
        }

        private void _destButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region Get new Source from dialog
                FolderBrowserDialog sourceDirectoryDialog = new FolderBrowserDialog();
                //sourceDirectoryDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
                sourceDirectoryDialog.SelectedPath = _backupDestTextBox.Text;
                if (sourceDirectoryDialog.ShowDialog() == DialogResult.OK)
                {
                    _backupDestTextBox.Text = sourceDirectoryDialog.SelectedPath;

                    ThreadPool.QueueUserWorkItem(_saveConfigData.Execute, new object[] 
                    { 
                        this, _backupDestTextBox.Text, _backupSourceTextBox.Text 
                    });
                }
                #endregion
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(_runBackup.Execute, new object[] 
            { 
                    this, _backupDestTextBox.Text, _backupSourceTextBox.Text , _passwordTextBox.Text
            });
        }

        private void _passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r')
            {
                ThreadPool.QueueUserWorkItem(_runBackup.Execute, new object[] 
                { 
                    this, _backupDestTextBox.Text, _backupSourceTextBox.Text , _passwordTextBox.Text
                });
            }
        }
    }
}
