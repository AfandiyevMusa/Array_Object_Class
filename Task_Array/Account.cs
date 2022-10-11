using System;
namespace Task_Array
{
    public class Account
    {
           public string Login(string username, string password)
           {
                if (username == "cavid123" && password == "Cavid1993")
                {
                    return "Girish ugurludur!";
                }
                else
                {
                    return "Daxil edilen mail ve ya password sehvdir";
                }
           }
    }
}

