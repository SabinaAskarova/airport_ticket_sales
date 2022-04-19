using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.DAL.IRepositories
{
    public interface IToCityRepository
    {
        public List<ToCity> Get();

        public ToCity GetById(int tCityId);

        public ToCity Add(ToCity toCity);

        public ToCity Update(ToCity toCity);

        public void Delete(int tCityId);
    }
}
