using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.DAL.IRepositories
{
    public interface IFromCityRepository
    {
        public List<FromCity> Get();

        public FromCity GetById(int fCityId);

        public FromCity Add(FromCity fromCity);

        public FromCity Update(FromCity fromCity);

        public void Delete(int fCityId);
    }
}
