using System;

namespace BigdanLab2
{
    class Person
    {
        private string name;
        private string surname;
        private DateTime date_of_Birth;

        public string my_name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }

        public string my_surname
        {
            get
            {
                return surname;
            }
            set { surname = value; }
        }

        public DateTime my_Birth
        {
            get
            {
                return date_of_Birth;
            }
            set { date_of_Birth = value; }
        }

        public int year
        {
            get
            {
                return date_of_Birth.Year;
            }
            set
            {
                date_of_Birth = date_of_Birth.AddYears(value - date_of_Birth.Year);
            }
        }

        public Person(string fName, string sName, DateTime bDate)
        {
            name = fName;
            surname = sName;
            date_of_Birth = bDate;
        }

        public Person()
        {
            name = "Max";
            surname = "Fry";
            date_of_Birth = new DateTime(1, 1, 1);
        }

        public override string ToString()
        {
            return name + " " + surname + " " + date_of_Birth.ToString();
        }

        public virtual string ToShortString()
        {
            return name + " " + surname;
        }
    }
}
