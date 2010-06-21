using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SLI.Lib.Interfaces;
using System.Threading;
using MTW.WorkBackup.Threads;
using System.IO;

namespace MTW.WorkBackup
{
    public partial class Form1 : FormInterface
    {
        private LoadConfigData _loadConfigData = null;
        private SaveConfigData _saveConfigData = null;
        private RunBackup _runBackup = null;

        public Form1()
        {
            InitializeComponent();
            _passwordTextBox.PasswordChar = '*';
            _loadConfigData = new LoadConfigData();
            _saveConfigData = new SaveConfigData();
            _runBackup = new RunBackup();
            _compressionProgressBar.Minimum = 0;
            _compressionProgressBar.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            catch (Exception err)
            {
                AppendException(err);
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
            catch (Exception err)
            {
                AppendException(err);
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
