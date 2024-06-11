
using Record_and_static_homework;

User[] users = new User[3];

string[] availableCommands = { "Quit", "Show all students", "Get info by id" };

int userCommand;
bool isTerminateApp = false;


for (int i = 0; i < users.Length; i++)
{

   Console.WriteLine("Please enter user data");

  Console.Write("Full Name - ");
   string fullName = Console.ReadLine();

   Console.Write("Email - ");
   string email = Console.ReadLine();

   Console.Write("Full Name - ");
   string password = Console.ReadLine();


   if (User.PasswordChecker(password))
  {
       users[i] = new Student(fullName, email, password);
   }
}


while (isTerminateApp)
{

    Console.WriteLine("Select available commands");
    int index = 0;
    while (index < users.Length)
    {
        if (index == 0)
        {
            Console.WriteLine("Quit:");
            Console.WriteLine("*" + index);



        }
        if (index == 1)
        {
            Console.WriteLine("Show all students:");
            Console.WriteLine("*" + index);



        }
        if (index == 2)
        {
            Console.WriteLine("Get info by ids:");
            Console.WriteLine("*" + index);



        }
        index++;

    }

    Console.Write("Enter Command: ");
    userCommand = int.Parse(Console.ReadLine());

    if (userCommand == 0)
    {
        isTerminateApp = true;

    }
    if (userCommand == 1)
    {
        foreach (User user in users)
        {

            user.GetInfo();

        }
    }

    if (userCommand == 2)
    {
        int id = int.Parse(Console.ReadLine());

        User searchedUser = User.FindUserById(id, users);


        if (searchedUser != null)
        {

            searchedUser.GetInfo();
        }

        else
        {
            Console.WriteLine("User not found");
        }




    }

}