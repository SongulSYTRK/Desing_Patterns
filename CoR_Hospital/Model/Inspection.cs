using System;
using System.Collections.Generic;
using System.Text;

namespace CoR_Hospital.Model
{
   public  class Inspection
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public Inspection()
        {
                
        }
        //public Inspection(int id, string name, decimal price)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Price = price;
        //}
    }
}
