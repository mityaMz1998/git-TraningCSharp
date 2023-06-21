using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Traning;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections;
using System.Threading;
using System.Reflection.PortableExecutable;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.ComponentModel.Design;

string n = "N";

switch ("N")
{
    case "Y":
        Console.WriteLine("Y is the option");
        break;
    case "N":
        Console.WriteLine("N is the option");
        //break;
    default:
        Console.WriteLine("Default option");
        break;
}



//float somevariable = (Double)12.502D;

//do
//    //{

//    //} while (count > 0);
//}
//Console.WriteLine(Calculate(2, 3));


//DependencyInjection(внедрение зависимостей)
//EmployeeBL employeeBL = new EmployeeBL();
////employeeBL.EmployeeDataObject = new EmployeeDAL();
//List<EmployeeM> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
//foreach (EmployeeM emp in ListEmployee)
//{
//    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
//}

//Ddd d = new Ddd();
//Console.WriteLine(d.Sum(7, 5, 3));
//Console.WriteLine(d.Output());

//Eee e = new Eee(d);
//Console.WriteLine(e.GetSum());
//e.E = new Ddd();
//Console.WriteLine(e.E);
//Console.WriteLine(e.GetSum());

//Асинхронное программирование
//AsyncProgramming asyncProgramming = new AsyncProgramming();
//await foreach(var i in asyncProgramming.GetStringsAsync())
//    Console.WriteLine(i);

//int a = await asyncProgramming.IntOutputAsync(4,5);
//Console.WriteLine(a);

//await asyncProgramming.SumOutputAsync(2);
//asyncProgramming.SumOutputAsync1(3);

//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
//asyncProgramming.PrintName("Tom");
//asyncProgramming.PrintName("Bob");
//asyncProgramming.PrintName("Sam");
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);
//stopwatch.Reset();
//Console.WriteLine();
//stopwatch.Start();
//await asyncProgramming.PrintNameAsync("Kate");
//await asyncProgramming.PrintNameAsync("Anna");
//await asyncProgramming.PrintNameAsync("Julia");
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);
//Console.WriteLine();
//stopwatch.Reset();

//var nameSimon = asyncProgramming.PrintNameAsync("Simon");
//var nameFarel = asyncProgramming.PrintNameAsync("Farel");
//var nameMoana = asyncProgramming.PrintNameAsync("Moana");
//stopwatch.Start();
//await Task.WhenAny(nameSimon, nameFarel, nameMoana);
//await nameSimon;
//await nameFarel;
//await nameMoana;
//stopwatch.Stop();
//Console.WriteLine(stopwatch.ElapsedMilliseconds);
//stopwatch.Reset();
//Console.WriteLine();

//Console.WriteLine("Начало");
//asyncProgramming.StringOutputAsync();
//Console.WriteLine("Конец");


//Параллельное программивароние TPL
//Console.WriteLine("Main Starts");
//// создаем задачу
//Task task1 = new Task(() =>
//{
//    Console.WriteLine("Task Starts");
//    Thread.Sleep(1000);     // задержка на 1 секунду - имитация долгой работы
//    Console.WriteLine("Task Ends");
//});
////task1.Start();
////task1.Wait();// запускаем задачу
////task1.RunSynchronously();
//Console.WriteLine("Main Ends");
//task1.RunSynchronously();

//Вложенная задача
//var outer = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Task outer start");
//    var inner = Task.Factory.StartNew(() =>
//    {
//        Console.WriteLine("Task inner start");
//        Thread.Sleep(1000);
//        Console.WriteLine("Task inner finish");
//    }, TaskCreationOptions.AttachedToParent);
//    inner.Wait();
//    Console.WriteLine("Task outer finish");
//});
//outer.Wait();
//Console.WriteLine();

//Задача продолжения:
//Task<int> task1 = new Task<int>(() => Calculate.Sum(4, 5));
//Task task2 = task1.ContinueWith(t => Console.WriteLine(task1.Result));
//task1.Start();
//task2.Wait();
//Console.WriteLine("Конец метода Main");

