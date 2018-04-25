using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3342DevStepFinal
{
    public class Customer
    {
        public string fullName { get; set; }
        public string address { get; set; }
        public long ccNumber { get; set; }
        public string expire { get; set; }

        public int secureCode { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}