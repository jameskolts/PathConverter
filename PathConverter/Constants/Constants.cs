﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PathConverter
{
    public class Constants
    {
        public static class Keypaths
        {
            public const char UP = 'U';
            public const char DOWN = 'D';
            public const char LEFT = 'L';
            public const char RIGHT = 'R';
            public const char SPACE = 'S';
            public const char SELECT = '*';
        }
               
        public static class FilePaths 
        {
            public const string LOG = @"C:\temp\PathConvertLog.txt";
            public const string TESTINPUT = @"C:\Users\jkolt\source\repos\PathConverter\PathConverter\Files\input.txt";
        }

    }
}
