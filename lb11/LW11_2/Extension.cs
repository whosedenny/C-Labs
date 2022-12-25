using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LW11_2.Program;

namespace LW11_2
{
    public static class Extension
    {
        internal static  List<Student> FindStudent(this List<Student> students, StudentPredicateDelegate studentPredicateDelegate) 
        {
            List<Student> result = new List<Student>();

            for (int i = 0; i < students.Count; i++)
            {
                if (studentPredicateDelegate(students[i]))
                {
                    result.Add(students[i]);
                }
            }

            return result;
        }
    }
}
