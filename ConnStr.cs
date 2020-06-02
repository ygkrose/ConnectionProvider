using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;

namespace ConnectionProvider
{
    public class ConnStr : DBInfo
    {

        string _dbconnection = "";
        public override string DBConnection 
        { 
            get { return _dbconnection; } 
            set { _dbconnection = ConnSecure.Encrypt(value); } 
        }

        string _redisstr = "";
        public override string RedisConnStr
        {
            get { return _redisstr; }
            set { _redisstr = ConnSecure.Encrypt(value); }
        }


    }
}
