﻿using System;
using StudentManagement.View;
using Oracle.ManagedDataAccess.Client;
using StudentManagement.View.Setup;
using StudentManagement.App;
using StudentManagement.Helper;

namespace StudentManagement
{
    public class Autoload
    {
        private OracleConnection _conn;
        private bool EnvCheck = false;
        public Autoload() {
            LoadConfig();
            //InitialSetup();
            if (!EnvFunc.ValidateEnvOnInstallScreen())
            {
                InitialSetup();
            }


            //check connection

            //else
            //{
            //    Run();
            //}
        }
        public void InitialSetup() {
            
            Application.Run(new Init());
        }
        public void Run() {
            MessageBox.Show("Connecttttted.");
        }
        public void InitialConnectDatabase() { }


        public void LoadConfig()
        {
            
            string Debug = Environment.GetEnvironmentVariable("DEBUG") ?? string.Empty;
            bool debugValue;

            if (!bool.TryParse(Debug, out debugValue))
            {
                debugValue = false; // Mặc định là false nếu không chuyển đổi được
            }
            Config.Debug = debugValue;
            Config.DBHost = Environment.GetEnvironmentVariable("DB_HOST");
            Config.DBName = Environment.GetEnvironmentVariable("DB_DATABASE");
            Config.DBUser = Environment.GetEnvironmentVariable("DB_USER");
            Config.DBPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        }
    }
}
