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
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.Peoples.Add(new People() { FIO = "Коньков Влас Викторович", DateOfBirthday = DateTime.Now, Email = "vvkonkov05@outlook.com", Telephone = "89189365854" });
            db.SaveChanges();
            List<People> peoples = db.Peoples.ToList<People>();
            foreach(var t in peoples)
            {
                Console.WriteLine("Пользователь № " + t.Id + " фио: " + t.FIO + " дата рождения: " + t.DateOfBirthday + " email: " + t.Email);
            }

        }
    }
}
