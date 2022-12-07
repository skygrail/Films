namespace Films.Models
{
    public class UsersFilms
    {
        public int ID { get; set; }
        public Users User { get; set; }
        public Film Film { get; set; }
        public string NameOfList { get; set; }
    }
}
