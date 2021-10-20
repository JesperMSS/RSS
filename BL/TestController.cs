using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class StudentController
    {
        private IStudentRepository studentRepository;
        public StudentController()
        {
            studentRepository = new StudentRepository();
        }
        public void CreateStudent(int id, string firstName, string address)
        {
            Student newStudent = new Student(id, firstName, address);
            studentRepository.Create(newStudent);
        }
        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAll();
        }
    }
}
