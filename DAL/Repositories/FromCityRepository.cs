using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.DAL.Repositories
{
    public class FromCityRepository:IFromCityRepository
    {
        private readonly TestDbContext _ctx;
        public FromCityRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public FromCity Add(FromCity fromCity)
        {
            _ctx.FromCities.Add(fromCity);
            _ctx.SaveChanges();
            return fromCity;
        }

        public void Delete(int fCityId)
        {
            FromCity fromCity = _ctx.FromCities.Find(fCityId);
            fromCity.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<FromCity> Get()
        {
            return _ctx.FromCities.OrderBy(m => m.FCityId).ToList();
        }

        public FromCity GetById(int fCityId)
        {
            FromCity fromCity = _ctx.FromCities.Find(fCityId);
            return fromCity;
        }

        public FromCity Update(FromCity fromCity)
        {
            _ctx.FromCities.Update(fromCity);
            _ctx.SaveChanges();
            return fromCity;
        }
    }
}
