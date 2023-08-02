using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjectService.Models
{
    
    public class DepartmentDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        public List<department> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<department> departments = db.departments.ToList();
            return departments;

        }

        public department SelectByID(int id)
        {
            db.ObjectTrackingEnabled = false;
            department department = db.departments.SingleOrDefault(b => b.DepID == id);
            return department;

        }

        public List<department> SelectByKeyword(String keyword)
        {
            db.ObjectTrackingEnabled = false;
            List<department> departments = db.departments.Where(b => b.DepName.Contains(keyword)).ToList();
            return departments;

        }

        public bool Insert(department newdepartment)
        {
            try
            {
                db.departments.InsertOnSubmit(newdepartment);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Update(department newdepartment)
        {
            department dbdepartment = db.departments.SingleOrDefault(b => b.DepID == newdepartment.DepID);
            if (dbdepartment != null)
            {
                try
                {
                    dbdepartment.DepName = newdepartment.DepName;
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }

        public bool Delete(int ID)
        {
            department dbdepartment = db.departments.SingleOrDefault(b => b.DepID == ID);
            if (dbdepartment != null)
            {
                try
                {
                    db.departments.DeleteOnSubmit(dbdepartment);
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;

        }
    }
}