namespace WebApplication1.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }  // Ensure this is a DateTime property
        public int Rating { get; set; }  // Ensure this is an integer
    }
}
