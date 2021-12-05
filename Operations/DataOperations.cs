using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class DataOperations
    {
        public static void LoadData()
        {
            using (AppContext db = new AppContext())
            {
                var listStudents = new List<Student>
                {
                    new Student() { Name = "Елена", Surname = "Папанова", Email = "ElenaPapanova@mail.ru", Group = new Group() { Number = "Grp-1", Course = "C#.Professional"}},
                    new Student() { Name = "Дмитрий", Surname = "Портнов", Email = "DmitriyPortnov@gmail.com", Group = new Group() { Number = "Grp-2", Course = "PowerBI.Professional"}},
                    new Student() { Name = "Ольга", Surname = "Маркова", Email = "OlgaMarkova@yandex.ru", Group = new Group() { Number = "Grp-3", Course = "Database Developer"}},
                    new Student() { Name = "Александр", Surname = "Тулупов", Email = "AleksandrTulupov@yahoo.com", Group = new Group() { Number = "Grp-4", Course = "ASP.NET"}},
                    new Student() { Name = "Татьяна", Surname = "Беседина", Email = "TatianaBesedina@inbox.ru", Group = new Group() { Number = "Grp-5", Course = "DevOps"}}
                };

                db.Students.AddRange(listStudents);
                db.SaveChanges();

                var listScheduler = new List<Scheduler>
                {
                    new Scheduler() { Date = Convert.ToDateTime("10/12/2021 20:00:00"), GroupId = 1, Teacher = new Teacher() { Name = "Алексей", Surname = "Тимофеев", Email = "AlekseyTimofeev@otus.ru"}},
                    new Scheduler() { Date = Convert.ToDateTime("11/12/2021 20:00:00"), GroupId = 2, Teacher = new Teacher() { Name = "Артем", Surname = "Щукин", Email = "ArtemSchukin@otus.ru"}},
                    new Scheduler() { Date = Convert.ToDateTime("12/12/2021 20:00:00"), GroupId = 3, Teacher = new Teacher() { Name = "Олег", Surname = "Кузнецов", Email = "OlegKuznetsov@otus.ru"}},
                    new Scheduler() { Date = Convert.ToDateTime("13/12/2021 20:00:00"), GroupId = 4, Teacher = new Teacher() { Name = "Федор", Surname = "Пустовалов", Email = "FedorPustovalov@otus.ru"}},
                    new Scheduler() { Date = Convert.ToDateTime("14/12/2021 20:00:00"), GroupId = 5, Teacher = new Teacher() { Name = "Юлия", Surname = "Корытова", Email = "JuliaKorytova@otus.ru"}}
                };

                db.Scheduler.AddRange(listScheduler);
                db.SaveChanges();
            }
        }

        public static void RemoveAllData()
        {
            using (AppContext db = new AppContext())
            {
                db.Database.ExecuteSqlRaw($"TRUNCATE TABLE public.\"Scheduler\" RESTART IDENTITY CASCADE; ");
                db.Database.ExecuteSqlRaw($"TRUNCATE TABLE public.\"Students\" RESTART IDENTITY CASCADE; ");
                db.Database.ExecuteSqlRaw($"TRUNCATE TABLE public.\"Teachers\" RESTART IDENTITY CASCADE; ");
                db.Database.ExecuteSqlRaw($"TRUNCATE TABLE public.\"Groups\" RESTART IDENTITY CASCADE; ");
            }
        }
    }
}