// Параллельное программирование с помощью Parallel
//Parallel.Invoke(
//    () => Calculate.Multi(2),
//    () =>
//    {
//        Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//        Console.WriteLine($"Результат: {10 - 3}");
//    },
//    () => Calculate.Div(8,8.0)
//);

//ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 },Calculate.Multi);

//Многопоточность
//int x;
//AutoResetEvent waitHandler = new AutoResetEvent(true);
//Mutex mutexObj = new();
//object locker = new();
//for (int i = 1; i < 6; i++)
//{
//    Thread thread = new(Print);
//    thread.Name = $"Поток {i}";
//    thread.Start();
//}

//void Print() 
//{
//    //Семафоры
//    for (int i = 1; i < 6; i++)
//    {
//        Pay pay = new Pay(i);
//    }

//    // Мьютексы
//    //mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
//    //x = 1;
//    //for (int i = 1; i < 6; i++)
//    //{
//    //    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//    //    x++;
//    //    Thread.Sleep(100);
//    //}
//    //mutexObj.ReleaseMutex();    // освобождаем мьютекс

//    // Класс AutoResetEvent
//    //waitHandler.WaitOne();  // ожидаем сигнала
//    //x = 1;
//    //for (int i = 1; i < 6; i++)
//    //{
//    //    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//    //    x++;
//    //    Thread.Sleep(100);
//    //}
//    //waitHandler.Set();  //  сигнализируем, что waitHandler в сигнальном состоянии

//    // Монитор
//    //bool acquiredLock = false;
//    //try
//    //{
//    //    Monitor.Enter(locker, ref acquiredLock);
//    //    x = 1;
//    //    for (int i = 1; i < 6; i++)
//    //    {
//    //        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//    //        x++;
//    //        Thread.Sleep(100);
//    //    }
//    //}
//    //finally
//    //{
//    //    if (acquiredLock) Monitor.Exit(locker);
//    //}

//    // Блокировка кода при помощи оператора lock
//    //lock (locker)
//    //{
//    //    x = 1;
//    //    for (int i = 1; i < 6; i++)
//    //    {
//    //        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//    //        x++;
//    //        Thread.Sleep(100);
//    //    }
//    //}
//}


//int chislo = 7;
//Thr thr = new Thr();
//Thread thread2 = new Thread(thr.SecondThread);
//thread2.Start();
//Thread thread3 = new Thread(thr.ThirdThread);
//thread3.Start(chislo);
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Главный поток:");
//    Console.WriteLine(i);
//    Thread.Sleep(1000);
//}

//Console.WriteLine();

//Коллекции
//var people = new List<string>() { "Tom", "Bob", "Sam" };
//var employees = new List<string>(people) {"Mike"};

//string firstPerson = people[1];
//Console.WriteLine(firstPerson);
//people[0] = "Kate";
//Console.WriteLine(people[0]);
//Console.WriteLine(employees.Count);
//employees.Add("Colin");

//Console.WriteLine(employees.BinarySearch("Sam"));
//foreach (var person in employees)
//    Console.WriteLine(person);

// Интерфейсы IEnumerable и IEnumerator:
//Week week = new Week();
//foreach (var day in week)
//{
//Console.WriteLine(day);
//}

//// С циклом foreach:
//string[] arr = new string[] {"Holly","TJ","Bill"};
//foreach (string s in arr)
//    Console.WriteLine(s);

//Console.WriteLine();
////Без цикла foreach:
//IEnumerator peopleEnumerator = arr.GetEnumerator(); // получаем IEnumerator
//while (peopleEnumerator.MoveNext())   // пока не будет возвращено false
//{
//    string item = (string)peopleEnumerator.Current; // получаем элемент на текущей позиции
//    Console.WriteLine(item);
//}
//peopleEnumerator.Reset(); // сбрасываем указатель в начало массива

////Реализация собственного способа итерации коллекции
//MyInt mi = new MyInt();
//foreach (int i in mi)
//    Console.Write(i + "\t");

