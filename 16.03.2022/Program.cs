using System;

namespace _16._03._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password;
            User user = new User(username);
            do
            {
                Console.WriteLine("***************************************");
                Console.Write("User Name daxil edin: ");
                username = Console.ReadLine();
                user.UserName = username;
                if (user.UserName == null)
                    Console.WriteLine("User Name uzunluqu 6 ve 25 arasi olmalidir: ");
            } while (user.UserName == null);
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("Sifrede boyuk,kicik herf ve Reqem olmalidir....");
                Console.Write("Sifreni Daxil edin: ");
                
                password = Console.ReadLine();
                user.Password = password;
                if (user.Password == null)
                    Console.WriteLine("Pasword uzunluqu 6 ve 25 arasi olmalidir(boyuk,kicik herf ve en azn bir reqem olmalidir): ");
            } while (user.Password == null);
        }
    }
}
