﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGP.WebOperation.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            BilibiliHomePageVideoTitleGetter getter = new BilibiliHomePageVideoTitleGetter();
            getter.TryGetTitles();
        }
    }
}
