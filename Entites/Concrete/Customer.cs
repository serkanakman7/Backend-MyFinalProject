using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Customer:IEntity
    {
        private string customerId;
        private string contactName;
        private string companyName;
        private string city;

        public string CustomerId { get => customerId; set => customerId = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string City { get => city; set => city = value; }
    }
}
