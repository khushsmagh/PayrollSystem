﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll_system
{
    class PayrollQuery
    {
        
        public static IEnumerable<TEmployee> GetEmployeeInfo(int id)
        {
            LinqToSQLDataContext db = new LinqToSQLDataContext();
            var query = db.ExecuteQuery<TEmployee>(@"SELECT * FROM TEmployee WHERE EmployeeId = {0}", id);
            return query;
        }
       
    }
}
