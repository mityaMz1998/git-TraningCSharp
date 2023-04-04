using Traning;

//ReferencesAndValuesTypes referencesAndValuesTypes = new ReferencesAndValuesTypes();

//referencesAndValuesTypes.Calculate1(5);
//Console.WriteLine(referencesAndValuesTypes.Calculate1(5));

//ReferencesAndValuesTypes.CalculateValue(5);

//ReferencesAndValuesTypes.CalculateReference("you");

//State state1 = new State(); // State - структура, ее данные размещены в стеке
//Country country1 = new Country();


////Копирование значимых и ссылочных типов
State state1 = new State();
State state2 = new State();
State state3 = new State();
State state4 = new State();

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
int a = 5;
string str = "Abcd";

Console.WriteLine("Со значимыми типами");
int Calculate(int b)
{
    b = 3;
    return a + b;
}
Console.WriteLine(Calculate(a));
Console.WriteLine(a);

Console.WriteLine("----------------");
Console.WriteLine("Отличия модификаторов in и ref");
// с модификатором in:
int CalculateIn(in int d)
{
    //d = 1; // нельзя вносить изменения
    return d + a;
}
Console.WriteLine(CalculateIn(a));
// с модификатором ref:
int CalculateR(ref int d)
{
    return d + a;
}
Console.WriteLine(CalculateR(ref a));
Console.WriteLine(a);

Console.WriteLine("----------------");

int CalculateRef(ref int b)
{
    b = 3;
    return a + b;
}
Console.WriteLine(CalculateRef(ref a));
Console.WriteLine(a);


Console.WriteLine("----------------");
Console.WriteLine("С ссылочными типами");
string Result(string c)
{
    c = "efg";
    return str + c;
}
Console.WriteLine(Result(str));
Console.WriteLine(str);
Console.WriteLine("----------------");
string ResultRef(ref string c)
{
    c = "efg";
    return str + c;
}
Console.WriteLine(ResultRef(ref str));
Console.WriteLine(str);
