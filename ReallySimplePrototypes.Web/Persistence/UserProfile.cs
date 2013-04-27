using ReallySimplePrototypes.Persistence;

namespace ReallySimplePrototypes.Web.Persistence
{
    public class UserProfile : ICanBeSaved
    {
        public object Id
        {
            get { return UserName; }
            set { UserName = value.ToString(); }
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}