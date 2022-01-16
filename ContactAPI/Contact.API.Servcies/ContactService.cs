using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Servcies
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            { 
                Id = Id,
                FirstName ="Mesut",
                LastName = "Kaya"            
            } ;
        }
    }
}
