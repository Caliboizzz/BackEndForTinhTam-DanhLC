using ProjectService.Models;
using ProjectService.ModelSupport;
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
    public class ReservationsController : ApiController
    {
        [HttpGet]
        [Route("api/reservations")]
        public List<reservation> GetAll()
        {
            List<reservation> reservations = new ReservationDAO().SelectAll();
            return reservations;
        }

        [HttpGet]
        [Route("api/reservations/{ID}")]
        public reservation GetDetails(int ID)
        {
            reservation reservation = new ReservationDAO().SelectByID(ID);
            return reservation;
        }

        [HttpGet]
        [Route("api/reservations/search/{keyword}")]
        public List<reservation> Search(String keyword)
        {
            List<reservation> reservations = new ReservationDAO().SelectByKeyword(keyword);
            return reservations;
        }

        [HttpPost]
        [Route("api/reservations")]
        public bool AddNew(CustomerReservation model)
        {
            bool result = new ReservationDAO().Insert(model);
            return result;
        }
    }
}