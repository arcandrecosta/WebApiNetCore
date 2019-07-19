using BaltaStore.Domain.StoreContext.ValuesObjects;
using FluentValidator;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Custumer : Notifiable
    {

        private readonly IList<Address> _addresses;
        public Custumer(Name name, Document document, Email email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public Document Document { get; set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            //Validar Endereço
            //Adicionar Endereço
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }

    }
}