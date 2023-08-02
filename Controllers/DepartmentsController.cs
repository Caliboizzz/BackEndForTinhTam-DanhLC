using ProjectService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DepartmentsController : ApiController
    {
        [HttpGet]
        [Route("api/departments")]
        public List<department> GetAll()
        {
            List<department> departments = new DepartmentDAO().SelectAll();
            return departments;
        }

        [HttpGet]
        [Route("api/departments/{ID}")]
        public department GetDetails(int ID)
        {
            department department = new DepartmentDAO().SelectByID(ID);
            return department;
        }

        [HttpGet]
        [Route("api/departments/search/{keyword}")]
        public List<department> Search(String keyword)
        {
            List<department> departments = new DepartmentDAO().SelectByKeyword(keyword);
            return departments;
        }

        [HttpPost]
        [Route("api/departments")]
        public bool AddNew(department newdepartment)
        {
            bool result = new DepartmentDAO().Insert(newdepartment);
            return result;
        }

        [HttpPut]
        [Route("api/departments/{ID}")]
        public bool Update(department newdepartment)
        {
            bool result = new DepartmentDAO().Update(newdepartment);
            return result;
        }

        [HttpDelete]
        [Route("api/departments/{ID}")]
        public bool Delete(int ID)
        {
            bool result = new DepartmentDAO().Delete(ID);
            return result;
        }
    }
}