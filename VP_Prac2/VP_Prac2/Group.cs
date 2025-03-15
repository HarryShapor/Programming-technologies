using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Prac2
{
    internal class Group
    {
        private string numberGroup;
        private List<Student> students = new List<Student>();

        public Group() { }

        public void AddStudent(Student student, string numberGroup)
        {
            this.numberGroup = numberGroup;
            this.students.Add(student);
        }

        //public Student RemoveStudent(int id) {
            //return students.RemoveAt(id);
        /}

        public string GetInfo()
        {
            return null;
        }

        internal void AddStudent(Student student, int v)
        {
            throw new NotImplementedException();
        }
    }
}
