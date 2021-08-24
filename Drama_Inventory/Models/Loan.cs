using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drama_Inventory.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int ItemID { get; set; } //Foreign Key

        public int StudentID { get; set; } //Foreign Key

        [DataType(DataType.Date)]
        public DateTime DateIssued { get; set; }

        public DateTime? DateReturned { get; set; } //Nullable type


        //Navigation properties
        public Item Item { get; set; }

        public Student Student { get; set; }
    }
}
