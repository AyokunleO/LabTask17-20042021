using System;

namespace CollegeList
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeEmployee emp1 = new CollegeEmployee("James", "Doe", "Ajanlekoko street, Lagos", 45601, "09045673421", "345689", 5000M, "Works&Housing");
            CollegeEmployee emp2 = new CollegeEmployee("David", "Vave", "Ajanlekoko street, Kaduna", 45699, "0904567889", "345009", 4500M, "Senate");
            Faculty mem1 = new Faculty("Abigail", "lawson", "Chevron drive, Lekki", 45678, "09045673451", "456789", 7000M, "Building", true);
            Faculty mem2 = new Faculty("Abby", "law", "Chevron drive, Banana Island", 45678, "09045673451", "456789", 7000M, "Engineering", true);
            Student stud1 = new Student("Janet", "Han", "Lekki Penninsula, Lagos", 55555, "08034567890", "Construction Management", 3.5M);
            Student stud2 = new Student("Joke", "Silva", "Lekki Penninsula, Lagos", 66678, "08034567890", "Maintenance Management", 4.0M);

            Person[] Info = new Person[6]{emp1,emp2,mem1,mem2,stud1,stud2};

            foreach (var item in Info)
            {
             if (item is Student)
             {
                 var changeDept = (Student)item;
                 changeDept.Study = "Computer Science";
                 Console.WriteLine(item);
             }else{
                 Console.WriteLine(item);
             }   
            }
        }
    }
}
