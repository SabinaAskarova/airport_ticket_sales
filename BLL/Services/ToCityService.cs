using AutoMapper;
using MyProject.BLL.IServices;
using MyProject.DAL.IRepositories;
using MyProject.DTOs.ToCityDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.BLL.Services
{
    public class ToCityService:IToCityService
    {
        private readonly IToCityRepository _toCityRepository;
        private readonly IMapper _mapper;

        public ToCityService(IToCityRepository toCityRepository, IMapper mapper)
        {
            _toCityRepository = toCityRepository;
            _mapper = mapper;
        }

        public ToCityToListDTO Add(ToCityAddDTO toCityAddDTO)
        {
            ToCity toCity = _mapper.Map<ToCity>(toCityAddDTO);
            ToCity addedTcity = _toCityRepository.Add(toCity);
            return _mapper.Map<ToCityToListDTO>(addedTcity);
        }

        public void Delete(int TCityId)
        {
            _toCityRepository.Delete(TCityId);
        }

        public List<ToCityToListDTO> Get()
        {
            return _mapper.Map<List<ToCityToListDTO>>(_toCityRepository.Get());
        }

        public ToCityToListDTO GetById(int TCityId)
        {
            ToCity toCity = _toCityRepository.GetById(TCityId);
            return _mapper.Map<ToCityToListDTO>(toCity);
        }

        public ToCityToListDTO Update(ToCityToUpdateDTO toCityToUpdateDTO)
        {
            ToCity toCity = _mapper.Map<ToCity>(toCityToUpdateDTO);
            ToCity updatedTcity = _toCityRepository.Update(toCity);
            return _mapper.Map<ToCityToListDTO>(updatedTcity);
        }
    }
}
