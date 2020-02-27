using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IntegerArrayValidation.Models
{
    public class IntegerArrayInputModel
    {
        [Required]
        [RegularExpression(
            @"^\[\s*[0-9]+\s*(?:,\s*[0-9]+)*\]$", 
            ErrorMessage = "Please enter an array of integers in the format \"[x,y]\""
        )]
        [DisplayName("Integer array")]
        public string InputText { get; set; }
        public string Answer { get; set; }
    }
}
