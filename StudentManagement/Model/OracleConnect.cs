using System;
using System.Data;
using StudentManagement.Core;
using Oracle.ManagedDataAccess.Client;
namespace StudentManagement.Model
{
    public class OracleConnect: IConnect
    {
        public string _strConnection;
        public OracleConnect(string strConnection) {
            _strConnection = strConnection;
        }

        public IDbConnection CreateConnection()
        {
            return new OracleConnection(_strConnection);
        }
    }
}
