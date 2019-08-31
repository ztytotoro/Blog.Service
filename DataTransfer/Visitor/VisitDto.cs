using Common.Enums;

namespace DataTransfer
{
    public class VisitDto
    {
        public string Path { get; set; }
        public string PostContentId { get; set; }
        public Language Language { get; set; }
        public string IP { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
    }
}
