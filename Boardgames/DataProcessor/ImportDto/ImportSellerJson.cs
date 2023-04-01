using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportSellerJson
    {
        [Required, MinLength(5), MaxLength(20)]
        public string Name { get; set; }

        [Required, MinLength(2), MaxLength(30)]
        public string Address { get; set; }

        [Required]
        public string Country { get; set; }

        [Required, RegularExpression(@"www\.[a-zA-Z0-9\-]+\.com")]
        public string Website { get; set; }

        public int[] Boardgames { get; set; }

    }
}
