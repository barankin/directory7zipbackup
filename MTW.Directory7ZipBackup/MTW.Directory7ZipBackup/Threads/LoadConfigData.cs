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
using System.IO;
using System.Yaml.Serialization;

namespace MTW.Directory7ZipBackup.Threads
{
    class LoadConfigData
    {
        /*************************************************************/
        #region Fields

        private MainForm _mainForm;

        private YamlSerializer _yamlSerializer;
        //private static String _sevenZipPassword = "b5sp8h6g9*Apha3a_pu#pu4&ap9ak88azu2e+@9ruBAtrutusp2jaspes8=*#ebe";

        private string _backupDestTextBox = "";
        private string _backupSourceTextBox = "";

        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Contructors

        public LoadConfigData()
        {
            _yamlSerializer = new YamlSerializer();
        }

        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Properties


        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Public Methods
        public void Execute(Object threadData)
        {
            /*********************************************************/
            #region Read Thread Object Data

            object[] dataArray = (object[])threadData;
            _mainForm = (MainForm)dataArray[0];
            try
            {
                _backupDestTextBox = (string)dataArray[1];
                _backupSourceTextBox = (string)dataArray[2];
            }
            catch (Exception) { }

            #endregion
            /*********************************************************/

            /*********************************************************/
            #region setup config data
            _yamlSerializer = new YamlSerializer();
            DirectoryInfo dConfig = new DirectoryInfo("config");
            if (!dConfig.Exists)
            {
                dConfig.Create();
            }

            try
            {
                object[] serializedRead = (object[])_yamlSerializer.DeserializeFromFile(
                   "config/directory.config.yml")[0];
                _backupDestTextBox = (string)serializedRead[0];
                _backupSourceTextBox = (string)serializedRead[1];

                _mainForm.UpdateBackupDestTextBox(_backupDestTextBox);
                _mainForm.UpdateBackupSourceTextBox(_backupSourceTextBox);
            }
            catch (Exception)
            {
                object[] serializedWrite = new object[] { _backupDestTextBox, _backupSourceTextBox };
                _yamlSerializer.SerializeToFile("config/directory.config.yml",serializedWrite);
            }
            #endregion
            /*********************************************************/
        }

        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Private Methods


        #endregion
        /*************************************************************/
    }
}