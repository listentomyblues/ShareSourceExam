using System;
using System.IO;
					
public class Program
{
	public static void Main()
	{     
		//Input User Profile
        Console.WriteLine("User Profile: ");
        var userProfile = Console.ReadLine();
        
        //Check if length is greater than 8
        if(userProfile.Length > 8)
        {
            Console.Write("User Profile entered is greater than 8 ");
            return;
        }
        else
        {
            Console.WriteLine("Setting: ");
            var settingIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (settingIndex > 8)
            {
				Console.WriteLine("Index out of bounds error");
                return;
            }
            		
            //Check if the selected index has a value of 1
			var isEnabled = userProfile[settingIndex] == '1' ? true : false;
			Console.WriteLine("Output: " + isEnabled.ToString());
			
			Console.Write("Save User Profile?(Y/N) ");
			var userResponse = Console.ReadLine().ToUpper();
			if(userResponse == "Y")
			{
                //Check if User wants to save the settings in a file
				SaveUserProfile(userProfile);
			}
                       
       }
	}
	
	public static void SaveUserProfile(string userProfile)
	{
	  Console.Write("User: ");
      var user= Console.ReadLine();
		
	  var filePath = "FilePath"; //@"c:\path\file.txt"	
	  File.AppendAllText(filePath, user+"-"+userProfile + Environment.NewLine);
	}
}