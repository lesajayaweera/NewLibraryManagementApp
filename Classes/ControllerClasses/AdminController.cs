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
        public void LoadOverDueBooks(DataGridView dataGridView)
        {
            BookController controller = new BookController();
            controller.LoadOverDueBooks(dataGridView);
        }

        public void SetPaidStatus(int overdueId, RadioButton paidCheckBox, RadioButton notPaidCheckBox)
        {
            BookController controller = new BookController();
            controller.setPaidStatus(overdueId, paidCheckBox, notPaidCheckBox);
        }
        public void UpdateOverdue(RadioButton paid, RadioButton notpaid,int overdueId,DataGridView grid)
        {
            bool ispaid = false;

            if (paid.Checked)
            {
                ispaid = true;
            }
            else if (notpaid.Checked)
            {
                ispaid = false;
            }

            BookController controller = new BookController();
            bool isUpdated = controller.UpdateOverDueStatus(overdueId, ispaid);
            if (isUpdated)
            {
               LoadOverDueBooks(grid);
            }
        }
        public string GetMostActiveUser()
        {
            return admin.GetMostActiveUser();
        }
        public string GetMostBorrowedBook()
        {
            return admin.GetMostBorrowedBook();
        }

        public void DisplayTables(DataGridView borrowings, DataGridView reservations)
        {
            admin.LoadLibraryBorrowings(borrowings);
            admin.LoadLibraryReservations(reservations);
        }

        public string GetBookCount()
        {
           return admin.GetBookCount().ToString();
        }

        public string GetOverdueBookCount()
        {
            return admin.GetOverdueBookCount().ToString();
        }
        public string GetBorrowedBookCount()
        {
            return admin.GetBorrowedBookCount().ToString();
        }

        public void DisplayBooks(DataGridView grid)
        {
            BookController controller = new BookController();
            controller.DisplayBooks(grid);
        }
    }
}
