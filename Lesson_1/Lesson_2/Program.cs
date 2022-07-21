namespace test3
{
    internal class Program
    {
        static int player = 1;

        static void Main(string[] args)
        {
            int w;
            string? PlayerValue;
            int ValueConversion;
            char[] mass = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"|_{mass[i]}_");
                if (i % 3 == 2)
                {
                    Console.Write("|");
                    Console.Write("\n");
                }
            }

            while (mass.Length == 9)
            {

                if (player % 2 == 0)
                {
                    Console.WriteLine("Ход игрока :0");
                }
                else
                {
                    Console.WriteLine("Ход игрока :x");
                }
                PlayerValue = Console.ReadLine();
                ValueConversion = Convert.ToInt32(PlayerValue);
                w = ValueConversion - 1;
                if (ValueConversion < 1 || ValueConversion > 9)
                {
                    Console.WriteLine("Не верная ячейка");
                }

                if (player % 2 == 0)
                {
                    Games('0', w, mass);
                }
                else
                {
                    Games('X', w, mass);
                }
                if (
                 mass[0] == 'X' & mass[1] == 'X' & mass[2] == 'X' |
                 mass[3] == 'X' & mass[4] == 'X' & mass[5] == 'X' |
                 mass[6] == 'X' & mass[7] == 'X' & mass[8] == 'X' |
                 mass[2] == 'X' & mass[4] == 'X' & mass[6] == 'X' |
                 mass[0] == 'X' & mass[4] == 'X' & mass[8] == 'X' |
                 mass[0] == 'X' & mass[3] == 'X' & mass[6] == 'X' |
                 mass[1] == 'X' & mass[4] == 'X' & mass[7] == 'X' |
                 mass[2] == 'X' & mass[5] == 'X' & mass[8] == 'X')
                {
                    Console.WriteLine("Выиграли: Х");
                    break;
                }

                if (
                 mass[0] == '0' & mass[1] == '0' & mass[2] == '0' |
                 mass[3] == '0' & mass[4] == '0' & mass[5] == '0' |
                 mass[6] == '0' & mass[7] == '0' & mass[8] == '0' |
                 mass[2] == '0' & mass[4] == '0' & mass[6] == '0' |
                 mass[0] == '0' & mass[4] == '0' & mass[8] == '0' |
                 mass[0] == '0' & mass[3] == '0' & mass[6] == '0' |
                 mass[1] == '0' & mass[4] == '0' & mass[7] == '0' |
                 mass[2] == '0' & mass[5] == '0' & mass[8] == '0')

                {
                    Console.WriteLine("Выиграли: 0");
                    break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PlayerSimbol">Подставляется символ игрока который ходит в данный момент.</param>
        /// <param name="PontNumber">Подставляется номер ячейки массива. Берется из расчета значение вводимое игроком, минус один.</param>
        /// <param name="mass">Параметр передающий значения полученые в методе массиву Main.</param>
        //Создание метода
        static void Games(char PlayerSimbol, int PontNumber, char[] mass)
        {
            if (mass[PontNumber] == 'X' | mass[PontNumber] == '0')
            {
                Console.WriteLine("Ячейка занята");
            }
            else
            {
                mass[PontNumber] = PlayerSimbol;
                player++;

            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"|_{mass[i]}_");
                if (i % 3 == 2)
                {
                    Console.Write("|");
                    Console.Write("\n");
                }
            }
        }
    }
}