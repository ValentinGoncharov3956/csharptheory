int ReadNumber(string message)
{
        Console.WriteLine(message);
        return int.Parse(Console.ReadLine());
}

// int[] CreateArray(int N)
// {
//     int[] arrayA = new int[N * 2 + 1];
//     for (int i = -N; i <= N ; i++)
//     {
//         arrayA[i + N] = i;
//     }
//     return arrayA;
// }

// int B = ReadNumber("Введите число");
// int[] array = CreateArray(B);
// Console.WriteLine($"[{string.Join(", ", array)}]");


// void Method(int maximum)
// {
//     int minimum;
//     minimum = -maximum;
//     while (minimum <= maximum)
//     {
//         Console.Write(minimum + " ");
//         minimum++;
//     }
// }

// int B = ReadNumber("Введите число");
// Console.Write("[");
// Method(B);  
// Console.Write("]");

// int Ar(int N)
// {
//     int x = -N;
//     while (x <= -N)
//     {
//         Console.WriteLine(x);
//         x++;
//     }
//     return x;
// }

// void Numb(int n)
// {
//     int length = n + n;
//     for (int i = 0; i < length + 1; i++)
//     {
//         Console.Write(-n + i + " ");
//     }
// }

// string SnowNums(int N)
// {
//     string NumsShow = "";
//     for (int i = -N; i <= N; i++)
//     {
//         NumsShow = NumsShow + i + " ";
//     }
//     return NumsShow;
// }


// int B = ReadNumber("Введите число");
// SnowNums(B);
// Console.WriteLine(SnowNums(B));


int af = -5;
int uf = 5;

Console.WriteLine($"{af} .. {uf}");