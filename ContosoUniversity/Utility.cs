#if PostgreSQL
using System;

namespace ContosoUniversity
{
    public static class Utility
    {
        public static string GetLastChars(uint token)
        {
            return token.ToString().Substring(
                                    token.ToString().Length - 3);
        }
    }
}
#else
namespace ContosoUniversity
{
    public static class Utility
    {
        public static string GetLastChars(System.Guid token)
        {
            return token[7].ToString();
        }
    }
}
#endif