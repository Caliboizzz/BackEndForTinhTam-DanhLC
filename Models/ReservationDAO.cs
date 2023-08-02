using ProjectService.ModelSupport;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjectService.Models
{
    public class ReservationDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<reservation> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<reservation> reservations = db.reservations.ToList();
            return reservations;

        }

        public reservation SelectByID(int id)
        {
            db.ObjectTrackingEnabled = false;
            reservation reservation = db.reservations.SingleOrDefault(b => b.CusID == id);
            return reservation;

        }

        public List<reservation> SelectByKeyword(String keyword)
        {
            db.ObjectTrackingEnabled = false;
            List<reservation> reservations = db.reservations.Where(b => b.customer.CusName.Contains(keyword)).ToList();
            return reservations;

        }

        public bool Insert(CustomerReservation model)
        {
            try
            {
                customer cus = new customer();
                cus.CusName = model.CusName;
                cus.Email = model.Email;
                cus.Phone = model.Phone;
                cus.BDate = model.BDate;
                db.customers.InsertOnSubmit(cus);
                db.SubmitChanges();

                reservation res = new reservation();
                res.DateRes = model.DateRes;
                res.Description = model.Description;
                res.DepID = model.DepID;
                res.CusID = cus.CusID;
                db.reservations.InsertOnSubmit(res);
                db.SubmitChanges();

                return true;
            }
            catch { return false; }

        }
    }
}