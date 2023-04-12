using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    internal class Collections
    {
        //Отличие стека от очереди:
        //1) Стек работает по принципу LIFO (последний вошел - первый вышел), а очередь - по FIFO (первый вошел - первый вышел) 
        //
    }
    //ObservableCollection
    class N
    {
        public string H { get; set; }
        public N(string h) 
        {
            H = h;
        }
        public static void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    if (e.NewItems?[0] is N newPerson)
                        Console.WriteLine($"Добавлен новый объект: {newPerson.H}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    if (e.OldItems?[0] is N oldPerson)
                        Console.WriteLine($"Удален объект: {oldPerson.H}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    if ((e.NewItems?[0] is N replacingPerson) &&
                        (e.OldItems?[0] is N replacedPerson))
                        Console.WriteLine($"Объект {replacedPerson.H} заменен объектом {replacingPerson.H}");
                    break;
            }
        }
    }
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days) => this.days = days;
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new ArgumentException();
                return days[position];
            }
        }
        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
    }
    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator() => new WeekEnumerator(days);
    }
    class MyInt : IEnumerator, IEnumerable
    {
        int[] ints = {1,2,3,4,5,6,7,8,9,10};
        int position = 1;
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext() 
        {
            if (position < ints.Length - 3)
            {
                position = position + 3;
                return true;
            }
            else
                return false;
        }
        public object Current 
        {
            get
            {
                return ints[position];
            }
        }
        public void Reset() => position = 1;
    }
}
