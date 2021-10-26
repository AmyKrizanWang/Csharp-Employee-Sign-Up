using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class EmployeeModel
    {

        //amycn1 This model is for Business Database Access Model, not the front end user filling form!!!
        //There is a "auto mapper" tool takes from one model automatic maps to other model
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }


    }
}
