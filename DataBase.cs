using System;
using System.Collections.Generic;

namespace ImtahanSistemi
{
    public class DataBase
    {
        private List<Student> _sagirdler = new List<Student>();
        private List<Teacher> _teacherler = new List<Teacher>();

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                _sagirdler.Add(student);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                _teacherler.Add(teacher);
            }
        }

        public Student FindStudentById(int id)
        {
            foreach (Student s in _sagirdler)
            {
                if (s.GetId() == id)
                {
                    return s;
                }
            }
            return null;
        }

        public Teacher FindTeacherById(int id)
        {
            foreach (Teacher t in _teacherler)
            {
                if (t.GetId() == id)
                {
                    return t;
                }
            }
            return null;
        }

        public void RemoveStudentById(int id)
        {
            Student found = null;
            foreach (Student s in _sagirdler)
            {
                if (s.GetId() == id)
                {
                    found = s;
                    break;
                }
            }

            if (found != null)
            {
                _sagirdler.Remove(found);
                Console.WriteLine("ID: " + id + " olan şagird sistemdən silindi.");
            }
            else
            {
                Console.WriteLine("Xəta: ID: " + id + " olan şagird tapılmadı!");
            }
        }

        public int GetStudentCount()
        {
            return _sagirdler.Count;
        }

        public int GetTeacherCount()
        {
            return _teacherler.Count;
        }

        public List<Student> GetAllStudents()
        {
            return _sagirdler;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherler;
        }
    }
}
