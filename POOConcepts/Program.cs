// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2019, 10, 3));
    Console.WriteLine(new Date(2022, 11, 30));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}

