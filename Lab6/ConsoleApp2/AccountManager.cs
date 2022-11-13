using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AccountManager
    {
         public DB_account_table DB_accounts = new DB_account_table()
            .Add(new Account("YuriiAndrashko", "YuriiAndrashko@gmail.com", "YuriiAndrashkoTOP"))
            .Add(new Account("AndriiBryla", "AndriiBryla@gmail.com", "AndriiBrylaSuper"))
            .Add(new Account("MyroslavaHlebena", "MyroslavaHlebena@gmail.com", "HlebenaMyroslavaCool"));

        public Account account = null;

        public AccountManager LogIn()
        {
            if (account == null)
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();
                string password;

                Account acc = DB_accounts.GetAccounts().Find(item => item._username == username);
                if (acc != null)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("Enter password: ");
                        password = Console.ReadLine();
                        if (acc._password == password)
                        {
                            account = acc;
                            Console.WriteLine("Successfully sign in!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong password, try again.");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Wrong username, try again.");
                }
            }
            else
            {
                Console.WriteLine("Already logged");
            }
            return this;
        }

        public AccountManager LogOut()
        {
            account = null;
            Console.WriteLine("Logged out succesfully");
            return this;
        }

        public AccountManager Favorite(Anime anime)
        {
            account.favorite.Add(anime);
            return this;
        }
    }
}
