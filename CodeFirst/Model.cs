using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst
{
    public class Model
    {
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public byte[] Photo { get; set; }

        public override string ToString()
        {
            string s = Name + ", электронный адрес: " + Email;
            return s;
        }
        // Ссылка на заказы
        public virtual List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Ссылка на покупателя
        public Customer Customer { get; set; }

        public override string ToString()
        {
            string s = ProductName + " " + Quantity + "шт., дата: " + PurchaseDate;
            return s;
        }

    }
    [Table("VipOrders")] 
    public class VipOrder : Order
    {
        public string status { get; set; }
    }

}
