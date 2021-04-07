/*
 * For sweety GitHub and people
 */
using static System.Console;
namespace ConsoleInventory
{
   class Init
    {
        static void Main()
        {
            while (true)
            {
                WriteLine("Введите количество ячеек слева направо");
                string fakeorwha = ReadLine();
                int x;
                int.TryParse(fakeorwha, out x);
                //WriteLine(x);
                x = x > 0 ? x : x + 1;
                WriteLine("Введите количество ячеек сверху вниз");
                fakeorwha = ReadLine();
                int y;
                int.TryParse(fakeorwha, out y);
                y = y > 0 ? y : y + 1;
                string str = "";
                for (int i = 1; i < (y + 1); i++)
                {
                    for (int d = 1; d < (x + 1); d++)
                    {
                        str += "[]";
                    }
                    str += "\n";
                }
                WriteLine(str);
                WriteLine("Размер инвентаря: {0} ячеек\n",x*y);
            }
        }
    }
}
