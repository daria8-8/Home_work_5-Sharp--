void Ex34()
{
    Console.WriteLine("Введите размер массива:  ");
    int len = int.Parse(Console.ReadLine() ?? "0");
    int[] a = new int[len];
    for (int i = 0; i < a.Length; i++)
    a[i] = new Random().Next(100, 999);

    System.Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
    {
        System.Console.Write(a[i] + ", ");
    }
    System.Console.WriteLine(a[a.Length - 1] + "]");

    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
        count++;
    }

    System.Console.WriteLine("Количество чётных чисел в массиве - " + count);
}

void Ex36()
{
    int ReadData(string msg)
    {
        System.Console.Write(msg);
        int number = int.Parse(System.Console.ReadLine() ?? "0");
        return number;
    }

    int[] Fill1DArr(int len, int lowBord, int highBord)
    {
        int[] array = new int[len];
        for (int i = 0; i < len; i++)
        {
            array[i] = new Random().Next(lowBord, highBord + 1);
        }
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            sum = sum + array[i];
        }
        System.Console.WriteLine("Сумма элементов массива с нечётными индексами - " + sum);
        return array;
    }
    void Print1DArray(int[] arr)
    {
        System.Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            System.Console.Write(arr[i] + ", ");
        }
        System.Console.WriteLine(arr[arr.Length - 1] + "]");
    }
    int arrLen = ReadData("Введите длину массива: ");
    int lowBord = ReadData("Введите min значение элемента массива: ");
    int highBord = ReadData("Введите max значение элемента массива: ");
    int[] arr = Fill1DArr(arrLen, lowBord, highBord);
    Print1DArray(arr);
}

void Ex38()
{
    Console.WriteLine("Введите размер массива:  ");
    int len = int.Parse(Console.ReadLine() ?? "0");
    double[] a = new double[len];
    for (int i = 0; i < a.Length; i++)
        a[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;

    System.Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
    {
        System.Console.Write(a[i] + ", ");

    }
    System.Console.WriteLine(a[a.Length - 1] + "]");

    double min = a[0];
    double max = a[0];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
        else if (a[i] < min)
        {
            min = a[i];
        }
    }
    System.Console.WriteLine("Максимальное значение - " + max);
    System.Console.WriteLine("Минимальное значение - " + min);
    System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
Ex34();
Ex36();
Ex38();

