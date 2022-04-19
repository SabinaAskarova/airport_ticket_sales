using MyProject.DTOs.UserDTOs;
using System.Collections.Generic;

namespace MyProject.BLL.IServices
{
    public interface IUserService
    {
        public List<UserToListDTO> Get();
        public UserToListDTO Add(UserToAddDTO userToAddDTO);
        public UserToListDTO Update(UserToUpdateDTO userToUpdateDTO);
        public UserToListDTO GetById(int userId);
        public void Delete(int userId);
    }
}
