namespace StudentEditor
{
   
    public class DistanceStudent : Student, StudiesAtHome
    {
        private string facilitator;

        public string getFacilitator()
        {
            return this.facilitator;
        }

        public void setFacilitator(string facilitator)
        {
            this.facilitator = facilitator;
        }


        public DistanceStudent(string id, string firstName, string lastName, bool enrolled, string facilitator) : 
            base(id, firstName, lastName, enrolled)
        {
            this.facilitator = facilitator;
        }

        public string Facilitator { get => facilitator; set => facilitator = value; }

        public void studyFromHome(){
        
        }

        public override int getLectureHours(){
            return 50;
        }
    }
}