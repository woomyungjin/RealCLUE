﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class Suspect : ClueType
    {
        public static string Scarlet { get; } = nameof(Scarlet);
        public static string Mustard { get; } = "Mustard";
        public static string White { get; } = "White";
        public static string Green { get; } = "Green";
        public static string Peacock { get; } = "Peacock";
        public static string Plum { get; } = "Plum";
    }
}
