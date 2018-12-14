using System.ComponentModel.DataAnnotations;

namespace RemiBou.Blazor.DataAnnotation.Sample
{
    public class ValidatedModel
    {
        [Required]
        public string ValidatedField { get; set; }
    }
}