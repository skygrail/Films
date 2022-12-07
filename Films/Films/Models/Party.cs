using System;

namespace Films.Models
{
    public class Party
    {
        public int ID { get; set; }
        public Users User { get; set; }
        public Film Film { get; set; }
        public string DateOfCreation { get; set; }
        public Chats Chat { get; set; }
    }
}
