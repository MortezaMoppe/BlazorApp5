using System;

using BlazorAcademy.Models;



namespace BlazorAcademy.Services
{
    public interface IStudentApplicationService
    {
        Task<List<StudentApplication>> GetStudentApplications();
        Task AddStudentApplication(StudentApplication application);
        Task DeleteStudentApplication(int id);
    }

    public class StudentApplicationService : IStudentApplicationService
    {
        private List<StudentApplication> applications =new List<StudentApplication>();
        public async Task<List<StudentApplication>> GetStudentApplications()
        {
            await Task.Delay(100);
            return applications;
        }
        public async Task AddStudentApplication(StudentApplication application)
        {
            await Task.Delay(100);
            application.Id = applications.Count + 1;
            applications.Add(application);
        }

        public async Task DeleteStudentApplication(int id)
        {
            await Task.Delay(100);
            applications.RemoveAll(a => a.Id == id);
        }
    }

}
