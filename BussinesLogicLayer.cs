using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTestVideo
{
    class BussinesLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;
        
        public BussinesLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();

        }

        public Contact Save(Contact contact)
        {

            if (contact.Id == 0)
            {
                 _dataAccessLayer.InsertContact(contact);
            }
            else
            {
                _dataAccessLayer.UpdateContact(contact);
            }

            return contact;
        }

        public void Delete(Contact contact)
        {
             _dataAccessLayer.Delete(contact);
        }

        internal List<Contact> GetContacts()
        {
            return _dataAccessLayer.GetContacts();
        }
    }
}
