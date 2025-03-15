using System.Text;

namespace StudentsLibrary
{
    public class Student
    {
        public int ID { private set; get; }
        public string Name { private set; get; }
        public string Lastname { private set; get; }
        public string Surname { private set; get; }
        public DateOnly DateBirthday { private set; get; }
        public string Address { private set; get; }
        public string Phone { private set; get; }

        public Student(int ID, string name, string lastname, 
            string surname, DateOnly dateBirthday, string address, string phone)
        {
            this.ID = ID;
            this.Name = name;
            this.Lastname = lastname;
            this.Surname = surname;
            this.DateBirthday = dateBirthday;
            this.Address = address;
            this.Phone = phone;
        }
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            return (student.ID.Equals(this.ID)) && (student.Name == this.Name) && 
                (student.Lastname == this.Lastname) && (student.Surname == this.Surname)
                && (student.DateBirthday.Equals(this.DateBirthday)) && (student.Address == this.Address)
                && (student.Phone == this.Phone);
        }
        public override string ToString()
        {
            return this.ID + " " + this.Lastname + " " + this.Name + " " + this.Surname 
                + " " + this.DateBirthday + " " + this.Address + " " + this.Phone;
        }   
    }
}
