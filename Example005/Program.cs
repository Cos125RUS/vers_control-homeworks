Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "val")
{
    Console.WriteLine("Pam-pam-pam");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}