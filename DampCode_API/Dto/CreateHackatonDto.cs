namespace DampCode_API.Dto
{
    public class CreateHackathonDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public List<string>? Technologies { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
