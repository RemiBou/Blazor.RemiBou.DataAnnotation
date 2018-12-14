using System.ComponentModel.DataAnnotations;

namespace Blazor.RemiBou.DataAnnotation.Sample
{
    public class ValidatedModel
    {
        [Required]
        public string ValidatedField { get; set; }
    }
}