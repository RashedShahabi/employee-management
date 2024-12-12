using ContactProject.Utils;
using ContactProject_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject_DataLayer
{
    public class ContactViewModel
    {
        public string ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public string Birthdate { get; private set; }
        public ContactViewModel(Contact contact)
        {
            ID = contact.ID;
            FirstName = contact.FirstName;
            LastName = contact.LastName;
            Gender = contact.Gender ? "مذکر" : "مونث";
            Birthdate = DateConverter.ToHejriShamsi(contact.Birthdate);
        }
    }
}
