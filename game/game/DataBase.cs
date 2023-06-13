using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    static class DataBase
    {
        public static List<item> items;
        public static List<enemy> enemies;

        public static void Load()
        {
            items = new List<item>();
            enemies = new List<enemy>();

            items.Add(new item("бластер", 1, true));

            enemies.Add(new enemy("нечто, что, видимо было домашним любимцем кого-то мертвого колониста", 0, 20, 2, 0));
            enemies.Add(new enemy("местный голодный, судя по всему, хищник", 1, 25, 4, 1));

        }

        public static item GetItem(int ID, int count = 1)
        {
            item item = (item)items.Find(I => I.Id == ID).Clone();

            if (item != null)
            {
                if (item.stack)
                    item.count = count;
                else
                    item.count = 1;

                return item;
            }

            else
            {
                return null;
            }
        }

        public static enemy GetEnemy(int ID)
        {
            enemy enemy = (enemy)enemies.Find(E => E.ID == ID).Clone();

            if (enemy != null)
            {
                return enemy;
            }

            else
            {
                return null;
            }
        }
    }
}
