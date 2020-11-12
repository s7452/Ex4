using Ex4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
