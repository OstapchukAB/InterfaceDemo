using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProduct prod in cart)
            {
                prod.ShipItem(customer);
                if(prod is IDigitalProduct digital)
                {
                    Console.WriteLine($"Для цифрового товара:{prod.Title} Осталось загрузок:{digital.TotalDownloadsLeft}");

                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Иван",
                LastName = "Синицин",
                City = "Бобруйск",
                EmailAddress = "ivan.sinicyn@yandex.ru",
                PhoneNumber = "+7 910-456-32-22"
            };
        }

        private static List<IProduct> AddSampleData()
        {
            List<IProduct> output = new List<IProduct>();

            output.Add(new PhysicalProductModel { Title = "Балалайка" });
            output.Add(new PhysicalProductModel { Title = "Сковорода" });
            output.Add(new PhysicalProductModel { Title = "Телевизор" });
            var Cd = new DigitalProductModel { Title = "CD-диск. Книга. Том Первый." };
            output.Add(Cd); output.Add(Cd);
            //output.Add(new DigitalProductModel { Title = "CD-диск. Книга. Том Второй." });

            return output;
        }
    }
}
