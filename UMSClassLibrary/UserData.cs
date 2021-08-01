using System;

namespace UMSClassLibrary
{
    public class UserData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Occupation { get; set; }
        public string FavFood { get; set; }
        
        //encapsulating the user0ption field
        private static string userOption;
        public static string UserOption
        {
            get { return userOption; }
            set { userOption = value; }
        }
    }
}