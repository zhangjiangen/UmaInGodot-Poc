﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace MockUnityScripts
{
    public static class Debug
    {
        public static bool isDebugBuild
        {
            get
            {
                return true;
            }
        }

        public static void Log(string message)
        {
            GD.Print(message);
        }

        public static void LogError(string message)
        {
            GD.Print(message);
        }

        public static void LogWarning(string message)
        {
            GD.Print(message);
        }
    }
}