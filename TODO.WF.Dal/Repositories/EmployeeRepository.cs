using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.WF.Common;
using TODO.WF.Dal.Interfaces;
using TODO.WF.Model.Modal;

namespace TODO.WF.Dal.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<EmployeeModel> listEmployee = new List<EmployeeModel>() 
                                        { 
                                            new EmployeeModel() { ID = "1", LastName = "trang", FirstName = "Pham", Department = "PB1", Gender = 1},
                                        };
        public async Task<EmployeeModel> Add(EmployeeModel model)
        {
            try
            {
                var newEmp = new EmployeeModel() { ID = "1", LastName = "trang", FirstName = "Pham", Department = "PB1", Gender = 1};
                listEmployee.Add(newEmp);
                return newEmp;
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public Task<Status> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetDetail(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeModel>> GetList(string name, string lastName)
        {
            try
            {
                return listEmployee.Where(x => x.FirstName.Contains(name) || String.IsNullOrEmpty(name) || x.LastName.Contains(lastName) || String.IsNullOrEmpty(lastName)).ToList();
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
