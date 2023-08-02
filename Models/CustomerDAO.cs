using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjectService.Models
{
    public class CustomerDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<customer> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<customer> customers = db.customers.ToList();
            return customers;

        }

        public customer SelectByID(int id)
        {
            db.ObjectTrackingEnabled = false;
            customer customer = db.customers.SingleOrDefault(b => b.CusID == id);
            return customer;

        }

        public List<customer> SelectByKeyword(String keyword)
        {
            db.ObjectTrackingEnabled = false;
            List<customer> customers = db.customers.Where(b => b.CusName.Contains(keyword)).ToList();
            return customers;

        }

        public bool Insert(customer newcustomer)
        {
            try
            {
                db.ObjectTrackingEnabled = false;
                db.customers.InsertOnSubmit(newcustomer);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Update(customer newcustomer)
        {
            customer dbcustomer = db.customers.SingleOrDefault(b => b.CusID == newcustomer.CusID);
            if (dbcustomer != null)
            {
                try
                {
                    dbcustomer.CusName = newcustomer.CusName;
                    dbcustomer.BDate = newcustomer.BDate;
                    dbcustomer.Phone = newcustomer.Phone;
                    dbcustomer.Email = newcustomer.Email;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }

        public bool Delete(int ID)
        {
            customer dbcustomer = db.customers.SingleOrDefault(b => b.CusID == ID);
            if (dbcustomer != null)
            {
                try
                {
                    db.customers.DeleteOnSubmit(dbcustomer);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }
    }
}