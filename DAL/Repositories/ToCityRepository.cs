using MyProject.DAL.DataContext;
using MyProject.DAL.IRepositories;
using MyProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.DAL.Repositories
{
    public class ToCityRepository:IToCityRepository
    {
        private readonly TestDbContext _ctx;
        public ToCityRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ToCity Add(ToCity toCity)
        {
            _ctx.ToCities.Add(toCity);
            _ctx.SaveChanges();
            return toCity;
        }

        public void Delete(int tCityId)
        {
            ToCity toCity= _ctx.ToCities.Find(tCityId);
            toCity.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<ToCity> Get()
        {
            return _ctx.ToCities.OrderBy(m => m.TCityId).ToList();
        }

        public ToCity GetById(int tCityId)
        {
            ToCity toCity = _ctx.ToCities.Find(tCityId);
            return toCity;
        }

        public ToCity Update(ToCity toCity)
        {
            _ctx.ToCities.Update(toCity);
            _ctx.SaveChanges();
            return toCity;
        }
    }
}
