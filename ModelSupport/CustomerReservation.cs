using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectService.ModelSupport
{
    public class CustomerReservation
    {
        public DateTime BDate { get; set; }
        public string CusName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateRes { get; set; }
        public int DepID { get; set; }
        public string Description { get; set; }
    }
}