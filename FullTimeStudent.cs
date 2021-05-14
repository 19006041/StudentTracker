namespace StudentEditor
{

    public class FullTimeStudent : Student, StudiesAtHome
    {
        private string campus;

        public string getCampus() {
            return this.campus;
        }

        public void setCampus(string campus) {
            this.campus = campus;
        }


        public FullTimeStudent(string id, string firstName, string lastName, bool enrolled, string campus) : base( id,  firstName,  lastName,  enrolled)
        {
            this.campus = campus;
        }

        public string Campus { get => campus; set => campus = value; }

        public void studyFromHome(){
           
        }

        public override int getLectureHours(){
            return 100;
        }
    }
}