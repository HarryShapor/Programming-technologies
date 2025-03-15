using System.Net;
using System.Text;
namespace StudentsLibrary
{
    public class Group
    {
        private Student StudDefault = new(-1, "", "", "", new DateOnly(2000, 1, 1), "", "");
        public int ID { get; private set; }
        public List<Student> Students;
        public Student this[int bookID] {
            private set
            {
                var student = value;
                if (student.ID.Equals(bookID))
                {
                    if (student.ID >= Students.Count)
                    {
                        while (Students.Count <= student.ID)
                        {
                            Students.Add(StudDefault);
                        }
                        
                        Students.Insert(bookID, student);
                    }
                    else
                    {
                        Students.Insert(student.ID, student);
                    }
                }
                else
                {
                    throw new ArgumentException("ID студента не совпадает с индексом в массиве.");
                }
            }
            get {
                var student = Students.Find(x => x.ID == bookID);
                if (student.Equals(StudDefault))
                {
                    return this.Students[bookID];
                }
                else
                {
                    throw new Exception("Нет студента с такой зачеткой!");
                }
            }
        }

        public Group(int ID)
        {
            this.ID = ID;
            this.Students = new List<Student>();
        }
        public void Add(Student student)
        {
            if (student.ID < 0)
            {
                throw new ArgumentException("ID студента не может быть отрицательным.");
            }
            if (student.ID >= Students.Count)
            {
                while (Students.Count <= student.ID)
                {
                    Students.Add(StudDefault);
                }
            }
            Students[student.ID] = student;
        }
        public void Remove(Student student)
        {
            if (Students.Count == 0) { throw new Exception("Список группы пуст!"); }
            if (Students.Contains(student))
            {
                var stud = Students.Find(x => x.ID == student.ID);
                this.Students[stud.ID] = StudDefault;
                this.Students.Remove(student);
            }
            else
            {
                throw new Exception("Такого студента нет в группе!");
            }
            
        }
        public String GetList()
        {
            StringBuilder studentsGetInfo = new StringBuilder();
            foreach (Student student in this.Students)
            {
                if (!student.Equals(StudDefault))
                    studentsGetInfo.Append(student.ToString() + "\n");
            }
            return "Группа " + this.ID + ":\n" + studentsGetInfo.ToString();
        }

        public String GetInfo()
        {
            List<Student> studentsInfo = this.Students;
            int count = studentsInfo.Count - 1;
            while (count != 0)
            {
                int index = 0;
                Student studentReseachSelfPlace = studentsInfo[index];
                for (int j = 0; j < studentsInfo.Count; j++)
                {
                    if (string.Compare(studentReseachSelfPlace.Lastname, studentsInfo[j].Lastname) != 0)
                    {
                        if (string.Compare(studentReseachSelfPlace.Lastname, studentsInfo[j].Lastname) > 0)
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
                        if (string.Compare(studentReseachSelfPlace.Name, studentsInfo[j].Name) > 0)
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
                if (!student.Equals(StudDefault))
                    studentsGetInfo.Append(student.ToString() + "\n");
            }
            return "Группа " + this.ID + ":\n" + studentsGetInfo.ToString();
        }
    }
}
