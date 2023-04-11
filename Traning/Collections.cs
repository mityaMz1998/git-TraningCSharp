using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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
}
