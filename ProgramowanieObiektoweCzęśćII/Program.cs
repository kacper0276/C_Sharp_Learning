using System.Collections;

var list = new ArrayList(); // Nie trzeba podawać typu na starcie
list.Add(null);
list.Add(211);

var hashtable = new Hashtable(); // klucz - wartość
hashtable.Add(2, "Dwa");
hashtable.Add(1, "jeden");

var sortedList = new SortedList();
sortedList.Add(2, "Dwa");
sortedList.Add(1, "Jeden");
sortedList.Add(3, "Trzy");

Console.WriteLine("Sorted List:");
foreach (var item in sortedList)
{
    Console.WriteLine(item);
}

var listGeneric = new List<decimal>();
listGeneric.Add(1);
listGeneric.Add(200);
listGeneric.Add(100);
listGeneric.Add(5);

var dictionary = new Dictionary<string, string>();
dictionary.Add("1", "1");
dictionary.TryAdd("1", "1"); // Nie doda wartości
dictionary["2"] = "2";

dictionary.ContainsKey("2"); // Zwraca true lub false
dictionary.TryGetValue("2", out string val);
Console.WriteLine("Dictionary: ");
Console.WriteLine(val);

var queue = new Queue<string>(); // Lista w stylu first in - first out
queue.Enqueue("1");
queue.Enqueue("2");
Console.WriteLine("Queue: ");
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

var stack = new Stack<string>(); // Lista first in - last out
stack.Push("1");
stack.Push("2");
stack.Push("3");
Console.WriteLine("Stack: ");
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

Console.WriteLine("Enumerator: ");
var enumerator = listGeneric.GetEnumerator();
enumerator.MoveNext(); enumerator.MoveNext(); // Pominięte dwie wartości
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}

Console.WriteLine("Yield: ");
var enumerable = GetTestData();
foreach (var i in enumerable)
{
    Console.WriteLine(i); // https://www.plukasiewicz.net/Artykuly/Yield_return
}

static IEnumerable<int> GetTestData()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
}