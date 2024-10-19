using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CareerService
    {
        private CareerRepository _careerRepository;
        public CareerService()
        {
            _careerRepository = new CareerRepository();
        }
        public DataTable GetAllCareers()
        {
            return _careerRepository.GetCareers();
        }
        public void AddCareer(Career career)
        {
            _careerRepository.AddCareer(career);
        }
        public void EditCareer(Career career)
        {
            _careerRepository.EditCareer(career);
        }
        public void DeleteCareer(int idCareer)
        {
            _careerRepository.DeleteCareer(idCareer);
        }
    }
}
