namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] mass = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9'

} };
            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    Console.Write($"_{mass[i, j]}_");

                    if (i != -1 && j != -1)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("\n");
            }

            int player = 1;

            //Создание метода
            void game(char v, int z, int c)
            {
                if (mass[z, c] == 'X' | mass[z, c] == '0')
                {
                    Console.WriteLine("Ячейка занята");
                }
                else
                {
                    mass[z, c] = v;
                    player++;
                }

                for (byte i = 0; i < 3; i++)
                {
                    for (byte j = 0; j < 3; j++)
                    {
                        Console.Write($"_{mass[i, j]}_");

                        if (i != -1 && j != -1)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.Write("\n");
                }
                return;
            }


            // Игровой цикл
            for (byte k = 0; k < 10; k++)
            {

                string? y = Console.ReadLine();
                int x = Convert.ToInt32(y);
                if (x < 1 || x > 9)
                {
                    Console.WriteLine("Не верная ячейка");
                }


                //Игрок 1
                if (player % 2 != 0)

                {
                    switch (x)
                    {
                        case 1:
                            game('X', 0, 0);
                            break;
                        case 2:
                            game('X', 0, 1);
                            break;
                        case 3:
                            game('X', 0, 2);
                            break;
                        case 4:
                            game('X', 1, 0);
                            break;
                        case 5:
                            game('X', 1, 1);
                            break;
                        case 6:
                            game('X', 1, 2);
                            break;
                        case 7:
                            game('X', 2, 0);
                            break;
                        case 8:
                            game('X', 2, 1);
                            break;
                        case 9:
                            game('X', 2, 2);
                            break;
                    }
                }

                //Игрое 2

                else
                {
                    Console.WriteLine("Ход игрока 2");
                    switch (x)
                    {
                        case 1:
                            game('0', 0, 0);
                            break;
                        case 2:
                            game('0', 0, 1);
                            break;
                        case 3:
                            game('0', 0, 2);
                            break;
                        case 4:
                            game('0', 1, 0);
                            break;
                        case 5:
                            game('0', 1, 1);
                            break;
                        case 6:
                            game('0', 1, 2);
                            break;
                        case 7:
                            game('0', 2, 0);
                            break;
                        case 8:
                            game('0', 2, 1);
                            break;
                        case 9:
                            game('0', 2, 2);
                            break;
                    }

                }

                if (mass[0, 0] == 'X' && mass[0, 1] == 'X' && mass[0, 2] == 'X' ||
                    mass[1, 0] == 'X' && mass[1, 1] == 'X' && mass[1, 2] == 'X' ||
                    mass[2, 0] == 'X' && mass[2, 1] == 'X' && mass[2, 2] == 'X' ||
                    mass[0, 0] == 'X' && mass[1, 0] == 'X' && mass[2, 0] == 'X' ||
                    mass[0, 1] == 'X' && mass[1, 1] == 'X' && mass[2, 1] == 'X' ||
                    mass[0, 2] == 'X' && mass[1, 2] == 'X' && mass[2, 2] == 'X' ||
                    mass[2, 0] == 'X' && mass[1, 1] == 'X' && mass[0, 2] == 'X' ||
                    mass[0, 0] == 'X' && mass[1, 1] == 'X' && mass[2, 2] == 'X')

                    Console.WriteLine("Выиграли: Х");

                if (mass[0, 0] == '0' && mass[0, 1] == '0' && mass[0, 2] == '0' ||
                    mass[1, 0] == '0' && mass[1, 1] == '0' && mass[1, 2] == '0' ||
                    mass[2, 0] == '0' && mass[2, 1] == '0' && mass[2, 2] == '0' ||
                    mass[0, 0] == '0' && mass[1, 0] == '0' && mass[2, 0] == '0' ||
                    mass[0, 1] == '0' && mass[1, 1] == '0' && mass[2, 1] == '0' ||
                    mass[0, 2] == '0' && mass[1, 2] == '0' && mass[2, 2] == '0' ||
                    mass[2, 0] == '0' && mass[1, 1] == '0' && mass[0, 2] == '0' ||
                    mass[0, 0] == '0' && mass[1, 1] == '0' && mass[2, 2] == '0')

                    Console.WriteLine("Выиграли: 0");


            }

        }
    }
}