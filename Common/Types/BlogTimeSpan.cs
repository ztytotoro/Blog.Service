using Common.Enums;

namespace Common.Types
{
    public class BlogTimeSpan
    {
        public TimeUnit Type { get; set; } = TimeUnit.Second;
        public int Value { get; set; } = 0;
    }
}
