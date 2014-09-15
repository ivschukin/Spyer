using System;

namespace Spyer.Common
{
    public static class Ensure
    {
        public static void NotNullOrEmpty(string param)
        {
            if (string.IsNullOrEmpty(param))
            {
                throw new ArgumentNullException("param");
            }
        }
    }
}