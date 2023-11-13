// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int character = Console.Read(); // Pobiera tylko pierwszy znak (jako int)
Console.WriteLine(character);
string napis = Console.ReadLine();
Console.WriteLine(napis);
// PascalCase - NapisZmiennaPrzyklad
// Cummelcase - napisZmiennaPrzyklad - głównie zmienne lokalne i globalne
// UpperCase  - PI_VALUE - głównie do stałych
string? yearString = Console.ReadLine();
bool isValid = int.TryParse(yearString, out int year);
Console.WriteLine(isValid);
Console.WriteLine(year);

int firstNumber = 20;
int secondNumber = firstNumber;