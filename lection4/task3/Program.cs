// int Factorial (int n)
// {
//     //1! = 1
//     //0! = 1
//     if(n == 1) return 1;
//     else return n* Factorial(n - 1 );
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
// }


// double Factorial (int n)
// {
//     //1! = 1
//     //0! = 1
//     if(n == 1) return 1;
//     else return n* Factorial(n - 1 );
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
// }



// Фибоначи (каждое следующее число = сумма двух предыдущих)
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f (n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }

// рекурсия
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 45; i++)
{
    Console.WriteLine($"f({i})! = {Fibonacci(i)}");
}