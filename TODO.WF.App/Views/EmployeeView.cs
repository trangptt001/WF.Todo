using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TODO.WF.Common;
using TODO.WF.Service;
using TODO.WF.Model.Modal;
using TODO.WF.Service.Services;
using TODO.WF.Service.InterfaceViews;

namespace TODO.WF.App.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        EmployeeService _service;
       
        
        public EmployeeView()
        {
            InitializeComponent();
        }
        public void SetService(EmployeeService service)
        {
            _service = service;
        }

        #region seter geter value on form
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EmployeeCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateOfBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Gender Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IEmployeeView.Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CanModifyID { set => throw new NotImplementedException(); }
        #endregion



        public void GetListEmployee(string name, string employeeCode)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }

        #region Events raised  back to controller

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._service.AddNewUser();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this._service.RemoveUser();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this._service.Save();
        }

        private void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.grdUsers.SelectedItems.Count > 0)
                this._service.SelectedUserChanged(this.grdUsers.SelectedItems[0].Text);
        }

        public void ClearGrid()
        {
            this.grdUsers.Columns.Clear();

            this.grdUsers.Columns.Add("Id", 150, HorizontalAlignment.Left);
            this.grdUsers.Columns.Add("First Name", 150, HorizontalAlignment.Left);
            this.grdUsers.Columns.Add("Lastst Name", 150, HorizontalAlignment.Left);
            this.grdUsers.Columns.Add("Department", 150, HorizontalAlignment.Left);
            this.grdUsers.Columns.Add("Gender", 50, HorizontalAlignment.Left);

            // Add rows to grid
            this.grdUsers.Items.Clear();
        }

        public void AddUserToGrid(EmployeeModel user)
        {
            ListViewItem parent;
            parent = this.grdUsers.Items.Add(user.ID);
            parent.SubItems.Add(user.FirstName);
            parent.SubItems.Add(user.LastName);
            parent.SubItems.Add(user.Department);
            parent.SubItems.Add(user.Gender.ToString());
        }

        public void UpdateGridWithChangedUser(EmployeeModel user)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserFromGrid(EmployeeModel user)
        {
            throw new NotImplementedException();
        }

        public string GetIdOfSelectedUserInGrid()
        {
            throw new NotImplementedException();
        }

        public void SetSelectedUserInGrid(EmployeeModel user)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
