namespace isa3.Data.PeopleData
{
    public class AthleteData : PersonRoleData
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public decimal? Credit { get; set;}
        //TODO: What is Credit, how does an Athlete use it? Deposit? Withraw? do we need it?

        //TODO: (idea) Maybe we should add somekind of a raking system? 
    }
}
