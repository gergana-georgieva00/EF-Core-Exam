using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Creator")]
    public class ImportCreatorXml
    {
        [XmlElement("FirstName")]
        [Required, MinLength(2), MaxLength(7)]
        public string FirstName { get; set; }

        [XmlElement("LastName")]
        [Required, MinLength(2), MaxLength(7)]
        public string LastName { get; set; }
        public BoardgameDto[] Boardgames { get; set; }
    }

    [XmlType("Boardgame")]
    public class BoardgameDto
    {
        [XmlElement("Name")]
        [Required, MinLength(10), MaxLength(20)]
        public string Name { get; set; }

        [XmlElement("Rating")]
        [Required, Range(1, 10.00)]
        public double Rating { get; set; }

        [XmlElement("YearPublished")]
        [Required, Range(2018, 2023)]
        public int YearPublished  { get; set; }

        [XmlElement("CategoryType")]
        [Required, Range(0, 4)]
        public int CategoryType { get; set; }

        [XmlElement("Mechanics")]
        [Required]
        public string Mechanics  { get; set; }
    }
}
