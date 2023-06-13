using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using game;

class Program
{
    public static player player;
    public static Random random;


    static void Main(string[] args)
    {
        random = new Random();
        player = new player();
        DataBase.Load();

    go:
        Console.Clear();
        Console.WriteLine("1: играть");
        Console.WriteLine("2: загрузить");
        Console.WriteLine("3: выйти");

        ConsoleKey key = GetButton();

        Console.Clear();


        if (key == ConsoleKey.D1)
        {
            Console.WriteLine("введите имя");

            player.name = Console.ReadLine();

            Game();


        }

        else if (key == ConsoleKey.D2)
        {
            Console.WriteLine("сохранений нет. нажмете лишнюю кнопку и все по новой.");
        }

        else if (key == ConsoleKey.D3)
        {
            Console.WriteLine("натыкай лишнего вот и выйдешь.");
        }

        else
        {
            Console.WriteLine("Несуществующая команда");
            Thread.Sleep(2000);
            goto go;
        }


    }

    public static void Game()
    {
        Console.Clear();

        Console.WriteLine("Ты космический исследователь, который прибыл на отдаленную планету вместе со своей командой. ");
        Console.WriteLine("Прибыв на эту планету, вы обнаруживаете, что есть старая колония, которая была заброшена несколько лет назад.");
        Console.WriteLine("Вы начинаете исследовать эту колонию, пока не обнаруживаете, что она была заброшена не случайно.");
        Console.WriteLine("В колонии произошла утечка опасного вируса, который уничтожил всех, кто тут жил. ");
        Console.WriteLine("Вы понимаете, что вам нужно собрать инструменты и оборудование, чтобы выжить на этой планете и выяснить, что произошло с колонистами.");
        Console.WriteLine(" В процессе вы находите дневники колонистов, которые помогают раскрыть тайну вируса.");

        Console.WriteLine("Однако, твои напарники начинают падать один за другим и ты понимаешь, что вирус еще сильнее, чем ты думал. ");
        Console.WriteLine("К тому же ты заметил, что кто-то собирается использовать вирус в качестве оружия против сильнейших Галактик.");
        Console.WriteLine("Твоей задачей будет найти лекарство от вируса, которое должно быть спрятано в глубоких пещерах планеты, а так же выяснить, кто собирается использовать вирус как оружие.");
        Thread.Sleep(50000);

    go:

        Console.Clear();
        Console.WriteLine("1: информация" +
            " 2: инвентарь" +
            " 3: исследовать" +
            " 4: охота");
        ConsoleKey key = GetButton();

        if (key == ConsoleKey.D1)
        {
            Console.WriteLine($"имя: {player.name}");
            Console.WriteLine($"жизни: {player.health}/{player.healthMax}");
           // Console.WriteLine($"стамина: {player.power}/{player.powerMax}");
            Console.WriteLine("нажмите любую кнопку");
            Console.ReadKey();
         goto go;
        }

        else if (key == ConsoleKey.D2)
        {
            player.inventory.GetAllItems();
        }

        else if (key == ConsoleKey.D3)
        {
              //  if (player.power > 0)
               // {
                //    player.power--;
                    explore();
              //  }

               /* else
                {
                    Console.WriteLine("вы устали");
                } */
        } 

        else if (key == ConsoleKey.D4)
        {
            Fight.FightEnemy(DataBase.GetEnemy(0));
        }

        else
        {
           Console.WriteLine("Несуществующая команда");
           Thread.Sleep(2000);
           goto go;
        }

            Console.WriteLine("нажмите на любую кнопку чтобы продолжить");
            Console.ReadKey();
            goto go;

    }

        public static void explore()
        {
            int ran = random.Next(0, 100);

            if (ran <= 5)
            {
                Console.WriteLine("вы нашли пещеру");
            }

            else if (ran <= 20)
            {
                Console.WriteLine("вы нашли дневник. некоторые страницы утеряны, похоже, это все что удастся прочесть.");
                Console.WriteLine("День 1: Сегодня мы приземлились на новую планету и начали осваивать нашу колонию."); 
                Console.WriteLine("Уже начали растить некоторые овощи и фрукты, а также наладили систему очистки воды.");
                Console.WriteLine("День 4: Нашли необитаемый корпус космического корабля и обнаружили в нем некоторые полезные инструменты и запчасти.");
                Console.WriteLine("Нам удалось восстановить нашу электросеть и расширить наш экспериментальный тепличный комплекс.");
            }

            else if (ran <= 21)
            {
                Console.WriteLine("вы нашли дневник. некоторые страницы утеряны, похоже, это все что удастся прочесть.");
                Console.WriteLine("День 12: Начали исследование околопланетных ресурсов и обнаружили большой запас полезных металлов.");
                Console.WriteLine("Уже начали создавать свою собственную мастерскую для производства инструментов и оборудования.");
                Console.WriteLine("День 19: Нашли следы живых существ на этой планете и решили их изучить.");
                Console.WriteLine("Оказалось, что это инопланетные животные с необычной структурой тела. ");
                Console.WriteLine("Изучаем их поведение и адаптируем свои меры безопасности.");
            }

            else if (ran <= 30)
            {
                Console.WriteLine("вы нашли дневник. некоторые страницы утеряны, похоже, это все что удастся прочесть.");
                Console.WriteLine("День 27: Некоторые инженеры нашей колонии разработали новые разведывательные дроны, ");
                Console.WriteLine("которые могут быстро и эффективно осматривать большие территории в поиске новых ресурсов и опасностей.");
                Console.WriteLine("День 35: Борьба с некоторыми вредителями и насекомыми продолжается. ");
                Console.WriteLine("Наши усилия по сбору и анализу данных помогли нашим биологам разработать несколько эффективных инсектицидов.");
            }

            else if (ran <= 14)
            {
                Console.WriteLine("вы нашли дневник. некоторые страницы утеряны, похоже, это все что удастся прочесть.");
                Console.WriteLine("День 42: Мы уже начали строительство аэропорта нашей колонии, ");
                Console.WriteLine("чтобы увеличить скорость перемещения и расширить наши контакты с другими колониями на этой планете.");
                Console.WriteLine("День 50: Нашли потенциально опасный вирус в нашей водной системе, ");
                Console.WriteLine("но благодаря быстрой реакции нашей медицинской команды нам удалось предотвратить любую эпидемию.");
            }

            else if (ran <= 14)
            {
                Console.WriteLine("вы нашли кристалл");
            }

             else if (ran <= 5)
            {
                Console.WriteLine("вы наткнулись на страшное существо, и, не успев его разглядеть, умерли.");
            }


            else
            {
                Console.WriteLine("вы ничего не нашли");
            }

        }


        public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey(true).Key;

            return but;
        }
}