using CourierTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CourierTrackerApp.DAL.Services.Repository
{
    public class CourierTrackerRepository : ICourierTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public CourierTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Courier> CreateCourier(Courier courier)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteCourierById(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public List<Courier> GetAllCouriers()
        {
            //Write Your Code here
            throw new NotImplementedException();
        }

        public async Task<Courier> GetCourierById(long id)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }       

        public async Task<Courier> UpdateCourier(Courier model)
        {
            //Write Your Code here
            throw new NotImplementedException();
        }
    }
}