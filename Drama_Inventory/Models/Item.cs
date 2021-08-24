using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drama_Inventory.Models
{
    public class Item
    {
        public int ItemID { get; set; } // creates a primary key in the table for the SQL Database

        public string Name { get; set; }

        public decimal Price { get; set; }

        [Display(Name="Date Purchased")]
        public DateTime DatePurchased { get; set; }

        //relational database === tables that are related. one - one, one - many, many to many

        public ICollection<Loan> Loan { get; set; }
    }
}
