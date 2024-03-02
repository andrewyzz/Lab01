using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public int An_nastere { get; set; }
        internal Date_univ Date_univ { get; set; }
        public Student(Date_univ date) { 
        this.Date_univ = date;
        }
        public Student()
        {

        }
        public Student Copiere()
        {
            return new Student(Date_univ)
            {
                Nume = this.Nume,
                Adresa = this.Adresa,
                An_nastere = this.An_nastere,
            };
        }
    }
}
