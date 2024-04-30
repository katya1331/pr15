using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr15
{
    internal class Pocht
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public void ChangeAdres(string street, string city, string state, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
        public override string ToString()
        {
            return $"Улица: {Street}, Город: {City}, Область: {State}, Почтовый код: {PostalCode}";
        }
    }
}
