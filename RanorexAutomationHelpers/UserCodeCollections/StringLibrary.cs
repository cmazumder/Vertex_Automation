//
// Copyright © 2018 Ranorex All rights reserved
//

using System;
using Ranorex.Core.Testing;
using System.Text;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
    /// <summary>
    /// A collection of string helper methods.
    /// </summary>
    [UserCodeCollection]
    public static class StringLibrary
    {
        /// <summary>
        /// Concatenates two strings and returns the new string.
        /// </summary>
        /// <param name="value1">First string</param>
        /// <param name="value2">Second string</param>
        /// <returns>Concatenated string</returns>
        [UserCodeMethod]
        public static string ConcatStrings(string value1, string value2)
        {
            return String.Concat(value1, value2);
        }

        /// <summary>
        /// Creates and returns a random string.
        /// </summary>
        /// <param name="length">Length of the returned string in characters. Default = 35. Lower values increase
        /// chance of duplicate strings.</param>
        /// <returns>Random string</returns>
        [UserCodeMethod]
        public static string GetRandomString(string length = "35")
        {
            int len;
            var result = new StringBuilder(string.Empty);
            if (int.TryParse(length, out len) || len <= 0)
            {
                for (int i = 0; i <= len / 36; i++)
                {
                    result.Append(Guid.NewGuid().ToString());
                }

                return result.ToString().Substring(0, len);
            }
            else
            {
                return String.Empty; // Bad parameter doesn't deserve a string	
            }
        }

        /// <summary>
        /// Converts the string to integer 
        /// </summary>
        /// <param name="value">string value to be converted to string</param>
        /// <returns>Integer value</returns>
        [UserCodeMethod]
        public static int StringToIntConvertor(String value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                Report.Error(string.Format("'{0}' is not an Integer.", value));
                return -1;
            }
        }
    }
}
