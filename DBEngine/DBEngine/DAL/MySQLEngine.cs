﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DBEngine.Entities;

namespace DBEngine.DAL
{
    public class MySQLEngine : AbsDBEngine
    {
        public MySQLEngine()
        {
            objectType = "MySQLEngine";
        }

        public override bool Connect()
        {
            throw new NotImplementedException();
        }

        public override bool isConnected()
        {
            throw new NotImplementedException();
        }

        public override IDBEngine NonQuery(string query)
        {
            throw new NotImplementedException();
        }

        public override IDBEngine Query(string query, out DataTable results)
        {
            throw new NotImplementedException();
        }
    }
}
