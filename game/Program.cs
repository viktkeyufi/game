using System;
using System.Collections.Generic;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Inventor> inventory = new List<Inventor>()
            {
                new("edin", 1),
                new("edin", 2),
                new("edin", 3),
                new("edin", 4),
                new("edin", 5)

            };

            InventorInfo();

            void InventorInfo()
            {
                foreach (var invent in inventory)
                {
                    Console.WriteLine($"{invent._id},{invent.Name}, {invent.Count}");
                }
            }

            void InventorDelete()
            {
                Console.WriteLine("Выберите предмет, который хотите выбросить" +
                    "!его нельзя будет вернуть!");

                int delobject = int.Parse(Console.ReadLine());

                foreach(var invent in inventory)
                {
                    if(invent._id == delobject)
                    {
                        inventory.Remove(invent);
                        break;
                    }
                }
            }

            void InventorAdd(string nameitem, int amount)
            {
                Console.WriteLine($"Вам выпал {nameitem} в количестве {amount}. Хотите его подобрать?" +
                    $"Y(es)/N(o)");

                if()
            }


        }
    }
}
