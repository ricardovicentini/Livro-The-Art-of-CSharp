using static System.Console;
var name = string.Empty;

if (!args.Any())
{
    WriteLine("What is your name?");
    name = ReadLine();
    if(string.IsNullOrEmpty(name))
        name = "guest";
}
else
{
    name = string.Join(" ", args);
}
    

WriteLine($"Hello, {name}! Now you are a c# programer!");
ReadLine();
