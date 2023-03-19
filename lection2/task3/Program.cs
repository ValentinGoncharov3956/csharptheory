int[] array = { 1, 4, 12, 262, 15, 262, 25, 262, 27, 46 };

int n = array.Length;
int find = 262;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;  //завершает цикл, как только выполнит условие(находит то что нужно)
    }
    index++;
}