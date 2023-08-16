using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.DTOs
{
    public class ProductDetailDto:IDto
    {
        private int productId;
        private string productName;
        private string categoryName;
        private short unitsInStock;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public short UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
    }
}
