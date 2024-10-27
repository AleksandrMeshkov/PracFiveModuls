using HshPassword;
using PracFive.ModelsModifierDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Security_AgencyEntities context = HelperDB.GetContext())
            {
                // Создаем нового пользователя
                Users newUser = new Users();

                Console.WriteLine("Введите имя:");
                newUser.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                newUser.Surname = Console.ReadLine();

                Console.WriteLine("Введите отчество:");
                newUser.Patronymic = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string plainPassword = Console.ReadLine();
                newUser.Password = Hash.HashPswd(plainPassword);
                Console.WriteLine("Хэшированный пароль пользователя: " + newUser.Password);

                Console.WriteLine("Введите телефон:");
                newUser.Phone = Console.ReadLine();

                Console.WriteLine("Введите email:");
                newUser.Email = Console.ReadLine();

                
                context.Users.Add(newUser);
                context.SaveChanges();

                Console.WriteLine("Пользователь успешно добавлен в базу данных.");
                Console.ReadKey();
            }
        }
    }

}