//Оператор yield
//foreach (int i in ListInt(5))
//{
//    Console.Write(i);
//    Console.Write(" ");
//}
//IEnumerable ListInt(int n)
//{
//    for (int i = 0; i < n; i++)
//        yield return i;
//}


//Коллекция ObservableCollection
//var people = new ObservableCollection<string>
//
//    "Jake", "Ammy", "Fara"
//};
//Console.WriteLine(people[0]);
//people[0] = "Jack";
//Console.WriteLine(people[0]);

//var list = new ObservableCollection<N>()
//{
//    new N("Tom"),
//    new N("Sam")
//};
//list.CollectionChanged += N.People_CollectionChanged;

//list.Add(new N("Bob"));

//list.RemoveAt(1);
//list[0] = new N("Eugene");

//Console.WriteLine("\nСписок пользователей:");
//foreach (var person in list)
//{
//    Console.WriteLine(person.H);
//}

//Словарь
//var people = new Dictionary<int, string>()
//{
//    {4, "Tom"},
//    {2, "Lola"},
//    {7, "Dic"}
//};
//foreach (var i in people)
//    Console.WriteLine(i);

//string p1 = people[2];
//Console.WriteLine(p1);
//Console.WriteLine();

//people[10] = "Kate";
//foreach (var i in people)
//    Console.WriteLine(i);

//var i1 = people.Keys;
//Console.WriteLine(i1);

//Стек
//var stack = new List<int> { 1, 2, 3, 4, 5};
//Stack<int> stack1 = new Stack<int>(stack);
//foreach (int i in stack1)
//    Console.WriteLine(i);

//Console.WriteLine();

//var stackNumbers = new Stack<int>();
//stackNumbers.Push(1);
//stackNumbers.Push(2);
//stackNumbers.Push(3);

//foreach (int i in stackNumbers)
//    Console.WriteLine(i);

//Console.WriteLine();

//int findFirstEl = stackNumbers.Peek();
//Console.WriteLine(findFirstEl);

//Console.WriteLine();

//int p1 = stackNumbers.Pop();
//Console.WriteLine(p1);

//int p2 = stackNumbers.Pop();
//Console.WriteLine(p2);

//Console.WriteLine();

//foreach (int i in stackNumbers)
//    Console.WriteLine(i);

//Связанный список
//LinkedList<string> people = new LinkedList<string>();
//var employees = new List<string> { "Tom", "Sam", "Bob" };

//LinkedList<string> people1 = new LinkedList<string>(employees);
//people1.AddLast("Angel");
//people1.AddFirst("Ann");
//// вставляем после первого узла новый узел со значением Mike
//if (people1.First != null)
//{
//    people1.AddAfter(people1.First, "Paul");
//    people1.AddBefore(people1.First, "Seva");
//}
//if (people1.Last != null)
//    people1.RemoveLast();

//LinkedListNode<string> currentNode = people1?.First;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode?.Next;
//}
//Console.WriteLine();
//currentNode = people1?.Last;
//while (currentNode != null)
//{
//    Console.WriteLine(currentNode.Value);
//    currentNode = currentNode?.Previous;
//}

//Очередь
//var employees = new List<string> { "Tom", "Sam", "Bob" };
//Queue<string> people = new Queue<string>(employees);
//foreach (var person in people) Console.WriteLine(person);
//Console.WriteLine(people.Count);
//Console.WriteLine();

//var people = new Queue<string>();
//people.Enqueue("Tom");
//people.Enqueue("Sam");
//foreach (var person in people) Console.WriteLine(person);

//var firstPerson = people.Peek();
//Console.WriteLine(firstPerson);

//people.Dequeue();

//foreach (var person in people) Console.WriteLine(person);

//Статические классы и их члены
//K k = new K();
//Console.WriteLine(k.a);
//Console.WriteLine(K.u);
//K k2 = new K(5);
//Console.WriteLine(k2.a);
//k2.Bn();

//Console.WriteLine();
//Console.WriteLine(L.s);
//L.f();
//Console.WriteLine();

//M m = new M();
//Console.WriteLine(m.structM());
//Console.WriteLine(M.f);
//M.m();


//L l = new L();

