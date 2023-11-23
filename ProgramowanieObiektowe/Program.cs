using ProgramowanieObiektowe.Solid;

var square = new Square() { Side = 20 };

var calculator = new PerimeterCalculator();
calculator.Calculate(square);

List<Animal> animals = new List<Animal>();

animals.Add(new Dog());
animals.Add(new Fish());

// animals.ForEach(o => o.Run());

//static int a()
// {
   // return default;
// }

// Console.WriteLine(a()); default dla int to 0