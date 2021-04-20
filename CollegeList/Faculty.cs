namespace CollegeList
{
    public class Faculty:CollegeEmployee
    {
        private bool tenured;
        public Faculty(string fName, string lName, string streetAdd, int zipC, string phoneNum, string ssn, decimal salary, string deptName, bool tenure): base(fName,lName,streetAdd,zipC,phoneNum,ssn,salary,deptName)
        {
            Tenured = tenure;
        }
        public bool Tenured
        {
            get { return tenured; }
            set { 
                if (value == true || value == false)
                {
                    tenured = value;
                }
                 }
        }
        public override string ToString()
        {
            return $"{base.ToString()} Tenured: {Tenured}\n";
        }
    }
}