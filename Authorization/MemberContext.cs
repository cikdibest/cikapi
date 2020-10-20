namespace CikApi.Authorization
{
    public class MemberContext
    {
        public MemberContext(string name,string surname,CikApiRole role)
        {
            this.Name = name;
            this.Surname = surname;
            this.Role = role;
        }
        public string Name { get;internal set; }
        public string Surname { get; internal set; }
        public CikApiRole Role { get; internal set; }
    }
}