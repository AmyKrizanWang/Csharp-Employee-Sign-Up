using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;

namespace DataLibrary.BusinessLogic
{

    //amycn1 not storing data here, this function is just to processing data

    public static class EmployeeProcessor
    {
        //passing 4 values in
        public static int CreateEmployee(int employeeId, String firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                //Mapping the models from one to other
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress

            };
            //this is parameterized sql 
            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress) 
                            values (@EmployeeId, @FirstName, @LastName, @EmailAddress)";

            return SqlDataAcess.SaveData(sql, data);

        }
        //data strings List
        public static List<EmployeeModel> LoadEmployees()
        {

            //sql statement
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress from dbo.Employee;";

            return SqlDataAcess.LoadData<EmployeeModel>(sql);
        }
    }
}
