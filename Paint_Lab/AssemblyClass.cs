﻿using System.Reflection;

namespace Paint_Lab
{
    public static class AssemblyClass
    {
        public static Assembly ConnectAsm(string path)
        {
            var assembly = Assembly.LoadFrom($"{path}");
            return assembly;
        }
    }
}