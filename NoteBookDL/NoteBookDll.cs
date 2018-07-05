using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBookDL
{
    public class NoteBookDll
    {
        public void Create(string fio, DateTime dob, string telephone, string email)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                People vovan = new People()
                {
                    FIO = fio,
                    DateOfBirthday = dob,
                    Telephone = telephone,
                    Email = email
                };
                db.Peoples.Add(vovan);
                db.SaveChanges();
            }
        }
        //Удаление записи
        public void Delete(int Id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var people = db.Peoples
                    .Where(u => u.Id == Id)
                    .FirstOrDefault();
                if (people != null)
                {
                    db.Peoples.Remove(people);
                    db.SaveChanges();
                }
            }

        }
        //Редактирование записи
        public void Edit(int id, string fio, DateTime dob, string telephone, string email)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var people = db.Peoples
                    .Where(u => u.Id == id)
                    .FirstOrDefault();
                if (people != null)
                {
                    people.Telephone = telephone;
                    people.FIO = fio;
                    people.Email = email;
                    people.DateOfBirthday = dob;
                    db.SaveChanges();
                }
            }
        }
        //Извлечение всех записией
        public List<People> GetAllPeople()
        {
            List<People> peoples;
            using (DataBaseContext db = new DataBaseContext())
            {
                peoples = db.Peoples.ToList<People>();
            }
            return peoples;
        }
    }
}
