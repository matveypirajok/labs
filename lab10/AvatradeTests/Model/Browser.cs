﻿using AvatradeTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatradeTests.Model
{
    class Browser
    {
        string _browserName = "";
        static List<string> parametrs = new List<string>();

        public string BrowserName
        {
            get
            {
                return _browserName;
            }
            set
            {
                _browserName = value;
            }
        }

        public List<string> StartParametrs
        {
            get => parametrs;
            set => parametrs = value;
        }
    }
}
