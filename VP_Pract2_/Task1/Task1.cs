using System.Text;

namespace Task1
{
    public class Student
    {
        public int ID { private set; get; }
        public string name { private set; get; }
        public string lastname { private set; get; }
        public string surname { private set; get; }
        public DateOnly dateBirthday { private set; get; }
        public string address { private set; get; }
        public string phone { private set; get; }

        public Student(int ID, string name, string lastname, 
            string surname, DateOnly dateBirthday, string address, string phone)
        {
            this.ID = ID;
            this.name = name;
            this.lastname = lastname;
            this.surname = surname;
            this.dateBirthday = dateBirthday;
            this.address = address;
            this.phone = phone;
        }
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if ((student.ID.Equals(this.ID)) && (student.name == this.name) && 
                (student.lastname == this.lastname) && (student.surname == this.surname)
                && (student.dateBirthday.Equals(this.dateBirthday)) && (student.address == this.address)
                && (student.phone == this.phone))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.ID + " " + this.lastname + " " + this.name + " " + this.surname 
                + " " + this.dateBirthday + " " + this.address + " " + this.phone;
        }   
    }

    public class Group
    {
        private int index;
        public int ID { get; private set; }
        public List<Student> students { private set;  get; }
        public virtual Student this[int index] {  get { return students[index]; } }
        public Group(int ID)
        {
            this.ID = ID;
            this.students = new List<Student>(100);
        }
        public Group(int ID, Student student)
        {
            this.ID = ID;
            this.students = new List<Student>(100) { student };
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student); 
        }
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public String GetList()
        {
            StringBuilder studentsGetInfo = new StringBuilder();
            foreach (Student student in this.students)
            {
                studentsGetInfo.Append(student.ToString() + "\n");
            }
            return "Группа " + this.ID + ":\n" + studentsGetInfo.ToString();
        }

        public String GetInfo()
        {
            List<Student> studentsInfo = this.students;
            int i;
            int count = studentsInfo.Count-1;
            while (count != 0)
            {
                int index = 0;
                Student studentReseachSelfPlace = studentsInfo[index];
                for (int j = 0; j < studentsInfo.Count; j++)
                {
                    if (string.Compare(studentReseachSelfPlace.lastname, studentsInfo[j].lastname) != 0)
                    {
                        if (string.Compare(studentReseachSelfPlace.lastname, studentsInfo[j].lastname) > 0)
                        {
                            if (j == count)
                            {
                                studentsInfo[index] = studentsInfo[j];
                                studentsInfo[j] = studentReseachSelfPlace;
                                studentReseachSelfPlace = studentsInfo[index];
                            }
                            continue;
                        }
                        else
                        {
                            studentReseachSelfPlace = studentsInfo[j];
                            index = j;
                        }
                    }
                    else
                    {
                        if (string.Compare(studentReseachSelfPlace.name, studentsInfo[j].name) > 0)
                        {
                            if (j == count)
                            {
                                studentsInfo[index] = studentsInfo[j];
                                studentsInfo[j] = studentReseachSelfPlace;
                                studentReseachSelfPlace = studentsInfo[index];
                            }
                            continue;
                        }
                        else
                        {
                            studentReseachSelfPlace = studentsInfo[j];
                            index = j;
                        }
                    }
                }
                count -= 1;
            }
            
            StringBuilder studentsGetInfo = new StringBuilder();
            foreach (Student student in studentsInfo)
            {
                studentsGetInfo.Append(student.ToString() + "\n");
            }
            return "Группа " + this.ID + ":\n" + studentsGetInfo.ToString();
        }
    }
}
