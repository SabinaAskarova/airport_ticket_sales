using MyProject.DTOs.FromCityDTOs;
using System.Collections.Generic;

namespace MyProject.BLL.IServices
{
    public interface IFromCityService
    {
        public List<FromCityToListDTO> Get();
        public FromCityToListDTO Add(FromCityToAddDTO fromCityToAddDTO);
        public FromCityToListDTO Update(FromCityToUpdateDTO fromCityToUpdateDTO);
        public FromCityToListDTO GetById(int FCityId);
        public void Delete(int FCityId);
    }
}
