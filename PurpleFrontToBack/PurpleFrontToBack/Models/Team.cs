namespace PurpleFrontToBack.Models
{
    public class Team : BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
