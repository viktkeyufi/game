using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class player
    {
        public string name;
        public int health, healthMax;
        public int power, powerMax;
        public int damage;
        public int armor;
        public inventory inventory;

        public player()
        {
            inventory = new inventory();
           

            healthMax = 20;
            powerMax = 10;
            damage = 5;
            armor = 1;
            health = healthMax;
            power = powerMax;


        }
    }

    class inventory
    {
        public List<item> items = new List<item>();

        public void AddItem(item item)
        {
            if(items.Count > 0)
                for (int i = 0; i < items.Count; i++)
                {
                    if (item.Id == items[i].Id && items[i].stack)
                    {
                        items[i].count += item.count;
                        break;
                    }
                    else if(i == items.Count - 1)
                    {
                        items.Add(item);
                        break;
                    }
                }
            else
              items.Add(item); 
            
        }

        public void GetAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i].name}, количсество: {items[i].count}");
            }
        }
    }
}
