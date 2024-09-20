using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core
{
    public interface IConnect
    {
        IDbConnection CreateConnection();
    }
}
