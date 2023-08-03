using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class StaffFactory
    {
        public static List<Staff> LoadUsers()
        {
            string sql = @"SELECT *
                          FROM [dbo].[Staff]";

            return SqlDataAccess.LoadData<Staff>(sql);
        }

        public static Staff GetStaff(int id)
        {
            string sql = @"SELECT *
                          FROM [dbo].[Staff]
                          WHERE [EmployeeID] = @EmployeeID";

            Staff StaffMod = new Staff()
            {
                EmployeeID = id
            };

            return SqlDataAccess.GetData<Staff>(sql, StaffMod);
        }

        public static Staff LoginStaff(string username, string pass)
        {
            string sql = @"SELECT *
                          FROM [dbo].[Staff]
                          WHERE [Username] = @Username AND [Password] = @Password";

            Staff StaffMod = new Staff()
            {
                Username = username,
                Password = pass
            };

            return SqlDataAccess.GetData<Staff>(sql, StaffMod);
        }

        public static bool AddUser(Staff staff)
        {
            string sql = @"INSERT INTO [dbo].[Staff]
                                   ([EmployeeName]
                                   ,[EmployeeSurname]
                                   ,[Role]
                                   ,[Username]
                                   ,[Password])
                             VALUES
                                   (@EmployeeName
                                   ,@EmployeeSurname
                                   ,@Role
                                   ,@Username
                                   ,@Password)

                            SELECT SCOPE_IDENTITY();";

            return SqlDataAccess.SaveDataReturn<Staff>(sql, staff) > 0;
        }

        public static int UpdateUser(Staff newStaff)
        {
            string sql = @"UPDATE [dbo].[Staff]
                           SET [EmployeeName] = @EmployeeName
                              ,[EmployeeSurname] = @EmployeeSurname
                              ,[Role] = @Role
                              ,[Username] = @Username
                              ,[Password] = @Password
                            WHERE [EmployeeID] = @EmployeeID";

            return SqlDataAccess.SaveData<Staff>(sql, newStaff);
        }

        public static int ReadUserNo()
        {
            string sql = @"SELECT TOP 1 [UserID] FROM [dbo].[User] ORDER BY [UserID] DESC";

            return SqlDataAccess.GetDataReturn<int>(sql);
        }
    }
}
