using HRWebAPI.Models;

namespace HRWebAPI.Services
{
    public interface IUsersInformationService
    {
        Task<bool> CreateUsersInformation(UsersInformation usersInformation);
        //Task<List<UsersInformation>> GetUsersInformationList();
        //Task<UsersInformation> UpdateUsersInformation(UsersInformation usersInformation);
        //Task<bool> DeleteUsersInformation(int key);
    }
}
