using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabLinq22.Models;

// Установка пакетов и создание модели данных
// Install-Package Microsoft.EntityFrameworkCore.SqlServer
// Install-Package Microsoft.EntityFrameworkCore.Design
// Install-Package Microsoft.EntityFrameworkCore.Tools
// Scaffold-DbContext "Data Source=magister-v;Initial Catalog=Faculty_UA_22;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -Context FacultyContext -OutputDir Models

namespace LabLinq22
{
    internal class DataAccess
    {
        // TODO 1
        /* Лабораторная работа посвящена использованию языка
         * LINQ - Language-Integrated Query
         * для выполнения запросов к различным источникам данных
         * 
         * На основе приведенных примеров постройте свои запросы
         * в соответствии с вариантом задания
         * После каждого упражнения программа должна
         * компилироваться и запускаться
         * 
         * Дополнительные сведения о языке LINQ
         * можно почерпнуть в документации MSDN:
         * https://learn.microsoft.com/ru-ru/dotnet/csharp/linq/
         */

        // Определение источника данных
        // Собственно, это и есть модель данных

        public FacultyContext context = new FacultyContext();

        // TODO 2 
        // Упражнение 2
        // Используется проекция

        // TODO 2.1. Проекция на анонимный класс


        public object Query21Example()
        {
            var query =
                from st in context.Students
                select new
                {
                    Name = st.Name,
                    Patronimic = st.Patronymic
                };
            return query.ToList(); // получение данных для привязки на форме
        }

        // На основе приведенного выше примера постройте свой запрос
        public object Query21()
        {
            return null;
        }

        // TODO 2.2. Проекция на именованый класс 

        //Создаём класс для оторбражения результатов запроса
        public class tmpClass
        {
            public string Name
            { get; set; }
            public string Patronimic
            { get; set; }
        }

        // Запрос возвращает коллекцию объектов ранее созданного класса
        public IEnumerable<tmpClass> Query22Example()
        {
            var query =
                from st in context.Students
                select new tmpClass
                {
                    Name = st.Name,
                    Patronimic = st.Patronymic
                };
            return query.ToList();
        }

        //Измените определение класса в соответсвии с заданием
        public class userClass
        {

        }

        // На основе приведенного выше примера постройте свой запрос
        public IEnumerable<userClass> Query22()
        {
            return null;
        }


        // TODO 3
        // Упражнение 3. Упорядочивание данных
        public object Query3Example()
        {
            var query =
                 from st in context.Students
                 orderby st.Absences
                 select st;
            return query.ToList();
        }

        public object Query3()
        {
            return null;
        }

        // TODO 4 
        // Упражнение 4. Фильтрация данных
        public object Query4Example()
        {
            var query =
            from st in context.Students
            let goodAbcenses = st.Absences - st.UnreasonableAbsences
            where (st.Name == "Дмитро") && (goodAbcenses >= 10)
            select st;
            return query.ToList();
        }

        public object Query4()
        {
            return null;
        }

        // TODO 5 
        // Упражнение 5. Застосування мтодів розширення

        // Синтаксис запроса
        public object Query51Example()
        {
            var query =
            (
            from st in context.Students
            where st.Absences > 20
            orderby st.UnreadyLabs, st.Absences
            select new
            {
                Surnane = st.Surname,
                Absenses = st.Absences,
                UnreedyLabs = st.UnreadyLabs
            }
            ).Distinct();
            return query.ToList();
        }

        public object Query51()
        {
            return null;
        }

        // Синтаксис вызова методов
        public object Query52Example()
        {
            return
                context.Students.Where(s => s.Absences>20).Select (st => new
                {
                    Surnane = st.Surname,
                    Absenses = st.Absences,
                    UnreedyLabs = st.UnreadyLabs
                }
                ).OrderBy(s => s.UnreedyLabs).ThenBy(s => s.Absenses).Distinct()
                .ToList();
        }

        public object Query52()
        {
            return null;
        }

        // TODO 6
        // Вычисление агрегатных функций при помощи методов расширения и лямбда-выражений

        // TODO 6.1
        // Использование метода расширения с делегатом
        // Анонимный метод-делегат возвращает данные для обработки методом Max

        public int Query61Example()
        {
            return
            (
            from st in context.Students
            select st
            ).Max(
            delegate (Student Student)
            {
                return (int)Student.UnreadyLabs;
            }
            );
        }

        public double Query61()
        {
            return -1;
        }

        // TODO 6.2 
        // Использование метода лямбда-выражений

        public int Query62Example()
        {
            return
            (
            from st in context.Students
            select st
            ).Max(stt => (int)stt.UnreadyLabs);
        }

        public double Query62()
        {
            return -1;
        }

        // TODO 7
        // Комплексные выражения в соответсвии с вариантом задания

        public object ComplexQuery1()
        {
            return null;
        }

        public object ComplexQuery2()
        {
            return null;
        }

        public object ComplexQuery3()
        {
            return null;
        }

        /* Вопросы для подготовки:
         * Что такое LINQ-запрос?
         * Когда и как выполняется LINQ-запрос? Что такое отложенное выполнение?
         * Какие объекты могут быть источниками данных для LINQ-запроса?
         * Что обозначают термины:
         * - проекция
         * - анонимный тип
         * - метод расширения
         * - лямбда-выражение
         */
    }
}
