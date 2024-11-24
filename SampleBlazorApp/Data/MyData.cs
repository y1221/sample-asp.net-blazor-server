using System.ComponentModel.DataAnnotations;

namespace SampleBlazorApp.Data
{
    public class MyData
    {
        [Required]
        public string Name { get; set; } = default!;

        public int Age { get; set; }

        [EmailAddress]
        public string Mail { get; set; } = default!;

        public override string ToString()
        {
            return $"[{Name} ({Age}) {Mail}]";
        }
    }
}
