using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftFTPadminTool
{
    public static class Util
    {
        public static string GetLastWordOfString(string token)
        {
            string[] words = token.Split('=');

            return words[words.Length - 1].Trim();
        }
    }
}
