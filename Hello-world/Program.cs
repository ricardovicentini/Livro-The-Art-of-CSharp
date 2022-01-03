using static System.Console;
var name = string.Empty;

if (!args.Any())
    name = "guest";
else
    name = string.Join(" ", args);

WriteLine($"Hello, {name}!");
ReadLine();
