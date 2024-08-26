using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.DA
{
    public interface Istudent
    {
        List<Student> GetStudentRecords(int? studentId = null);
        
    }
}
