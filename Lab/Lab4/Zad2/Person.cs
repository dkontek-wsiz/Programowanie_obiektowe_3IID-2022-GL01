using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Zad2
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Pesel;


        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        public string GetGender() => int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Woman" : "Man";

        public int GetAge()
        {
            //return DateTime.Now.Year - GetBirthDay().Year;
            return (DateTime.Now - PeselHelper.GetBirthDay(Pesel)).Days / 365;
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();
    }
}
