using System.ComponentModel.DataAnnotations;

namespace Blazor.Validation.DataAnnotation.Sample
{
    public class ValidatedModel
    {
        [Required]
        public string ValidatedField { get; set; }
    }
}