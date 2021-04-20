namespace CollegeList
{
    public class Student : Person
    {
        private string study;
        private decimal gpa;
        public Student(string fName, string lName, string streetAdd, int zipC, string phoneNum, string study, decimal gpa): base(fName, lName,streetAdd,zipC,phoneNum)
        {
            Study = study;
            GPA = gpa;
        }
        public decimal GPA
        {
            get { return gpa; }
            set {
                if (value >= 0 && value <= 4)
                {
                   gpa = value; 
                }else if(value > 4){
                    gpa = 4;
                }else{
                    value = 0;
                }
                 }
        }
        
        public string Study
        {
            get { return study; }
            set { study = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n {Study} {GPA}\n";
        }
    }
}