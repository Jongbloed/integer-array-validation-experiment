using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntegerArrayValidation.Models
{
    public class IntegerArrayInputModel
    {
        [MinLength(1)]
        [RegularExpression(@"^\[[0-9]+(?:,\s*[0-9]+)*\]$")]
        [DisplayName("Integer array")]
        public string InputText { get; set; }
        public string Answer { get; set; }
    }
}
