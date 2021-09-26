namespace Commander.Models
{
    public class Command 
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        //cmd line snippet in db
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}