using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Fight
    {
        static player player
        {
            get { return Program.player; }
            set { Program.player = value; }
        }

        public static void FightEnemy(enemy enemy)
        {
            Console.WriteLine($"на вас напал {enemy.Name} с уроном {enemy.Damage}, с защитой {enemy.Armor}, его здоровье {enemy.MaxHealth}");
            Console.WriteLine("нажмите enter чтобы продолжить");
            Console.ReadLine();
            Console.Clear();


        go:

            Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
            Console.WriteLine($"{player.name}: {player.health} HP");

            Console.WriteLine("1: ударить" +
                " 2: убежать");

            var key = Program.GetButton();

            if (key == ConsoleKey.D1)
            {
                enemy.Health -= Math.Max(player.damage -= enemy.Armor, 1);
            }

            else if(key == ConsoleKey.D2)
            {
                int r = Program.random.Next(1, 5);

                if (r == 2)
                {
                    Console.WriteLine("у вас получилось сбежать");
                    goto run;
                }

                else
                {
                    Console.WriteLine("у вас не получилось сбежать");
                }
            }

            else
            {
                Console.WriteLine("Несуществующая команда");
                Thread.Sleep(2000);
                Console.Clear();
                goto go;
            }

            if (enemy.Health > 0)
            {
                player.health -= Math.Max(enemy.Damage -= player.armor, 1);
            }

            if (player.health <= 0)
            {
                goto lose;
            }

            else if (enemy.Health <= 0)
            {
                goto win;
            }

            else
            {
                Console.Clear();
                goto go;
            }

        win:
            Console.Clear();
            Console.WriteLine("вы победили");
            Console.WriteLine("вы получили опыт");
            return;

        lose:
            Console.Clear();
            Console.WriteLine("вы проиграли");
            return;

        run:
            return; 
        }
    }
}
