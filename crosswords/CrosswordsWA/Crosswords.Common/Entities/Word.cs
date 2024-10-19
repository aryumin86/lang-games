using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crosswords.Common.Entities
{
    [Table("words")]
    public class Word
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("wordstr")]
        public string? WordStr { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [Column("languageid")]
        public Language Language { get; set; }

        public int LanguageId { get; set; }

        [Column("difficulty")]
        public int Difficulty { get; set; }

        public IEnumerable<WordDefinition> Definitions { get; set; }
    }
}