//Обощенные типы:
//User<int> user1 = new User<int>(1,"Joel");
//User<int>.i = 25;
//User<string> user2 = new User<string>("TTT","Jimmy");
//User<string>.i = "aaa";
//Console.WriteLine(user1.ToString());
//Console.WriteLine(user2.ToString());

//User<string> person1 = new User<string>("34","James");
//User<int> person2 = new User<int>(45,"Farel");
//UniversalUser<int> person3 = new UniversalUser<int>(33,"Ora");
//Console.WriteLine(person1.ToString());
//Console.WriteLine(person2.ToString());
//Console.WriteLine(person3.ToString());

//Console.WriteLine();

//IntUser<string> user1 = new IntUser<string>(4,"Hhh");
//User<int> user2 = new IntUser<long>(3542,"BBB");
//Console.WriteLine(user1.ToString());
//Console.WriteLine(user2.ToString());

//char a = '2';
//int r = Convert.ToInt32(a);
//Console.WriteLine(r);

//Инкапсуляция
//User user = new User();
//user.Name = "Test";
//Console.WriteLine(user.Name);

//Виртуальные члены
//Console.WriteLine(G.minAge);
//Console.WriteLine(G.typeName);
//Console.WriteLine(H.minAge);
//Console.WriteLine(H.typeName);

//Person bob = new Person("Bob");
//bob.Print();

//Employee tom = new Employee("Tom", "Microsoft");
//tom.Print();

//Person sam = new Employee("Sam","Google");
//sam.Print();

//Aaa aaa = new Aaa();
//aaa.MethodA();

//Bbb bbb = new Bbb();
//bbb.MethodA();

//Ccc ccc = new Ccc();
//ccc.MethodA();


//Преобразование типов при наследовании
//Восходящее преобразование
//RaceCar raceCar = new RaceCar("Japan", 270);
//CarClass carClass = raceCar;
//Console.WriteLine(carClass.Country);

////Нисходящее преобразование
//RaceCar raceCar1 = new RaceCar("Usa",290);
//CarClass carClass1 = raceCar1;
//RaceCar raceCar2 = (RaceCar)carClass1;
//Console.WriteLine(raceCar1.Country);

//Console.WriteLine();
////Преобразование через as
//CarClass carClass2 = new CarClass("Germany");
//RaceCar? raceCar3 = carClass2 as RaceCar;
//Console.WriteLine($"{raceCar3?.Country}-{raceCar3?.Name}"); // вернет значения null

//// Преобразование через is
//if (carClass2 is RaceCar raceCar4)
//    Console.WriteLine($"{raceCar4?.Country}-{raceCar4?.Name}");
//else Console.WriteLine("Преобразование недопустимо");

//Наследование
//Person p1 = new Person() { Name = "Tom"};
//p1.Print();

//Person p2 = new Employee("Sam", "Microsoft");
//p2.Print();

//Employee p3 = new Employee("Kate", "Google");// { Name = "Kate", Company = "Google" };
//p3.Print();

//CarClass car1 = new CarClass();
//CarClass car2 = new CarClass("Japan");
//RaceCar raceCar1 = new RaceCar(car2.Country,280);


//Интерфейсы:
//ProductComparable bread = new ProductComparable("Хлеб", 15);
//ProductComparable chocolate = new ProductComparable("Шоколад", 25);
//ProductComparable cake = new ProductComparable("Торт", 200);

//ProductComparable[] arr = { bread, chocolate, cake };
//Array.Sort(arr);

//foreach (ProductComparable item in arr)
//    Console.WriteLine(item.Name);

//var bread = new Product("Хлеб", 15);
//var chocolate = (Product)bread.Clone();

//Console.WriteLine(bread.Name);
//Console.WriteLine(bread.Price);
//Console.WriteLine(chocolate.Name);
//Console.WriteLine(chocolate.Price);

//bread.Price = 20;
//Console.WriteLine(bread.Name);
//Console.WriteLine(bread.Price);
//Console.WriteLine(chocolate.Name);
//Console.WriteLine(chocolate.Price);

