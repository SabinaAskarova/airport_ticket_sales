using MyProject.DTOs.ToCityDTOs;
using System.Collections.Generic;

namespace MyProject.BLL.IServices
{
    public interface IToCityService
    {
        public List<ToCityToListDTO> Get();
        public ToCityToListDTO Add(ToCityAddDTO toCityAddDTO);
        public ToCityToListDTO Update(ToCityToUpdateDTO toCityToUpdateDTO);
        public ToCityToListDTO GetById(int TCityId);
        public void Delete(int TCityId);
    }
}
