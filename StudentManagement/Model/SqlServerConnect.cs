using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Core;
using Microsoft.Data.SqlClient;

namespace StudentManagement.Model
{
    public class SqlServerConnect: IConnect
    {
        public readonly string _strConnection;
        public SqlServerConnect(string strConnection) {
            _strConnection = strConnection;
        }
        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_strConnection);
        }
    }
}
