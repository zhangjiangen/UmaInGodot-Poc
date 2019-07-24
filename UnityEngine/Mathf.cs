﻿using System;


namespace UnityEngine
{
    public static class Mathf
    {
        private static float Epsilon = 0.0001f;
        public static bool Approximately(float a, float b)
        {
            if (a >= b - Epsilon && a <= b + Epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float Round (float f)
        {
            var toDouble = System.Convert.ToDouble(f);
            toDouble = Math.Round(toDouble);
            return (float)toDouble;
        }

        public static float Abs(float f)
        {
            var toDouble = Convert.ToDouble(f);
            toDouble = Math.Abs(toDouble);
            return (float) toDouble;
        }

        public static int Abs(int i)
        {
            return Math.Abs(i);
        }

        public static float Clamp(float value, float min, float max)
        {
            if(value > max)
            {
                return max;
            }
            if(value < min)
            {
                return min;
            }
            return value;
        }

        public static float Clamp01(float weight)
        {
            return Clamp(weight, 0.0f, 1.0f);
        }

        public static int FloorToInt(float f)
        {
            return (int)Math.Floor(f);
        }

        public static int Min(int n1, int n2)
        {
            if (n1 < n2)
            {
                return n1;
            }

            return n2;
        }
        public static int Max(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }

            return n2;
        }
    }
}
