using ChawlEvent.Model.Enum;

namespace ChawlEvent.Model
{
    public class User
    {
        public int Id { get; set; }
        public int FName { get; set; }
        public int MName { get; set; }
        public int LName { get; set; }
        public int UserName { get; set; }
        public int Password { get; set; }
        public UserType UserType { get; set; }
    }
}
