using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class Cl
    {

        public interface IStudentRepository
        {
            void Create(Student student);
            Student FindByID(int id);
            void Update(int index, Student student);
            void Delete(int index);
            void SaveChanges();
            List<Student> GetAll();
        }
    }
}
