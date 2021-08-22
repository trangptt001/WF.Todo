using TODO.WF.Service.InterfaceViews;
using TODO.WF.Model.Modal;
using System.Collections.Generic;
using TODO.WF.Dal.Interfaces;

namespace TODO.WF.Service.Services
{
    public class EmployeeService
    {
        IEmployeeView _view;
        IEmployeeRepository _repository;
        public EmployeeService(IEmployeeView view, IEmployeeRepository repository)
        {
            _repository = repository;
            _view = view;
            _view.SetService(this);
        }
        private void updateViewDetailValues(EmployeeModel usr)
        {
            //_view.FirstName = usr.FirstName;
            //_view.LastName = usr.LastName;
            //_view.ID = usr.ID;
            //_view.Department = usr.Department;
            //_view.Sex = usr.Sex;
        }

        private void updateUserWithViewValues(EmployeeModel usr)
        {
            //usr.FirstName = _view.FirstName;
            //usr.LastName = _view.LastName;
            //usr.ID = _view.ID;
            //usr.Department = _view.Department;
            //usr.Sex = _view.Sex;
        }


        public void LoadView()
        {
            var _result = _repository.GetList("", "").Result;
            _view.ClearGrid();
            foreach (EmployeeModel usr in _result)
                _view.AddUserToGrid(usr);

            //_view.SetSelectedUserInGrid((User)_users[0]);

        }

        public void SelectedUserChanged(string selectedUserId)
        {
            //foreach (EmployeeModel usr in this._users)
            //{
            //    if (usr.ID == selectedUserId)
            //    {
            //        _selectedUser = usr;
            //        updateViewDetailValues(usr);
            //        _view.SetSelectedUserInGrid(usr);
            //        this._view.CanModifyID = false;
            //        break;
            //    }
            //}
        }


        public void AddNewUser()
        {
           
        }

        public void RemoveUser()
        {
           
        }

        public void Save()
        {

        }
    }
}
