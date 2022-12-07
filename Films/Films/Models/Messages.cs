using System;

namespace Films.Models
{
    public class Messages
    {
        public int ID { get; set; }
        public Users User { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public Chats Chat { get; set; }
    }
}
