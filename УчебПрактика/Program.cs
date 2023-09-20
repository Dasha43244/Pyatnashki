//int[] num = new int[4];
//Random random = new Random();
//for (int i = 0; i < num.Length; i++)
//    num[i] = random.Next(10);

//for (int i = 0; i < num.Length; i++)

//{
//    Console.Write(num[i] + " ");
//}

//Console.WriteLine("Введите число ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число ");
//int b = Convert.ToInt32(Console.ReadLine());
//int index1 = 0, index2 = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] == a)
//    {
//        index1 = i;
//    }
//    if (num[i] == b)
//    {
//        index2 = i;
//        break;
//    }
//}
//int cnt = num[index1];
//num[index1] = num[index2];
//num[index2] = cnt;

//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write(num[i] + " ");
//}




//Random random = new Random();

//int[] randomArray = new int[4];

//for (int i = 0; i < randomArray.Length; i++)
//{
//    int randomNumber;
//    bool isDuplicate;
//    do
//    {

//        randomNumber = random.Next(1, 10);

//        isDuplicate = randomArray.Contains(randomNumber);
//    } while (isDuplicate);

//    randomArray[i] = randomNumber;
//}

//foreach (int number in randomArray)
//{
//    Console.Write(number + "\t");
//}
//Console.WriteLine("Введите число ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число ");
//int b = Convert.ToInt32(Console.ReadLine());
//int index1 = 0, index2 = 0;
//for (int i = 0; i < randomArray.Length; i++)
//{
//    if (randomArray[i] == a)
//    {
//        index1 = i;
//    }
//    if (randomArray[i] == b)
//        if (randomArray[i] == b)
//        {
//            index2 = i;
//            break;
//        }
//}
//int cnt = randomArray[index1];
//randomArray[index1] = randomArray[index2];
//randomArray[index2] = cnt;

//for (int i = 0; i < randomArray.Length; i++)
//{
//    Console.Write(randomArray[i] + " ");
//}







//using System;

//int[,] m = new int[4, 4];
//Random random = new Random();

//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        m[i, j] = random.Next(0, 10);
//        Console.Write(m[i, j] + " ");
//    }
//}

//Console.Write("строка");
//int p1 = int.Parse(Console.ReadLine());
//Console.Write("столбец");
//int p2 = int.Parse(Console.ReadLine());
//if (p1 < 0 || p1 > 2 || p2 < 0 || p2 > 2)
//{
//    return;
//}
//int cnt = m[p1, p2];
//m[p1, p2] = m[p2, p1];
//m[p2, p1] = cnt;
//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write(m[i, j] + " ");
//    }
//}



//using System;

//class Program
//{
//    static int[,] gameBoard = new int[4, 4];


//    static void Main(string[] args)
//    {

//        InitializeGame();
//        ShuffleBoard();
//        PrintBoard();

//        while (!IsGameOver())
//        {
//            Console.Write("Введите цифру, которую хотите переместить: ");
//            if (int.TryParse(Console.ReadLine(), out int number))
//            {
//                if (IsValidNumber(number))
//                {
//                    MoveNumber(number);
//                    PrintBoard();
//                }
//                else
//                {
//                    Console.WriteLine("Недопустимая цифра. Попробуйте еще раз.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру.");
//            }
//        }

//        Console.WriteLine("Поздравляем! Вы выиграли!");
//    }

//    static void InitializeGame()
//    {
//        int counter = 1;
//        for (int row = 0; row < 4; row++)
//        {
//            for (int col = 0; col < 4; col++)
//            {
//                gameBoard[row, col] = counter++;
//            }
//        }
//        gameBoard[3, 3] = 0; // Пустая ячейка обозначается нулем
//    }

//    static void ShuffleBoard()
//    {
//        Random random = new Random();

//        for (int i = 0; i < 1000; i++)
//        {
//            int randomMove = random.Next(1, 5);

//            switch (randomMove)
//            {
//                case 1: MoveLeft(); break;
//                case 2: MoveRight(); break;
//                case 3: MoveUp(); break;
//                case 4: MoveDown(); break;
//            }
//        }
//    }

