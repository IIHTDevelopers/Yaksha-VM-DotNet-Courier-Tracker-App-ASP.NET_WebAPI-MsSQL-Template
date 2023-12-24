using CourierTrackerApp.DAL.Interrfaces;
using CourierTrackerApp.DAL.Services.Repository;
using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CourierTrackerApp.DAL.Services
{
    public class CourierTrackerService : ICourierTrackerService
    {
        private readonly ICourierTrackerRepository _repository;

        public CourierTrackerService(ICourierTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Courier> CreateCourier(Courier courier)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCourierById(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public List<Courier> GetAllCouriers()
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public Task<Courier> GetCourierById(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public Task<Courier> UpdateCourier(Courier model)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }
    }
}