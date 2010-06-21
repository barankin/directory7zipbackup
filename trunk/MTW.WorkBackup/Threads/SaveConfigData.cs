using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Yaml.Serialization;
using SLI.Lib.Interfaces;
using System.IO;

namespace MTW.WorkBackup.Threads
{
    class SaveConfigData
    {
        /*************************************************************/
        #region Fields

        private Form1 _mainForm;

        private YamlSerializer _yamlSerializer;
        //private static String _sevenZipPassword = "b5sp8h6g9*Apha3a_pu#pu4&ap9ak88azu2e+@9ruBAtrutusp2jaspes8=*#ebe";

        private string _backupDestTextBox = "";
        private string _backupSourceTextBox = "";

        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Contructors

        public SaveConfigData()
        {
            _yamlSerializer = new YamlSerializer();
        }

        #endregion
        /*************************************************************/

        /*************************************************************/
        #region Public Methods
        public void Execute(Object threadData)
        {
            /*********************************************************/
            #region Read Thread Object Data

            object[] dataArray = (object[])threadData;
            _mainForm = (Form1)dataArray[0];
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
                object[] serializedWrite = new object[] { _backupDestTextBox, _backupSourceTextBox };
                _yamlSerializer.SerializeToFile("config/directory.config.yml", serializedWrite);
            }
            catch (Exception) { }
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