using System.Collections.Generic;

namespace Films.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public List<Users> listUsers { get; set; }
        public Users Users { get; set; }
        public List<UsersLogins> listUsersLogins { get; set; }
        public List<UsersFilms> listUsersFilms { get; set; }
        public List<Categoryies> listCategoryies { get; set; }
        public List<Companies> listCompanies { get; set; }
        public List<Contries> listContries { get; set; }
        public List<Film> listFilm { get; set; }
    }
}