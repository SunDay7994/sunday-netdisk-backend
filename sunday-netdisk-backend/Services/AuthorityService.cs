﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sunday_netdisk_backend.Services
{
    public class AuthorityService
    {
        public string ProcessPath(string input)
        {
            if (input == "/") input = null;
            return Path.Combine("D:\\Test", input.Replace("/","\\"));
        }
    }
}
