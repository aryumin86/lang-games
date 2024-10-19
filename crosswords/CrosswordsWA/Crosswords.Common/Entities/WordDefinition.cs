using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crosswords.Common.Entities
{
    [Table("wordsdefenitions")]
    public class WordDefinition
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("wordid")]
        public int WordId { get; set; }

        [Column("definition")]
        public string? Definition { get; set; }

        [Column("translation")]
        public string? Translation { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [Column("languageid")]
        public Language Language { get; set; }

        public int LanguageId { get; set; }
    }
}
