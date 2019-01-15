using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLession
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Name = "Хлеб"; //вызван set
            string itemName = item.Name; //вызван get
            Console.WriteLine(item.Name); //тоже get

            Item anotherItem = new Item
            {
                Id = 1,
                Name = "Носки",
                Price = 100,
                //CreationDate = DateTime.Now эта строчка не нужна, чтобы каждый раз при создании не дублировать код
            };

            anotherItem.ChangedDates = new DateTime[2];
            anotherItem[0] = DateTime.Now;

            int[] numbers = { 1, 2, 3, 4, 5 };
            numbers[0] = 12; //array[] - ?

            Array.Resize(ref numbers, 30);
        }
    }
}
