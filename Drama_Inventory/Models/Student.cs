using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drama_Inventory.Models
{

    public enum YearLevel
    {
        Year_9, Year_10, Year_11, Year_12, Year_13
    }
    public class Student
    {
        public int StudentID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int RoomNo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public YearLevel YearLevel { get; set; }

        //Navigation Property
        public ICollection<Loan> Loan { get; set; }
    }
}
