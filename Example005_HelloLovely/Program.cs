Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "танечка")
{
    Console.Write("Ура, это же ");
    Console.Write(username);
    Console.WriteLine("!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}