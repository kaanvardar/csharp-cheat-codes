namespace hellomars
{
    class Student
    {
        public string sName = "";
        public string sMajor = "";
        public double sGpa;

        public Student(string saName,string saMajor,double saGpa)
        {
            sName = saName;
            sMajor = saMajor;
            sGpa = saGpa;
        }

        public bool HasHonors()
        {
            if(sGpa > 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}