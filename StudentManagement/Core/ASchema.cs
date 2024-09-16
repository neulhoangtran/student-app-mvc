using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace StudentManagement.Core
{
    public abstract class ASchema
    {
        protected OracleConnection _conn;
        protected ASchema(OracleConnection conn) { 
            _conn = conn;
        }
        public void Execute()
        {
            string sql = CreateTable();
            using (OracleCommand cmd = new OracleCommand(sql, _conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
            }

        }
        protected abstract string CreateTable();
    }
}
