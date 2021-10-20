using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
        public class StudentRepository : IStudentRepository
        {
            private DataManager dataManager;
            List<Student> Students;
            public StudentRepository() {…}
            public void Create(Student student) {…}
            public void Delete(int index) {…}
            public Student FindByID(int id) {…}
            public List<Student> GetAll() {…}
            public void SaveChanges() {…}
            public void Update(int index, Student student) {…}
        }
    
}