//var telegram = new Messenger<BaseAction>();
//var message = new BaseAction("Hello!");
//telegram.Send(message);

//A a = new C();
//a.D();

//B b = new C();
//b.D();

//IAction baseAction = new BaseAction();
//baseAction.Move();

//ITruth truth = new BaseAction();
//truth.Move();

//IAction action = new BaseAction();
//action.Move();

//BaseAction baseAction1 = new HeroAction();
//baseAction1.Move();

//IAction action1 = new HeroAction();
//action1.Move();

//HeroAction heroAction = new HeroAction();
//heroAction.Move();

//IMovable ia = new IMovable();
//Console.WriteLine(IMovable.maxSpeed);
//Console.WriteLine(IMovable.minSpeed);

//IMovable car = new Car();
//car.Move();
//car.Stop();

//Console.WriteLine();

//IFigure circle = new Circle(4,"Круг");
//IFigure square = new Square(4,"Квадрат");
//Console.WriteLine(circle.CalcPerimetr());
//Console.WriteLine(circle.CalcArea());
//Console.WriteLine(square.CalcPerimetr());
//Console.WriteLine(square.CalcArea());

// Явная реализация интерфейса
//BaseAction baseAction = new BaseAction();
//((IAction)baseAction).Move();

//if (baseAction is ITruth action)
//   action.Move();

//IAction baseAction1 = new BaseAction();
//baseAction1.Move();

//Console.WriteLine();
//HeroAction heroAction = new HeroAction();
//heroAction.Move(); // MoveIAction

//BaseAction baseAction2 = new HeroAction();
//baseAction2.Move(); // MoveIAction
//((IAction)baseAction2).Move(); //MoveHero

//IAction action3 = new HeroAction();
//action3.Move(); //MoveHero


//IMovable im = new Car();
//im.Stop();

//IMovable.Stop();

//IMovable? movable = null;
//movable?.Move();

//void DoAction(IMovable movable) => movable.();
//DoAction(car);


//Абстрактные классы
//AbstractClasses abstractClasses = new AbstractClasses();
//Figure triangle = new Triangle("треугольник",5,7,9);
//Figure rectangle = new Rectangle("прямоугольник",10,20);

//Console.WriteLine(triangle.CalcPerimetr());
//Console.WriteLine(triangle.CalcArea());
//Console.WriteLine();
//Console.WriteLine(rectangle.CalcPerimetr());
//Console.WriteLine(rectangle.CalcArea());

// Структуры:
//PersonStruct p4 = new PersonStruct();
//p4.Print();
//p4.age = 10;
//p4.Print();

//Person5 person5 = new Person5();
//person5.Print();
//person5.age = 20;
//person5.name = "Kate";
//person5.Print();

////Пример копирования структруры с with
//PersonStruct p6 = p4 with {age = 25 };
//p6.Print();

// Классы, объекты, конструкторы, инициализаторы, деконструкторы
//PersonClass p1 = new PersonClass();
//p1.Print();

//PersonClass p2 = new PersonClass("Bob", 43) { name = "Tom", age = 20};
//p2.Print();

//// 1 способ декомпозиции объекта
//PersonClass p3 = new PersonClass("Jim", 30);
//(string name, int age) = p3;
//Console.WriteLine(name);
//Console.WriteLine(age);

//// 2 способ декомпозиции объекта
//string n; 
//int a;
//p3.Deconstruct(out n, out a);
//Console.WriteLine(n);
//Console.WriteLine(a);


//Исключения:
//try
//{
//    //throw new AccessViolationException();
//    int x = 5;
//    int y = x / 0;
//    //throw new AccessViolationException();
//    Console.WriteLine($"Результат: {y}");
//    //throw new AccessViolationException();
//}
////catch (Exception)
////{
////    Console.WriteLine("Возникло исключение Exception");
////}
//catch (AccessViolationException)
//{
//    Console.WriteLine("Возникло исключение AccessViolationException");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Возникло исключение DivideByZeroException");
//    //throw;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Возникло исключение Exception");
//    //throw;
//}
//finally
//{
//    Console.WriteLine("Конец блока");
//    throw new AccessViolationException();
//}


