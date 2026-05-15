using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGitHubActions.Library
{
    public static class Info
    {
        public static string GetOS()
        {
            return Environment.OSVersion.ToString();
        }
    }
}
