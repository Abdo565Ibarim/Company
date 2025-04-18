﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.GO2.DAL.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }

        public int? Age { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public decimal Salary { get; set; }

        public bool InActive {  get; set; }
        
        public bool InDeleted { get; set; }

        public DateTime HiringDate { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
