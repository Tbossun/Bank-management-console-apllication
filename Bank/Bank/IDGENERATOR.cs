﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class IDGENERATOR
    {
        //taking system date to create an id for an account holder
        static int id = 01;
        string storeId;
        DateTime date = DateTime.Now;
       
        public string generate()
        {
            string gid = DateTime.Now.ToString("yyyyMM");
            storeId = gid + ++id;
            //Console.Write(gid+ ++id);
            return storeId;
            
        }
        
    }
}
