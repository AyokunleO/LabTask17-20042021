namespace CollegeList
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string streetAddr;
        private int zipCode;
        private string phoneNum;
        public Person(string fName, string lName, string streetAdd, int zipC, string phoneNum)
        {
            FirstName = fName;
            LastName = lName;
            StreetAddr = streetAdd;
            ZipCode = zipC;
            PhoneNum = phoneNum;
        }
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }
        
        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        
        public string StreetAddr
        {
            get { return streetAddr; }
            set { streetAddr = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {StreetAddr}, {ZipCode}, {PhoneNum}";
        }
        
    }
}