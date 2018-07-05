using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteBookDL;

namespace Notebook
{
    public interface IMainController
    {
        List<People> GetPeopleList();
        List<People> CreatePeople(string fio, DateTime dob, string telephone, string email);
        List<People> DelPeople(int id);
        List<People> EditPeople(int id, string fio, DateTime dob, string telephone, string email);

    }

    class MainController : IMainController
    {
        private static NoteBookDll mod = new NoteBookDll();
        public List<People> CreatePeople(string fio, DateTime dob, string telephone, string email)
        {
            try
            {
                mod.Create(fio, dob, telephone, email);
                return mod.GetAllPeople();
                
            }
            catch(Exception ex)
            {
                MessageService.ShowMessage(ex);
                return null;
            }
        }

        public List<People> DelPeople(int id)
        {
            try
            {
                mod.Delete(id);
                return mod.GetAllPeople();
            }
            catch (Exception ex)
            {
                MessageService.ShowMessage(ex);
                return null;
            }
        }

        public List<People> EditPeople(int id, string fio, DateTime dob, string telephone, string email)
        {
            try
            {
                mod.Edit(id, fio, dob, telephone, email);
                return mod.GetAllPeople();
            }
            catch (Exception ex)
            {
                MessageService.ShowMessage(ex);
                return null;
            }
        }

        public List<People> GetPeopleList()
        {
            try
            {
                return mod.GetAllPeople();
            }
            catch (Exception ex)
            {
                MessageService.ShowMessage(ex);
                return null;
            }
        }
        
    }
}
