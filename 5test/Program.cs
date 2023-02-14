Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "валик")
{
    Console.WriteLine("Ура, это же ВАЛИК");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}