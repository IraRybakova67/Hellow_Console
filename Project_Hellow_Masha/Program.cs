Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Mаша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}