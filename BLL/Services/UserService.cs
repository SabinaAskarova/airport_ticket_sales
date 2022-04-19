using AutoMapper;
using MyProject.BLL.IServices;
using MyProject.DAL.IRepositories;
using MyProject.DAL.Repositories;
using MyProject.DTOs.UserDTOs;
using MyProject.Models;
using System.Collections.Generic;

namespace MyProject.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserToListDTO Add(UserToAddDTO userToAddDTO)
        {
            User user = _mapper.Map<User>(userToAddDTO);
            User addedUser = _userRepository.Add(user);
            return _mapper.Map<UserToListDTO>(addedUser);
        }

        public void Delete(int userId)
        {
            _userRepository.Delete(userId);
        }

        public List<UserToListDTO> Get()
        {
            List<User> listUser = _userRepository.Get();
            return _mapper.Map<List<UserToListDTO>>(listUser);
        }

        public UserToListDTO GetById(int userId)
        {
            return _mapper.Map<UserToListDTO>(_userRepository.GetById(userId));
        }

        public UserToListDTO Update(UserToUpdateDTO userToUpdateDTO)
        {
            User user = _mapper.Map<User>(userToUpdateDTO);
            User updatedUser = _userRepository.Update(user);
            return _mapper.Map<UserToListDTO>(updatedUser);
        }
    }
}
 