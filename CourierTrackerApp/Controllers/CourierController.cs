using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CourierTrackerApp.Controllers
{
    public class CourierController : ApiController
    {
        private readonly ICourierTrackerService _service;
        public CourierController(ICourierTrackerService service)
        {
            _service = service;
        }
        public CourierController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Courier/CreateCourier")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateCourier([FromBody] Courier model)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Courier/UpdateCourier")]
        public async Task<IHttpActionResult> UpdateCourier([FromBody] Courier model)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Courier/DeleteCourier")]
        public async Task<IHttpActionResult> DeleteCourier(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Courier/GetCourierById")]
        public async Task<IHttpActionResult> GetCourierById(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Courier/GetAllCouriers")]
        public async Task<IEnumerable<Courier>> GetAllCouriers()
        {
            //Write Your Code here
            throw new NotImplementedException();
        }
    }
}
