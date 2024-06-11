

namespace Record_and_static_homework
{
    internal class User
    {
        private static int _id = 0;
        public int Id { get; }
        public int MyProperty { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; init; }




        public User(string fullName, string email, string password)
        {
            Id = _id++;
            FullName = fullName;
            Email = email;
            Password = password;

        }





        public static User FindUserById(int id, User[] users)
        {
            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;

        }


        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id}-- Fullname: {FullName}-- Email: {Email}");
        }

        public static bool PasswordChecker(string str)
        {
            return PasswordLengthCkecker(str) && HasUpperLetter(str) && HasLowerLetter(str) && HasDigit(str);
        }



        static bool PasswordLengthCkecker(string str)
        {
            if (str.Length > 0)
            {
                return true;
            }

            return false;
        }

        static bool HasUpperLetter(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    return true;
                }
            }
            return false;

        }

        static bool HasLowerLetter(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                {
                    return true;
                }
            }
            return false;

        }


        static bool HasDigit(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;

        }



    }

}
