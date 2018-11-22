using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace payroll_system
{
    class PayrollQuery
    {
        //authentication
        public LinqToSQLDataContext db = new LinqToSQLDataContext();

        public List<TUserLogin> GetUserLoginsPermission(string nameOfuser)
        {
            var query = db.ExecuteQuery<TUserLogin>(@"SELECT * FROM TUserLogin where UserName = '"+ nameOfuser + "'");
            return query.ToList();
        }
    }
}
