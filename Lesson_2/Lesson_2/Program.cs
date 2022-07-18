namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка массива.
            Console.WriteLine("TikTacToe");
            char[,] mass = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };          
            int player = 1;
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
            // Сама игра.
            for (byte k = 0; k < 10; k++)
            {
                if (player % 2 != 0)
                {
                    Console.WriteLine("Ход первого игрока: ");
                }
                else
                {
                    Console.WriteLine("Ход второго игрока: ");
                }

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
                            if (mass[0, 0] == 'X' | mass[0, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 0] = 'X';
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
                             break;

                        case 2:
                            if (mass[0, 1] == 'X' | mass[0, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 1] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 3:
                            if (mass[0, 2] == 'X' | mass[0, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 2] = 'X';
                                player++;
                            }
                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 4:
                            if (mass[1, 0] == 'X' | mass[1, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 0] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 5:
                            if (mass[1, 1] == 'X' | mass[1, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 1] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 6:
                            if (mass[1, 2] == 'X' | mass[1, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 2] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 7:
                            if (mass[2, 0] == 'X' | mass[2, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 0] = 'X';
                                player++;
                            }
                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 8:
                            if (mass[2, 1] == 'X' | mass[2, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 1] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 9:
                            if (mass[2, 2] == 'X' | mass[2, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 2] = 'X';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;      
                    }                   
                }                
                //Игрок_2
                else
                if (player % 2 == 0)
                {
                   
                    switch (x)
                    {

                        case 1:
                            if (mass[0, 0] == 'X' | mass[0, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 0] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;

                        case 2:
                            if (mass[0, 1] == 'X' | mass[0, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 1] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 3:
                            if (mass[0, 2] == 'X' | mass[0, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[0, 2] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 4:
                            if (mass[1, 0] == 'X' | mass[1, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 0] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 5:
                            if (mass[1, 1] == '0' | mass[1, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 1] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 6:
                            if (mass[1, 2] == 'X' | mass[1, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[1, 2] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 7:
                            if (mass[2, 0] == 'X' | mass[2, 0] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 0] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 8:
                            if (mass[2, 1] == 'X' | mass[2, 1] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 1] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
                            break;
                        case 9:
                            if (mass[2, 2] == 'X' | mass[2, 2] == '0')
                            {
                                Console.WriteLine("Ячейка занята");
                            }
                            else
                            {
                                mass[2, 2] = '0';
                                player++;
                            }

                            for (byte i = 0; i < 3; i++)
                            {
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.Write($"_{mass[i, j]}_");

                                    if (i != -1 && j != -1)
                                        Console.Write("|");
                                }
                                Console.Write("\n");
                            }
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