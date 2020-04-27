using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.ModelsOfLabel
{
   public class LabelModel
    {
        public string Email { get; set; }
        [Key]
        public int LabelId { get; set; }
        public string Details { get; set; }
    }
}
