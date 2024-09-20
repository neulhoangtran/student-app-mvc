using System;
using StudentManagement.Core;

namespace StudentManagement.Model
{
    public static class DatabaseFactory
    {
        public static IConnect CreateDatabase(string type)
        {
            string test = "";
            switch (type.ToLower()) {
                case "oracle":
                    return new OracleConnect(test);
                case "sqlserver":
                default:
                    return new SqlServerConnect(test);
            }
        }
    }
}
