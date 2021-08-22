using System;
using System.Collections.Generic;
using System.Text;
using TODO.WF.Common;
using TODO.WF.Model.Modal;
using TODO.WF.Service.Services;

namespace TODO.WF.Service.InterfaceViews
{
    public interface IEmployeeView
    {
        //action
        void SetService(EmployeeService service);
        void ClearGrid();
        void AddUserToGrid(EmployeeModel user);
        void UpdateGridWithChangedUser(EmployeeModel user);
        void RemoveUserFromGrid(EmployeeModel user);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedUserInGrid(EmployeeModel user);

        string FirstName { get; set; }
        string LastName { get; set; }
        string ID { get; set; }
        string Department { get; set; }
        int Gender { get; set; }
        bool CanModifyID { set; }
    }
}
