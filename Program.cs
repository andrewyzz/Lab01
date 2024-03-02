namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Date_univ date = new Date_univ();
            date.An_studiu = 2024;
            date.Universitatea = "UOradea";
            date.Specializarea = "TI";
            student.Date_univ = date;
            List<Student> students = new List<Student>();
            students.Add(student);
            for(int i = 0; i < 5; i++)
            {
                students.Add(student.Copiere());
            }
            for(int i = 0; i < 6; i++)
            {
                students[i].Nume = "Student " + (i);
                students[i].An_nastere = 2000 + (i);
                students[i].Adresa = "Adresa " + (i);
            }
            Console.WriteLine("Studentii initiali:");
            foreach(Student stu in students)
            {
                Console.WriteLine(stu.Nume + " " + stu.An_nastere + " " + stu.Adresa +" "+ stu.Date_univ.Universitatea + " " + stu.Date_univ.Specializarea + " " + stu.Date_univ.An_studiu);
            }
            for(int i = 0; i < 3; i++)
            {
                students[i].Date_univ.Specializarea = "Calculatoare";
                students[i].Date_univ.Universitatea = "IETI";
            }
            Console.WriteLine("Studenti modificati:");
            foreach(Student stu in students)
            {
                Console.WriteLine(stu.Nume + " " + stu.An_nastere + " " + stu.Adresa +" "+ stu.Date_univ.Universitatea + " " + stu.Date_univ.Specializarea + " " + stu.Date_univ.An_studiu);
            }
        }
    }
}
