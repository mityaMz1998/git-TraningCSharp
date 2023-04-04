using System.Runtime.CompilerServices;
using Traning;

//Исключения:

try
{
    Method2();
}
catch (Exception ex)
{
    Console.Write(ex.StackTrace.ToString());
    Console.ReadKey();
}

//try
//{
//    Calc();
//}
//catch (MyCustomException e)
//{
//    Console.WriteLine("Catch MyCustomException");
//    throw;
//}
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Catch Exception");
//}
//Console.ReadLine();

static void Method2()
{
    try
    {
        Method1();
    }
    catch (Exception ex)
    {
        //throw ex resets the stack trace Coming from Method 1 and propogates it to the caller(Main)
        throw ex;
    }
}

static void Method1()
{
    try
    {
        throw new Exception("Inside Method1");
    }
    catch (Exception)
    {
        throw;
    }
}

static void Calc()
{
    int result = 0;
    var x = 5;
    int y = 0;
    try
    {
        result = x / y;
    }
    catch (MyCustomException e)
    {
        Console.WriteLine("Catch DivideByZeroException");
        throw;
    }
    catch (Exception e) 
    {
        Console.WriteLine("Catch Exception");
    }
    finally
    {
        throw new MyCustomException();
    }
}

class MyCustomException : DivideByZeroException
{

}



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


////Копирование значимых и ссылочных типов
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


// Примеры с объектом класса как параметром метода
// Без ref:
//Person p = new Person { name = "Tom", age = 23 };
//ChangePerson(p);

//Console.WriteLine(p.name); // Alice
//Console.WriteLine(p.age); // 23

//void ChangePerson(Person person)
//{
//    // сработает
//    person.name = "Alice";
//    // сработает только в рамках данного метода
//    person = new Person { name = "Bill", age = 45 };
//    Console.WriteLine(person.name);
//    Console.WriteLine(person.age);
//}

//Console.WriteLine();
//// С ref:
//void ChangePersonRef(ref Person person)
//{
//    // сработает
//    person.name = "Alice";
//    // сработает только в рамках данного метода
//    person = new Person { name = "Bill", age = 45 };
//    Console.WriteLine(person.name);
//    Console.WriteLine(person.age);
//}

//ChangePersonRef(ref p);

//Console.WriteLine(p.name); // Bill
//Console.WriteLine(p.age); // 45


// Еще пример:
// 1
//int a = 5;
//string str = "Abcd";

//Console.WriteLine("Со значимыми типами");
//int Calculate(int b)
//{
//    b = 3;
//    return a + b;
//}
//Console.WriteLine(Calculate(a));
//Console.WriteLine(a);

//Console.WriteLine("----------------");
//Console.WriteLine("Отличия модификаторов in и ref");
//// с модификатором in:
//int CalculateIn(in int d)
//{
//    //d = 1; // нельзя вносить изменения
//    return d + a;
//}
//Console.WriteLine(CalculateIn(a));
//// с модификатором ref:
//int CalculateR(ref int d)
//{
//    return d + a;
//}
//Console.WriteLine(CalculateR(ref a));
//Console.WriteLine(a);

//Console.WriteLine("----------------");

//int CalculateRef(ref int b)
//{
//    b = 3;
//    return a + b;
//}
//Console.WriteLine(CalculateRef(ref a));
//Console.WriteLine(a);


//Console.WriteLine("----------------");
//Console.WriteLine("С ссылочными типами");
//string Result(string c)
//{
//    c = "efg";
//    return str + c;
//}
//Console.WriteLine(Result(str));
//Console.WriteLine(str);
//Console.WriteLine("----------------");
//string ResultRef(ref string c)
//{
//    c = "efg";
//    return str + c;
//}
//Console.WriteLine(ResultRef(ref str));
//Console.WriteLine(str);
