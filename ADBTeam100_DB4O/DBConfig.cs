using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
namespace ADBTeam100_DB4O
{
    class DBConfig
    {
        public IObjectContainer db;

        public DBConfig()
        {
            db = Db4oEmbedded.OpenFile("C:\\Users\\huuva\\DB4O\\EmployeeManager.yap");
        }
    }
}
