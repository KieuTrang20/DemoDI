using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDI.Services;
using DemoDI.Services.Dt;

namespace DemoDI.Services
{
    public interface IStudentServices
    {
        List<Models> GetAll();
    }
}
