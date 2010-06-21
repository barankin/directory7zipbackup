/*   
    This file is part of MTW.Directory7ZipBackup.

    MTW.Directory7ZipBackup is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MTW.Directory7ZipBackup is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
*/

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
