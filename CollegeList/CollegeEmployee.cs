namespace CollegeList
{
    public class CollegeEmployee : Person
    {
        private string ssn;
        private decimal salary;
        private string deptName;
        public CollegeEmployee(string fName, string lName, string streetAdd, int zipC, string phoneNum, string ssn, decimal salary, string deptName): base(fName,lName,streetAdd,zipC,phoneNum)
        {
            SSN = ssn;
            Salary = salary;
            DeptName = deptName;
        }
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        
        public decimal Salary
        {
            get { return salary; }
            set {
                if(value > 0)
                {
                    salary = value; 
                }else{
                    salary = 0;
                }
                }
        }
        
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{SSN}, {Salary}, {DeptName}\n";
        }
    }
}