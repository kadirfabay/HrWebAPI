using HRWebAPI.Models;
using HRWebAPI.Services;

namespace HRWebAPI.Services
{
    public class UsersInformationService : IUsersInformationService
    {
        private readonly IDbService _dbService;

        public UsersInformationService(IDbService dbService)
        {
            _dbService = dbService;
        }
        public async Task<bool> CreateUsersInformation(UsersInformation usersInformation)
        {
            //var result =
            //    await _dbService.EditData(
            //        @"INSERT INTO public.hr_job_information(

            //          cv_id, name, surname, birthday, email, phone, gender, city)

            //          VALUES(@CvId, @Name, @Surname, @Birthday,@Email,@Phone,@Gender,@City)",
            //        usersInformation);

            //string contactMethod = usersInformation.ContactPrefence ? "Email" : "Telefon";

            var result = await _dbService.EditData(

                @"INSERT INTO public.hr_information
                (name, surname, birthday, section, contact_prefence, email, phone, city, adress, data)
                VALUES
                (@Name, @Surname, @Birthday, @Section, @ContactPrefence, @Email, @Phone, @City, @Adress, @Resume)",
                new
                {
                    Name = usersInformation.Name,
                    Surname = usersInformation.Surname,
                    Birthday = usersInformation.Birthday,
                    Section = usersInformation.Section,
                    ContactPrefence = usersInformation.ContactPrefence,
                    Email = usersInformation.Email,
                    Phone = usersInformation.Phone,
                    City = usersInformation.City,
                    Adress = usersInformation.Adress,
                    Resume = usersInformation.Resume
                });
            return true;
        }
        #region
        //public async Task<List<Employee>> GetEmployeeList()
        //{
        //    var employeeList = await _dbService.GetAll<Employee>("SELECT * FROM public.employee", new { });
        //    return employeeList;
        //}


        //public async Task<Employee> GetEmployee(int id)
        //{
        //    var employeeList = await _dbService.GetAsync<Employee>("SELECT * FROM public.employee where id=@id", new { id });
        //    return employeeList;
        //}

        //public async Task<Employee> UpdateEmployee(Employee employee)
        //{
        //    var updateEmployee =
        //        await _dbService.EditData(
        //            "Update public.employee SET name=@Name, age=@Age, address=@Address, mobile_number=@MobileNumber WHERE id=@Id",
        //            employee);
        //    return employee;
        //}

        //public async Task<bool> DeleteEmployee(int id)
        //{
        //    var deleteEmployee = await _dbService.EditData("DELETE FROM public.employee WHERE id=@Id", new { id });
        //    return true;
        //}
        #endregion
    }
}
