namespace StudentEditor
{
    //Single Responsibility 
    public abstract class Student
    {
        private string id;
        private string firstName;
        private string lastName;
        private bool enrolled;
        public abstract int getLectureHours();

        public void doAssessment(){
         
        }
        
        public Student(string id, string firstName, string lastName, bool enrolled)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.enrolled = enrolled;
        }

        public string getId()
        {
            return this.id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public bool isEnrolled()
        {
            return this.enrolled;
        }

        public void setEnrolled(bool enrolled)
        {
            this.enrolled = enrolled;
        }

    }
}