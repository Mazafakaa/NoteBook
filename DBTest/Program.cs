using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteBookDL;
using System.Threading.Tasks;

namespace DBTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DataBaseContext db = new DataBaseContext();
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Артемьев Данаил Викторович", DateOfBirthday = DateTime.Now, Email = "artemev_dv@outlook.com", Telephone = "89649785845" });
            db.Peoples.Add(new People() { FIO = "Величко Владимир Сергеевич", DateOfBirthday = DateTime.Now, Email = "velichko_vs@outlook.com", Telephone = "89145469254" });
            db.Peoples.Add(new People() { FIO = "Колесник Александр Викторович", DateOfBirthday = DateTime.Now, Email = "kolesnik_as@outlook.com", Telephone = "89295847565" });
            db.Peoples.Add(new People() { FIO = "Заика Александр Сергеевич", DateOfBirthday = DateTime.Now, Email = "zaika_as@outlook.com", Telephone = "89184578519" });
            db.Peoples.Add(new People() { FIO = "Гура Ромен Валерьевич", DateOfBirthday = DateTime.Now, Email = "gura_rv@outlook.com", Telephone = "89132154846" });
            db.Peoples.Add(new People() { FIO = "Просветов Алексей Вассерманович", DateOfBirthday = DateTime.Now, Email = "prosvetov5@outlook.com", Telephone = "89784858695" });
            db.SaveChanges();
            List<People> peoples = db.Peoples.ToList<People>();
            Console.WriteLine("Добавлены: ");
            foreach(var t in peoples)
            {
                Console.WriteLine("Пользователь № " + t.Id + " фио: " + t.FIO + " дата рождения: " + t.DateOfBirthday + " email: " + t.Email);
            }
            Console.ReadKey();
        }
    }
}
