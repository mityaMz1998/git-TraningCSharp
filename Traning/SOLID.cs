using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning
{
    class SOLID
    {
        //1.Принцип единой ответственности (SRP)
        //2.Принцип открытости/закрытости (OCP)
        //3.Принцип подстановки Лисков (LCP)
        //4.Принцип резделения интерфейсов (ICP)
        //5.принцип инверсии зависимостей (DIP)

    }
    //1.Пример с принципом единой ответственности (SRP)
    // Неверный вариант написания кода.
    public class Employee1
    {
        // В данном случае класс Employee не соответствует принципу SRP,
        // т.к. несет две ответственности – добавление нового сотрудника в базу данных и создание отчета.
        // Класс Employee не должен нести ответственность за отчетность,
        // т.к. например, если через какое-то время вам скажут,
        // что нужно предоставить отчет в формате Excel или изменить алгоритм создания отчета,
        // вам потребуется отредактировать класс Employee.
        public int ID { get; set; }
        public string FullName { get; set; }

        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }

        public void GenerateReport(Employee em)
        {
            // Генерация отчета по деятельности сотрудника
        }
    }
    // Верный вариант написания кода.
    public class Employee2
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }
    }
    public class EmployeeReport
    {
        public void GenerateReport(Employee em)
        {
            // Генерация отчета по деятельности сотрудника
        }
    }

    //2.Принцип открытости/закрытости (OCP)
    //Неверный вариант
    //Главной концепцией данного принципа является то, что класс должен быть открыт для расширений,
    //но закрыт от модификаций.Наш модуль должен быть разработан так,
    //чтобы новая функциональность могла быть добавлена только при создании новых требований.
    //«Закрыт для модификации» означает, что мы уже разработали класс, и он прошел модульное тестирование.
    //Мы не должны менять его, пока не найдем ошибки. Как говорится,
    //класс должен быть открытым только для расширений и в C# мы можем использовать для этого наследование.
    //Давайте рассмотрим наглядный пример:
    public class EmployeeReport1
    {
        // <summary>
        /// Тип отчета
        /// </summary>
        public string TypeReport { get; set; }

        /// <summary>
        /// Отчет по сотруднику
        /// </summary>
        public void GenerateReport(Employee1 em)
        {
            if (TypeReport == "CSV")
            {
                // Генерация отчета в формате CSV
            }

            if (TypeReport == "PDF")
            {
                // Генерация отчета в формате PDF
            }
        }
    }

    //Верный вариант
    //Проблема в этом классе заключается в том, что если мы захотим внести новый тип отчета (например, для выгрузки в Excel),
    //нам понадобится добавить новое условие if. Но согласно принципу OCP, наш класс должен быть закрыт от модификаций и открыт для расширений.
    //Ниже показано, как это можно сделать:
    //В этом случае я вынес метод для генерации отчета в отдельный класс (можно также и в интерфейс), и после этого можно создать классы-наследики,
    //которые будут форматировать документ в конкретный формат.
    public class IEmployeeReport
    {
        /// <summary>
        /// Метод для создания отчета
        /// </summary>
        public virtual void GenerateReport(Employee1 em)
        {
            // Базовая реализация, которую нельзя модифицировать
        }
    }

    public class EmployeeCSVReport : IEmployeeReport
    {
        public override void GenerateReport(Employee1 em)
        {
            // Генерация отчета в формате CSV
        }
    }

    public class EmployeePDFReport : IEmployeeReport
    {
        public override void GenerateReport(Employee1 em)
        {
            // Генерация отчета в формате PDF
        }
    }

    //3.Пример с принципом подстановки Лисков (LCP)
    //Неверный вариант
    //Данный принцип гласит, что «вы должны иметь возможность использовать любой производный класс вместо родительского класса и
    //вести себя с ним таким же образом без внесения изменений».
    //Этот принцип прост, но очень важен для понимания. Дочерний класс не должен нарушать определение типа родительского класса и его поведение.
    public abstract class Employee3
    {
        public virtual string GetWorkDetails(int id)
        {
            return "Base Work";
        }

        public virtual string GetEmployeeDetails(int id)
        {
            return "Base Employee";
        }
    }

    public class SeniorEmployee : Employee3
    {
        public override string GetWorkDetails(int id)
        {
            return "Senior Work";
        }

        public override string GetEmployeeDetails(int id)
        {
            return "Senior Employee";
        }
    }

    public class JuniorEmployee : Employee3
    {
        // Допустим, для Junior’a отсутствует информация
        public override string GetWorkDetails(int id)
        {
            throw new NotImplementedException();
        }

        public override string GetEmployeeDetails(int id)
        {
            return "Junior Employee";

        }
    }

    // Верный вариант
    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }
    public interface IWork
    {
        string GetWorkDetails(int employeeId);
    }
    public class SeniorEmployee1 : IWork, IEmployee
    {
        public string GetWorkDetails(int employeeId)
        {
            return "Senior Work";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Senior Employee";
        }
    }
    public class JuniorEmployee1 : IEmployee
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Junior Employee";
        }
    }

    //4.Принцип разделения интерфейсов (ISP)
    //Принцип разделения интерфейсов гласит, что клиенты не должны принудительно внедрять интерфейсы, которые они не используют.
    //Что же это означает? Давайте предположим, что есть одна база данных для хранения данных всех типов сотрудников (то есть Junior и Senior).
    public interface IEmployee1
    {
        bool AddDetailsEmployee();
    }
    //Допустим все классы Employee наследуют этот интерфейс для сохранения данных.
    //Теперь предположим, что компания однажды сказала вам, что они хотят читать данные только для сотрудников в должности senior.
    //Что вы будете делать? Просто добавьте один метод в этот интерфейс.
    public interface IEmployee2
    {
        bool AddDetailsEmployee();
        bool ShowDetailsEmployee(int id);
    }
    //Но теперь мы что-то ломаем. Мы вынуждаем объекты JuniorEmployee показывать свои данные из базы данных.
    //Таким образом, решение заключается в том, чтобы передать эту ответственность другому интерфейсу:
    public interface IOperationAdd
    {
        bool AddDetailsEmployee();
    }
    public interface IOperationGet
    {
        bool ShowDetailsEmployee(int id);
    }
    //И теперь, класс JuniorEmployee будет реализовывать только интерфейс IOperationAdd, а SeniorEmployee оба интерфейса.
    //Таким образом обеспечивается разделение интерфейсов.


    //5.Принцип инверсии зависимостей (DIP)
    //Данный принцип гласит, что, во-первых, классы высокого уровня не должны зависеть от низкоуровневых классов.
    //При этом оба должны зависеть от абстракций.
    //Во-вторых, абстракции не должны зависеть от деталей, но детали должны зависеть от абстракций.
    //Классы высокого уровня реализуют бизнес-правила или логику в системе (приложении).
    //Низкоуровневые классы занимаются более подробными операциями, другими словами,
    //они могут заниматься записью информации в базу данных или передачей сообщений в операционную систему или службы и т.п.

    //Говорят, что высокоуровневый класс, который имеет зависимость от классов низкого уровня или какого-либо другого класса и
    //много знает о других классах, с которыми он взаимодействует,
    //тесно связан.Когда класс явно знает о дизайне и реализации другого класса, возникает риск того,
    //что изменения в одном классе нарушат другой класс.

    //Поэтому мы должны держать эти высокоуровневые и низкоуровневые классы слабо связанными,
    //насколько мы можем.Чтобы сделать это, нам нужно сделать их зависимыми от абстракций, а не друг от друга.

    //Давайте рассмотрим пример.Предположим, что после сохранения некоторых деталей в базе данных существует одна система уведомлений:
    public class Email
    {
        public void Send()
        {
            // код для отправки email-письма
        }
    }

    // Уведомление
    public class Notification
    {
        private Email email;
        public Notification()
        {
            email = new Email();
        }
        public void EmailDistribution()
        {
            email.Send();
        }
    }
    //Теперь класс Notification полностью зависит от класса Email, потому что он отправляет только один тип уведомлений.
    //А если мы захотим ввести какие-либо другие уведомления, например отправку?
    //Тогда нам понадобится изменить всю систему уведомлений.В данном случае это система является тесно связанной.
    //Что мы можем сделать, чтобы она была слабо связанной? Посмотрите на следующую реализацию:
    public interface IMessenger
    {
        void Send();
    }

    public class Email1 : IMessenger
    {
        public void Send()
        {
            // код для отправки email-письма
        }
    }

    public class SMS : IMessenger
    {
        public void Send()
        {
            // код для отправки SMS
        }
    }

    // Уведомление
    public class Notification1
    {
        private IMessenger _messenger;
        public Notification1()
        {
            _messenger = new Email1();
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }
    //В данном случае класс Notification все еще зависит от класса Email, т.к. использует его объект в конструкторе.
    //В данном случае мы можем использовать принцип внедрения зависимостей (dependency injection – DI)
    // 1.Способ внедрения зависимостей через конструктор
    public class Notification2
    {
        private IMessenger _messenger;
        public Notification2(IMessenger mes)
        {
            _messenger = mes;
        }
        public void DoNotify()
        {
            _messenger.Send();
        }
    }
    // 2.Способ внедрения зависимостей через свойство
    public class Notification3
    {
        private IMessenger _messenger;
        public Notification3()
        {

        }
        public IMessenger Messanger
        {
            set
            {
                _messenger = value;
            }
        }
        public void DoNotify()
        {
            _messenger.Send();
        }
    }

    //3.Способ внедрения через метод
    public class Notification4
    {
        public void DoNotify(IMessenger mes)
        {
            mes.Send();
        }
    }
}
