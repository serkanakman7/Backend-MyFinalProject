using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Order:IEntity
    {
        private int orderId;
        private string customerId;
        private int employeeId;
        private DateTime orderDate;
        private string shipCity;

        public int OrderId { get => orderId; set => orderId = value; }
        public string CustomerId { get => customerId; set => customerId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public string ShipCity { get => shipCity; set => shipCity = value; }
    }
}
