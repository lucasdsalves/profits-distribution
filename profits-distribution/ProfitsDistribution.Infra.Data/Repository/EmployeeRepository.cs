using Firebase.Database;
using Firebase.Database.Query;
using ProfitsDistribution.Domain.Entities;
using ProfitsDistribution.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfitsDistribution.Infra.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FirebaseClient _firebaseClient;
        private readonly string employeeCollectionKey = "employee";

        public EmployeeRepository(FirebaseClient firebaseClient)
        {
            _firebaseClient = firebaseClient;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var firebaseEmployees = await _firebaseClient.Child(employeeCollectionKey)
                                                         .OnceSingleAsync<List<Employee>>();

            return firebaseEmployees;
        }

        public async Task InsertAsync(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                await _firebaseClient.Child(employeeCollectionKey)
                                     .PostAsync<Employee>(employee);
            }
        }

        public async Task DeleteAsync()
        {
            await _firebaseClient.Child(employeeCollectionKey)
                                 .DeleteAsync();
        }
    }
}
