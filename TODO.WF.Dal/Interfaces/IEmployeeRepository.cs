using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TODO.WF.Common;
using TODO.WF.Model.Modal;

namespace TODO.WF.Dal.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeModel>> GetList(string name, string employeeCode);
        Task<EmployeeModel> GetDetail(int id);
        Task<EmployeeModel> Add(EmployeeModel model);
        Task<Status> Delete(int id);
        
    }
}
