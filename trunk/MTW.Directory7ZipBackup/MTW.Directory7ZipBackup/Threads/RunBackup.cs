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
using System.Linq;
using System.Text;
using System.Threading;
using SevenZip;
using System.IO;

namespace MTW.Directory7ZipBackup.Threads
{
    class RunBackup
    {
        #region Fields

        private MainForm _mainForm;

        private string _backupDest = "";
        private string _backupSource = "";
        private string _password = "";

        #endregion

        #region Contructors

        public RunBackup()
        {
        }

        #endregion

        #region Public Methods

        public void Execute(Object threadData)
        {
            /*********************************************************/
            #region Read Thread Object Data

            object[] dataArray = (object[])threadData;
            _mainForm = (MainForm)dataArray[0];
            try
            {
                _backupDest = (string)dataArray[1];
                _backupSource = (string)dataArray[2];
                _password = (string)dataArray[3];
            }
            catch (Exception) { }

            #endregion
            /*********************************************************/

            /*********************************************************/
            #region setup 7zip

            SevenZipCompressor.SetLibraryPath("7z.dll");
            _mainForm.UpdateActionLabel("Backing Up:");
            _mainForm.UpdatePercentage("0");
            _mainForm.UpdateCurrentFileDirLabel("");

            var compressor = new SevenZipCompressor();
            compressor.ArchiveFormat = OutArchiveFormat.SevenZip;
            compressor.CompressionLevel = CompressionLevel.Normal;
            compressor.ZipEncryptionMethod = ZipEncryptionMethod.Aes256;
            compressor.EncryptHeaders = true;
            compressor.FileCompressionStarted += (s, e) =>
            {
                _mainForm.UpdatePercentage(String.Format("{0}",e.PercentDone));
                _mainForm.UpdateCurrentFileDirLabel(e.FileName);
            };

            #endregion
            /*********************************************************/

            DirectoryInfo test = new DirectoryInfo(_backupSource);
            string archiveName = _backupDest + "\\" + test.Name + ".7z";

            if (!_password.Equals(""))
            {
                compressor.CompressDirectory(_backupSource, archiveName, _password);
            }
            else
            {
                compressor.CompressDirectory(_backupSource, archiveName);
            }
            _mainForm.UpdateActionLabel("Status:");
            _mainForm.UpdateCurrentFileDirLabel("Completed");
        }

        #endregion
    }
}