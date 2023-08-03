using ControlStudentsPayment.Data;
using ControlStudentsPayment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStudentsPayment.Services
{
    public class StudentService : AbstractService<Student>
    {
        public StudentService(DatabaseContext context) : base(context)
        {
            
        }
    }
}
