using System;

class Program
{
    static void task1()
    {
        Console.WriteLine("Enter the size of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] array1D = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array1D[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements not divisible by 3 and 2:");
        for (int i = 0; i < n; i++)
        {
            if (array1D[i] % 3 != 0 && array1D[i] % 2 != 0)
            {
                Console.WriteLine($"Element Index: {i}, Element Value: {array1D[i]}");
            }
        }

        // Конвертуємо одновимірний масив у двовимірний
        int[,] array2D = new int[1, n];
        for (int i = 0; i < n; i++)
        {
            array2D[0, i] = array1D[i];
        }

        Console.WriteLine("Elements not divisible by 3 and 2 (using two-dimensional array):");
        for (int i = 0; i < n; i++)
        {
            if (array2D[0, i] % 3 != 0 && array2D[0, i] % 2 != 0)
            {
                Console.WriteLine($"Element Index: {i}, Element Value: {array2D[0, i]}");
            }
        }
    }

    static void task2()
    {
            Console.WriteLine("Enter the size of the array:");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            Console.WriteLine("Enter the sequence of numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            double maxAbsolute = array[0]; // Припускаємо, що перший елемент - максимальний за модулем

            // Шукаємо максимум за модулем серед всіх елементів
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(maxAbsolute))
                {
                    maxAbsolute = array[i];
                }
            }

            Console.WriteLine($"Maximum absolute value: {Math.Abs(maxAbsolute)}");
        }


    static void task3()
    {
            Console.WriteLine("Enter the size of the square matrix:");
            int n = int.Parse(Console.ReadLine());

            // Ініціалізувати матрицю A
            int[,] A = new int[n, n];
            Console.WriteLine("Enter the elements of the matrix A:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Ініціалізувати вектор X
            int[] X = new int[n];
            Console.WriteLine("Enter the elements of the vector X:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                X[i] = int.Parse(Console.ReadLine());
            }

            //  A * X
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += A[i, j] * X[j];
                }
                result[i] = sum;
            }

            Console.WriteLine("Result of A * X:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: {result[i]}");
            }
        }


    static void task4()
    {
        Console.WriteLine("Enter the number of rows in the array:");
        int n = int.Parse(Console.ReadLine());

        // Ініціалізувати масив
        int[][] array = new int[n][];

        // Вводимо елементи для кожного рядка
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter the number of elements in row {i + 1}:");
            int mj = int.Parse(Console.ReadLine());

            array[i] = new int[mj]; // Ініціалізувати масив рядків mj елементами

            Console.WriteLine($"Enter elements for row {i + 1}:");
            for (int j = 0; j < mj; j++)
            {
                Console.Write($"Element {j + 1}: ");
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Ініціалізувати вектор X
        Console.WriteLine("Enter the number of elements in vector X:");
        int XLength = int.Parse(Console.ReadLine());
        int[] X = new int[XLength];

        Console.WriteLine("Enter elements for vector X:");
        for (int i = 0; i < XLength; i++)
        {
            Console.Write($"Element {i + 1}: ");
            X[i] = int.Parse(Console.ReadLine());
        }

        // Замінити непарні рядки вектором X
        for (int i = 0; i < n; i += 2) // Пропускаємо кожен другий ряд
        {
            array[i] = X;
        }

        Console.WriteLine("Modified array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static double SquareOfProduct(double num1, double num2)
    {
        return num1 * num1 * num2 * num2;
    }


    static void Main()
    {
        Console.WriteLine("Lab 1 !");
        Console.WriteLine("Please input task");
        Console.Write("n=");

        byte n = byte.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: task1(); break;
            case 2: task2(); break;
            case 3: task3(); break;
            case 4: task4(); break;

        }
    }
}