//try
//{
//    Method2();
//}
//catch (Exception ex)
//{
//    Console.Write(ex.StackTrace.ToString());
//    //Console.ReadKey();
//}

//static void Method2()
//{
//    try
//    {
//        Method1();
//    }
//    catch (Exception ex)
//    {
//        //throw ex resets the stack trace Coming from Method 1 and propogates it to the caller(Main)
//        throw;
//    }
//}

//static void Method1()
//{
//    try
//    {
//        throw new Exception("Inside Method1");
//    }
//    catch (Exception)
//    {
//        throw;
//    }
//}

//try
//{
//    Calc();
//}
//catch (MyCustomException e)
//{
//    Console.WriteLine("Catch MyCustomException");
//    //throw;
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Catch Exception");
//}
//finally
//{
//    Console.WriteLine("gggg");
//}
//Console.ReadLine();

//static void Calc()
//{
//    int result = 0;
//    var x = 5;
//    int y = 0;
//    try
//    {
//        result = x / y;       
//    }
//    //catch (MyCustomException ex)
//    //{
//    //    Console.WriteLine("Catch DivideByZeroException");
//    //    throw;
//    //}
//    catch (MyCustomException ex)
//    {
//        Console.WriteLine(ex.Message);
//        throw;
//    }
//    catch (Exception ex) 
//    {
//        Console.WriteLine("Catch Exception");
//        throw;
//    }
//    finally
//    {
//        throw new MyCustomException();
//    }
//}

//class MyCustomException : DivideByZeroException
//{

//}

// События:
//NumOperations nm = new NumOperations();
//nm.Notification += nm.DisplayMessage;
//nm.Sum(3, 5);
//nm.Sub(20, 10);

//AccountEv ae1 = new(300);
//ae1.Put(50);
//Console.WriteLine(ae1.Sum);
//ae1.Take(100);
//Console.WriteLine(ae1.Sum);
////ae1.Notify += ae1.Put(20);

//AccountEv ae2 = new(400);
//ae2.Notify += ae2.DisplayMessage;
//ae2.Put(50);
//Console.WriteLine(ae2.Sum);
//ae2.Take(100);
//Console.WriteLine(ae1.Sum);

// Лямбда-выражения:
//LambdaExpressions lambdaExpressions = new LambdaExpressions();

//var sum = (int x, int y) => x + y;
//Console.WriteLine(sum(2,3));

//Console.WriteLine(lambdaExpressions.multiply(2,3));

//var sub = (int x, int y) =>
//{
//    if (x > y) return x - y;
//    else return y - x;
//};

//Анонимные методы:
//AnonymousMethods am = new AnonymousMethods();

//Console.WriteLine(am.operationSum(4, 4));
//Console.WriteLine(am.OperationSum(4, 4));

//Console.WriteLine(am.operationSub(8,5));
//Console.WriteLine(am.OperationSub(8,5));

// Пример вызова делегата:
//Delegates d = new();

//Operation op = d.Subtract;
//op += d.Multiply;
//op += d.Add;

//Console.WriteLine(op(7, 2)); // вызов последнего метода из списка
//Console.WriteLine(op.GetInvocationList()[1].DynamicInvoke(7, 2)); //вызов определенного метода из списка
//Console.WriteLine("------------");

//OperationDivision op2 = d.Division;
////double result = op2(9, 2);
//Console.WriteLine(op2(9.0, 2));
//Console.WriteLine("------------");

//Message? message = d.Hello;
//message += d.HowAreYou;
//message += d.HowAreYou;
//message -= d.HowAreYou;
//if (message != null)
//    message();
//Console.WriteLine("------------");

//OperationVoid ov = d.AddVoid;
//ov += d.SubstractVoid;
//ov += d.MultiplyVoid;
//ov(4, 2);
//Console.WriteLine("------------");

//d.DoOperation(3, 6, d.Add);
//d.DoOperation(3, 6, d.Subtract);

//Account account = new Account(1000);
//account.RegisterHandler(account.PrintSimpleMessage);
//account.Put(100);
//account.Take(200);


