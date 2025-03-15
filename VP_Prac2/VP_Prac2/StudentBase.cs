namespace VP_Prac2
{
    internal class StudentBase
    {


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
        }
    }
}