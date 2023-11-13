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

int aa = 5;
int b = aa == 5 ? 10 : 5;

switch (firstNumber)
{
    case 1:
        Console.WriteLine("First");
        break;
    case 2:
        Console.WriteLine("Second");
        break;
    default:
        Console.WriteLine("Domyślny");
        break;
}

string text = firstNumber switch
{
    1 => "Test123",
    2 => "AAA",
    _ => "Default"
};

int whileIt = 5;

do
{
    Console.WriteLine("Do " + whileIt);
} while (whileIt-- > 0);

for(int i = 0; i < 10; i++)
{
    if(i == 9)
    {
        break; // Wychodzi z pętli
    }

    if(i == 0)
    {
        continue; // Następna iteracja
    }

    Console.WriteLine(i);
}
goto Test;

Test:
Console.WriteLine("Go To Test");

// Nullable
int? nul = null; // ? - zmienna typu wartościowego może mieć typ null, inaczej nie może
if(nul.HasValue)
{
    Console.WriteLine(nul.Value);
    Console.WriteLine(nul.GetValueOrDefault()); // W przypadku int to 0, gdy wartość to null
//  nul.HasValue; // if nul != null
//  nul.Value; // Błąd bo wartość nie może być null
//  Typy referencyjne umożliwiwają wartość null
}

// Listy i Tablice
int[] arr = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine(Array.IndexOf(arr, 5)); // Zwraca index wartości - 4
Array.Sort(arr);

List<int> arr2 = new List<int>();
arr2.Add(5);
foreach(int i in arr2)
{
    Console.WriteLine(i);
}