using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Prac2
{
    internal class Student : StudentBase
    {

        private int _id;
        private string _surname;
        private string _name;
        private string _patronymic = null;
        private DateTime _dataOfBirth;
        private string _address;
        private string _phone;

        Student(int id, string surname, string name,
            DateTime dataOfBirth, string address, string phone)
        {
            this._id = id;
            this._surname = surname;
            this._name = name;
            this._dataOfBirth = dataOfBirth;
            this._address = address;
            this._phone = phone;
        }

        Student(int id, string surname, string name, string patronymic,
            DateTime dataOfBirth, string address, string phone) 
            : this(id, surname, name, dataOfBirth, address, phone)
        {
            this._patronymic = patronymic;
        }

        public override bool Equals(Student obj)
        {
            if (this._id == obj._id &&
                this._surname == obj._surname &&
                this._name == obj._name &&
                this._patronymic == obj._patronymic &&
                this._dataOfBirth == obj._dataOfBirth &&
                this._address == obj._address &&
                this._phone == obj._phone)
            {
                return true;
            }
            return false;
        }

        public override string ToString() { 

            if (this._patronymic == null) {
                return (this._id + " " + this._surname + " " + this._name
                + " " + this._dataOfBirth + " " +
                this._address + " " + this._phone);
            }
            return (this._id + " " + this._surname + " " + this._name
                + " " + this._patronymic + " " + this._dataOfBirth + " " + 
                this._address + " " + this._phone);
        }
    }
}
