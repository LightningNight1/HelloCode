Console.Write("Enter your username: ");
string username = Console.ReadLine();

if(username.ToLower() == "bob")
{
    Console.WriteLine("Hooray! It's a Bob!");
}
else
{
    Console.WriteLine("Hello,");
    Console.WriteLine(username);
}
