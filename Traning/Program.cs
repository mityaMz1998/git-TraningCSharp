using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Traning;


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
//    Method2();
//}
//catch (Exception ex)
//{
//    Console.Write(ex.StackTrace.ToString());
//    Console.ReadKey();
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
//        throw ex;
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

//Console.WriteLine(am.operation(4, 4));
//Console.WriteLine(am.OperationSum(4, 4));

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
State state1 = new State();
State state2 = new State();
State state3 = new State();
State state4 = new State();

state1.x = 1;
state1.y = 2;

state2 = state1;
state1.x = 5;

state3 = state1;
state2.x = 10;

state4 = state1;
state3.x = 20;

Console.WriteLine("X:");
Console.WriteLine(state1.x);
Console.WriteLine(state2.x);
Console.WriteLine(state3.x);
Console.WriteLine(state4.x);
Console.WriteLine("Y:");
Console.WriteLine(state1.y);
Console.WriteLine(state2.y);
Console.WriteLine(state3.y);
Console.WriteLine(state4.y);

Console.WriteLine("---------------------");

Country country1 = new Country();
Country country2 = new Country();
Country country3 = new Country();
Country country4 = new Country();

country2.x = 1;
country2.y = 4;

country1 = country2;
country2.x = 7;

country3 = country1;
country1.x = 9;

country4 = country3;
country3.x = 13;

Console.WriteLine("X:");
Console.WriteLine(country1.x);
Console.WriteLine(country2.x);
Console.WriteLine(country3.x);
Console.WriteLine(country4.x);
Console.WriteLine("Y:");
Console.WriteLine(country1.y);
Console.WriteLine(country2.y);
Console.WriteLine(country3.y);
Console.WriteLine(country4.y);


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