//    static void PrintBoard()
//    {
//        Console.Clear();
//        Console.WriteLine("Игра Пятнашки");
//        Console.WriteLine();

//        for (int row = 0; row < 4; row++)
//        {
//            for (int col = 0; col < 4; col++)
//            {
//                int number = gameBoard[row, col];
//                if (number == 0)
//                {
//                    Console.Write(" ");
//                }
//                else
//                {
//                    Console.Write($"{number:D2} ");
//                }
//            }
//            Console.WriteLine();
//        }
//    }

//    static bool IsGameOver()
//    {
//        int counter = 1;
//        for (int row = 0; row < 4; row++)
//        {
//            for (int col = 0; col < 4; col++)
//            {
//                if (gameBoard[row, col] != counter && counter != 16)
//                {
//                    return false;
//                }
//                counter++;
//            }
//        }
//        return true;
//    }

//    static bool IsValidNumber(int number)
//    {
//        return number >= 1 && number <= 15;
//    }

//    static void MoveNumber(int number)
//    {
//        int numberRow = -1;
//        int numberCol = -1;
//        int emptyRow = -1;
//        int emptyCol = -1;

//        for (int row = 0; row < 4; row++)
//        {
//            for (int col = 0; col < 4; col++)
//            {
//                if (gameBoard[row, col] == number)
//                {
//                    numberRow = row;
//                    numberCol = col;
//                }
//                else if (gameBoard[row, col] == 0)
//                {
//                    emptyRow = row;
//                    emptyCol = col;
//                }
//            }
//        }

//        if (IsAdjacent(numberRow, numberCol, emptyRow, emptyCol))
//        {
//            gameBoard[emptyRow, emptyCol] = number;
//            gameBoard[numberRow, numberCol] = 0;
//        }
//        else
//        {
//            Console.WriteLine("Вы не можете переместить эту цифру.");
//        }
//    }

//    static bool IsAdjacent(int row1, int col1, int row2, int col2)
//    {
//        return Math.Abs(row1 - row2) + Math.Abs(col1 - col2) == 1;
//    }

//    static void MoveLeft()
//    {
//        int emptyCol = 3;
//        int emptyRow = 3;

//        for (int col = 0; col < 4; col++)
//        {
//            if (gameBoard[emptyRow, col] == 0)
//            {
//                emptyCol = col;


//                break;
//            }
//        }
//        if (emptyCol > 0)
//        {
//            gameBoard[emptyRow, emptyCol] = gameBoard[emptyRow, emptyCol - 1];
//            gameBoard[emptyRow, emptyCol - 1] = 0;
//        }
//    }

//    static void MoveRight()
//    {
//        int emptyCol = 3;
//        int emptyRow = 3;

//        for (int col = 0; col < 4; col++)
//        {
//            if (gameBoard[emptyRow, col] == 0)
//            {
//                emptyCol = col;
//                break;
//            }
//        }

//        if (emptyCol < 3)
//        {
//            gameBoard[emptyRow, emptyCol] = gameBoard[emptyRow, emptyCol + 1];
//            gameBoard[emptyRow, emptyCol + 1] = 0;
//        }
//    }

//    static void MoveUp()
//    {
//        int emptyCol = 3;
//        int emptyRow = 3;

//        for (int row = 0; row < 4; row++)
//        {
//            if (gameBoard[row, emptyCol] == 0)
//            {
//                emptyRow = row;
//                break;
//            }
//        }

//        if (emptyRow > 0)
//        {
//            gameBoard[emptyRow, emptyCol] = gameBoard[emptyRow - 1, emptyCol];
//            gameBoard[emptyRow - 1, emptyCol] = 0;
//        }
//    }

//    static void MoveDown()
//    {
//        int emptyCol = 3;
//        int emptyRow = 3;

//        for (int row = 0; row < 4; row++)
//        {
//            if (gameBoard[row, emptyCol] == 0)
//            {
//                emptyRow = row;
//                break;
//            }
//        }

//        if (emptyRow < 3)
//        {
//            gameBoard[emptyRow, emptyCol] = gameBoard[emptyRow + 1, emptyCol];
//            gameBoard[emptyRow + 1, emptyCol] = 0;
//        }
//    }
//}

















