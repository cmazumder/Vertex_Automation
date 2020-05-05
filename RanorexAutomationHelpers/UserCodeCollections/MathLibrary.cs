/*
 * Created by Ranorex
 * User: AR100829
 * Date: 4/16/2019
 * Time: 12:52 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex.Core.Testing;
using Ranorex.AutomationHelpers.UserCodeCollections;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public static class MathLibrary
    {
    	private static Random random = new Random();
    	
     	/// <summary>
     	/// Returns random number between the provided range 
     	/// </summary>
     	/// <param name="min">minium value of the number generated</param>
     	/// <param name="max">maximum value of the number generated</param>
     	/// <returns>value as string</returns>
       	[UserCodeMethod]
        public static string GenerateRandomNumber(string min, string max)
        {
        	return Convert.ToString(random.Next(StringLibrary.StringToIntConvertor(min), StringLibrary.StringToIntConvertor(max)));
        }
       
       	/// <summary>
		/// Returns the addition of two of numbers
		/// </summary>
		/// <param name="value1">value1 to be added</param>
		/// <param name="value2">value2 to be added</param>
		/// <returns>Addition of two numbers as string</returns>
        [UserCodeMethod]
        public static string AddInteger(string value1, string value2)
        {    
        	return Convert.ToString((UserCodeCollections.StringLibrary.StringToIntConvertor(value1) + 
        	                         UserCodeCollections.StringLibrary.StringToIntConvertor(value2)));
        }
        
        /// <summary>
        /// Returns the date and time as a string in the specified format. If number of days passed is greater than 0,
		/// will add those number of days to current date.
        /// </summary>
        /// <param name="NumberOfDays">The number days passed</param>
        /// <param name="expectedFormat">The format of time and date</param>
        /// <returns>The time and date as a string.</returns>
        [UserCodeMethod]
		public static string GetPostDateTimeAsString(string NumberOfDays, string expectedFormat)
		{
			System.DateTime date = Convert.ToDateTime(System.DateTime.Now.AddDays(UserCodeCollections.StringLibrary.StringToIntConvertor(NumberOfDays)));
        	return date.ToString(expectedFormat);   
        }
		
    }
}
