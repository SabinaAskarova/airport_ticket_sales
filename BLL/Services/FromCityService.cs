using AutoMapper;
using MyProject.BLL.IServices;
using MyProject.DAL.IRepositories;
using MyProject.DTOs.FromCityDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.BLL.Services
{
    public class FromCityService: IFromCityService
    {
        private readonly IFromCityRepository _fromCityRepository;
        private readonly IMapper _mapper;

        public FromCityService(IFromCityRepository fromCityRepository, IMapper mapper)
        {
            _fromCityRepository = fromCityRepository;
            _mapper = mapper;
        }

        public FromCityToListDTO Add(FromCityToAddDTO fromCityToAddDTO)
        {
            FromCity fromCity = _mapper.Map<FromCity>(fromCityToAddDTO);
            FromCity addedFcity= _fromCityRepository.Add(fromCity);
            return _mapper.Map<FromCityToListDTO>(addedFcity);
        }

        public void Delete(int FCityId)
        {
            _fromCityRepository.Delete(FCityId);
        }

        public List<FromCityToListDTO> Get()
        {
            return _mapper.Map<List<FromCityToListDTO>>(_fromCityRepository.Get());
        }

        public FromCityToListDTO GetById(int FCityId)
        {
            FromCity fromCity = _fromCityRepository.GetById(FCityId);
            return _mapper.Map<FromCityToListDTO>(fromCity);
        }

        public FromCityToListDTO Update(FromCityToUpdateDTO fromCityToUpdateDTO)
        {
            FromCity fromCity = _mapper.Map<FromCity>(fromCityToUpdateDTO);
            FromCity updatedFcity = _fromCityRepository.Update(fromCity);
            return _mapper.Map<FromCityToListDTO>(updatedFcity);
        }
    }
}