using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[,] matrix = new int[4, 4];
        int[] numbers = new int[16];

        // Инициализируем массив числами от 1 до 15
        for (int i = 0; i < 15; i++)
        {
            numbers[i] = i + 1;
        }

        // Перемешиваем массив
        for (int i = 0; i < 14; i++)
        {
            int j = random.Next(i, 15);
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        // Заполняем двумерный массив случайными неповторяющимися числами по вертикали и горизонтали
        int index = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix[row, col] = numbers[index];
                index++;
            }
        }

        // Заменяем нули на -1 для представления пустого места
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (matrix[row, col] == 0)
                {
                    matrix[row, col] = -1;
                }
            }
        }

        // Выводим начальное состояние игрового поля
        PrintMatrix(matrix);

        int movesLeft = 1000000; // Количество доступных перемещений

        while (movesLeft > 0)
        {
            
            // Считываем ввод пользователя
            Console.WriteLine("Введите");
            int blockNumber = int.Parse(Console.ReadLine());
Console.Clear();
            if (blockNumber == 0)
            {
                int zeroRow = -1;
                int zeroCol = -1;

                // Находим позицию блока "ноль" (пустой ячейки) в матрице
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        if (matrix[row, col] == -1)
                        {
                            zeroRow = row;
                            zeroCol = col;
                            break;
                        }
                    }
                    if (zeroRow != -1)
                    {
                        break;
                    }
                }

                if (zeroRow == -1)
                {
                    Console.WriteLine("нет пустой ячейки");
                    continue; // Пропускаем итерацию цикла и продолжаем ввод
                }

                // Находим позицию блока, который нужно переместить
                int blockRow = zeroRow;
                int blockCol = zeroCol;

                // Перемещаем блок "ноль" на пустую ячейку
                matrix[zeroRow, zeroCol] = matrix[blockRow, blockCol];
                matrix[blockRow, blockCol] = -1;
            }
            else
            {
                // Находим позицию блока в матрице
                int blockRow = -1;
                int blockCol = -1;

                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        if (matrix[row, col] == blockNumber)
                        {
                            blockRow = row;
                            blockCol = col;
                            break;
                        }
                    }
                    if (blockRow != -1)
                    {
                        break;
                    }
                }

                if (blockRow == -1)
                {
                    Console.WriteLine("Продолжаем");
                    continue; // Пропускаем итерацию цикла и продолжаем ввод
                }

                // Перемещаем блок на пустую ячейку (блок "ноль")
                int zeroRow = -1;
                int zeroCol = -1;

                // Находим позицию блока "ноль" (пустой ячейки) в матрице
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 4; col++)
                    {
                        if (matrix[row, col] == -1)
                        {
                            zeroRow = row;
                            zeroCol = col;
                            break;
                        }
                    }
                    if (zeroRow != -1)
                    {
                        break;
                    }
                }

                if (zeroRow == -1)
                {
                    Console.WriteLine("нет пустой ячейки");
                    continue; // Пропускаем итерацию цикла и продолжаем ввод
                }

                // Перемещаем блок на пустую ячейку
                matrix[zeroRow, zeroCol] = blockNumber;
                matrix[blockRow, blockCol] = -1;
            }

            movesLeft--;

            // Выводим обновленное состояние игрового поля
            PrintMatrix(matrix);

            // Проверяем на выигрыш
            if (CheckWinCondition(matrix))
            {
                Console.WriteLine("Вы выиграли!");
                break;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (matrix[row, col] == -1)
                {
                    Console.Write("0\t");
                }
                else
                {
                    Console.Write(matrix[row, col] + "\t");
                }
            }
            Console.WriteLine();
        }
    }

    static bool CheckWinCondition(int[,] matrix)
    {
        int expectedValue = 1;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (matrix[row, col] != -1)
                {
                    if (matrix[row, col] != expectedValue)
                    {
                        return false; // Не все числа идут по порядку
                    }
                    expectedValue++;
                }
            }
        }
        return true; // Все числа идут по порядку
    }
}
