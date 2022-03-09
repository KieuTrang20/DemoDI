using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDI.Services.Dt;
namespace DemoDI.Services
{
    public class StudentServices:IStudentServices
    {
        public List<Models> GetAll()
        {
            return new List<Models>
            {
                new Models{StudentId = 1,Name="Nguyen Van A"},
                new Models{StudentId = 2,Name="Nguyen Van B"},
                new Models{StudentId = 3,Name="Nguyen Van C"},
                new Models{StudentId = 4,Name="Nguyen Van D"},
            };
        }
    }
}
