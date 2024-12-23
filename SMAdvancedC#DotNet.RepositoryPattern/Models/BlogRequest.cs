namespace SMAdvancedC_DotNet.RepositoryPattern.Models
{
    public class BlogRequest
    {
        public string BlogTitle { get; set; } = null!;

        public string BlogAuthor { get; set; } = null!;

        public string BlogContent { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
