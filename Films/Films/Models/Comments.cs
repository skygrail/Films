using System;

namespace Films.Models
{
    public class Comments
    {
        public int ID { get; set; }
        public Users User { get; set; }
        public Film Film { get; set; }
        public string TextOfComment { get; set; }
        public string DateOfCreation { get; set; }
    }
}
