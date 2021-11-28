using AutoMapper;
using Firebase.Database;
using Firebase.Database.Query;
using ProfitsDistribution.Domain.DTO;
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
        private readonly IMapper _mapper;

        public EmployeeRepository(FirebaseClient firebaseClient, IMapper mapper)
        {
            _firebaseClient = firebaseClient;
            _mapper = mapper;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var firebaseEmployees = await _firebaseClient.Child(employeeCollectionKey)
                                                         .OnceSingleAsync<List<EmployeeDto>>();

            return _mapper.Map<List<Employee>>(firebaseEmployees);
        }
    }
}
