using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace UMSClassLibrary
{
    public class FileSystem
    {
        //instantiating the queue class
        public static UsersQueue<string> usersqueue = new UsersQueue<string>();
        
        //declare the path to the file you want to create
        public static string filePath = "../UMSClassLibrary/Users.txt";
    
        public static async void WriteFile()
        {
            //create a file to write to
            StreamWriter writer = File.CreateText(filePath);
            await writer.DisposeAsync();

            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                string userInfo = usersqueue.Head.FirstName + "," + usersqueue.Head.LastName + "," + usersqueue.Head.Email + "," + usersqueue.Head.Country + ","  + usersqueue.Head.Occupation + "," + usersqueue.Head.FavFood;
                var temp = usersqueue.Head;
                while (temp != null)
                {
                    await streamWriter.WriteLineAsync(userInfo);
                    //streamWriter.Dispose();
                    temp = temp.Next;
                }
            }
        }

        public static async void ReadFile()
        {
            //open the file to read from
            //using (StreamReader reader = new StreamReader(filePath));
            using (StreamReader reader = File.OpenText(filePath))
            {
                var read = await reader.ReadToEndAsync();
                read = read.TrimEnd(); //trim the end to avoid trailing spaces.
                var users = read.Split(Environment.NewLine); //Ssplitting by a new line gives a string array.
                foreach (var info in users)
                {
                    var user = info.Split(',');
                    usersqueue.Enqueue(user[0], user[1], user[2], user[3], user[4], user[5]);
                }
            }
        }
    }
}


// if (!File.Exists(filePath))
//             {
//                 //create a file to write to
//                 StreamWriter streamWriteUsersFile = File.CreateText(filePath);
//                 streamWriteUsersFile.Dispose();
//             }

//             using (StreamWriter streamWriter = File.AppendText(filePath))
//             {
//                 string userInfo = $"{FirstName} {LastName} {Email} {Country} {Occupation} {FavFood}";
//                 var temp = Head;
//                 while (temp != null)
//                 {
//                     streamWriteUsers.WriteLine(userInfo);
//                     //streamWriteUsersFile.Dispose();
//                     temp = temp.Next;
//                 }
//             }