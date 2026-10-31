//using HW_Encapsulation;
//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.InputEncoding = Encoding.UTF8;

//Console.WriteLine("Hello, Encapsulation!\n");
//Console.WriteLine("***** Fun with Class Types *****\n");

//// Разместить в памяти и сконфигурировать объект Саг.
//Car myCar = new Car();
//myCar.petName = "Henry";
//myCar.currSpeed = 10;

//// Создать объект Car по имени Chuck со скоростью 10 миль в час.
//Car chuck = new Car();
//chuck.PrintState();

//// Создать объект Car по имени Mary со скоростью 0 миль в час.
//Саг тагу = new Car("Магу");
//тагу.PrintState();
//// Создать объект Саг по имени Daisy со скоростью 75 миль в час.
//Car daisy = new Car("Daisy", 75);
//daisy.PrintState();

//// Увеличить скорость автомобиля в несколько раз и вывести новое состояние,
//for (int i = 0; i <= 10; i++)
//{
//    myCar.SpeedUp(5);
//    myCar.PrintState();
//}
//Console.ReadLine();

using HW_Encapsulation;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, Encapsulation!\n");
Console.WriteLine("***** Fun with Class Types *****\n");

//Motorcycle mc = new Motorcycle();
//mc.PopAWheel();

// Создать объект Motorcycle.
Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.driverName);
// вывод имени гонщика
Console.ReadLine();