//ReferencesAndValuesTypes referencesAndValuesTypes = new ReferencesAndValuesTypes();

//referencesAndValuesTypes.Calculate1(5);
//Console.WriteLine(referencesAndValuesTypes.Calculate1(5));

//ReferencesAndValuesTypes.CalculateValue(5);

//ReferencesAndValuesTypes.CalculateReference("you");

//State state1 = new State(); // State - структура, ее данные размещены в стеке
//Country country1 = new Country();


//Копирование значимых и ссылочных типов
//State state1 = new State();
//State state2 = new State();
//State state3 = new State();
//State state4 = new State();

//state1.x = 1;
//state1.y = 2;

//state2 = state1;
//state1.x = 5;

//state3 = state1;
//state2.x = 10;

//state4 = state1;
//state3.x = 20;

//Console.WriteLine("X:");
//Console.WriteLine(state1.x);
//Console.WriteLine(state2.x);
//Console.WriteLine(state3.x);
//Console.WriteLine(state4.x);
//Console.WriteLine("Y:");
//Console.WriteLine(state1.y);
//Console.WriteLine(state2.y);
//Console.WriteLine(state3.y);
//Console.WriteLine(state4.y);

//Console.WriteLine("---------------------");

//Country country1 = new Country();
//Country country2 = new Country();
//Country country3 = new Country();
//Country country4 = new Country();

//country2.x = 1;
//country2.y = 4;

//country1 = country2;
//country2.x = 7;

//country3 = country1;
//country1.x = 9;

//country4 = country3;
//country3.x = 13;

//Console.WriteLine("X:");
//Console.WriteLine(country1.x);
//Console.WriteLine(country2.x);
//Console.WriteLine(country3.x);
//Console.WriteLine(country4.x);
//Console.WriteLine("Y:");
//Console.WriteLine(country1.y);
//Console.WriteLine(country2.y);
//Console.WriteLine(country3.y);
//Console.WriteLine(country4.y);


////Копирование ссылочных типов внутри типов значений
//state2.country.x = 5;

//state1 = state2;
//state2.country.x = 8; // теперь и state1.country.x=8, так как state1.country и state2.country указывают на один объект в хипе

//state3 = state1;
//state1.country.x = 9;

//state4 = state3;
//state3.country.x = 10;

//Console.WriteLine(state1.country.x); // 10
//Console.WriteLine(state2.country.x); // 10
//Console.WriteLine(state3.country.x); // 10
//Console.WriteLine(state4.country.x); // 10


//Еще пример:
//int a = 5;
//string str = "Abcd";

//ReferencesAndValuesTypes referencesAndValuesTypes = new ReferencesAndValuesTypes();

//Console.WriteLine("Со значимыми типами");
//Console.WriteLine(referencesAndValuesTypes.Calculate(referencesAndValuesTypes.a));
//Console.WriteLine(referencesAndValuesTypes.a);

//Console.WriteLine("----------------");
//Console.WriteLine("Отличия модификаторов in и ref");
//// с модификатором in:
//Console.WriteLine(referencesAndValuesTypes.CalculateIn(referencesAndValuesTypes.a));
//// с модификатором ref:
//Console.WriteLine(referencesAndValuesTypes.CalculateR(ref referencesAndValuesTypes.a));
//Console.WriteLine(referencesAndValuesTypes.a);

//Console.WriteLine("----------------");

//Console.WriteLine(referencesAndValuesTypes.CalculateRef(ref referencesAndValuesTypes.a));
//Console.WriteLine(referencesAndValuesTypes.a);


//Console.WriteLine("----------------");
//Console.WriteLine("С ссылочными типами");
//Console.WriteLine(referencesAndValuesTypes.Result(referencesAndValuesTypes.str));
//Console.WriteLine(referencesAndValuesTypes.str);
//Console.WriteLine("----------------");
//Console.WriteLine(referencesAndValuesTypes.ResultRef(ref referencesAndValuesTypes.str));
//Console.WriteLine(referencesAndValuesTypes.str);
