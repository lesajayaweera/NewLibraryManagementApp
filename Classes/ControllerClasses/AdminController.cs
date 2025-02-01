using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLibraryManagementApp.Classes.ControllerClasses
{
    internal class AdminController
    {
        private Admin admin = new Admin();
        public AdminController()
        {

        }

        public void login(string username, string role, string password ,Form form)
        {
            Admin admin = new Admin(username, role, password);
            admin.Login(admin, form);

        }
        public void register(string username, string email, string role, string password, string phoneNumber, Form form)
        {
            Admin admin = new Admin(username, email, role, password, phoneNumber);
            admin.Register(admin, form);
        }
        public void displayUser(string user , DataGridView data)
        {
            admin.DisplayUsers(user, data);

        }
        public void UpdateUserCredentials(int id,string name, string password, string role)
        {
             Admin admin = new Admin(name,role,password);

            bool validatepassword = admin.validatePassword();
            bool validatename = admin.Validateusername();

            bool isUsernameUsed = admin.isUsernameExist(admin);


            if (id > 0)
            {
                if(validatename)
                {
                    if (validatepassword)
                    {
                        if (isUsernameUsed)
                        {
                            admin.UpdateUserCredentials(id, admin);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select an user first ", "User selection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        } 

        public void DeleteUser(int id, string role)
        {
            
            if(id > 0)
            {
                admin.DeleteUser(id, role);
            }
        }

    }
}
