using Crosswords.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crosswords.Common.Repositories
{
    public class WordsRepository : IWordsRepository
    {
        public IEnumerable<Word> GetWords(Expression<Func<Word, bool>> predicate)
        {
            return new List<(string, string)>
            {
                ("apple", "яблоко"),
                ("hello",  "привет, здравствуйте"),
                ("man",    "человек, мужчина"),
                ("woman",  "женщина"),
                ("cat",    "кошка"),
                ("dog",    "собака"),
                ("bird",   "птица"),
                ("sing",   "петь"),
                ("song",   "песня"),
                ("table",  "стол"),
                ("pen",    "ручка"),
                ("good",   "хороший"),
                ("bad",    "плохой"),
                ("small",  "маленький"),
                ("big",    "большой"),
                ("bad",    "плохой"),
                ("bed",    "кровать"),
                ("good",   "хороший"),
                ("window",  "окно")
            }
            .Select((val, index) => new Word
            {
                Difficulty = 1,
                Id = index,
                Language = new Language { Id = 1, Name = "English" },
                LanguageId = 1,
                WordStr = val.Item1,
                Definitions = new List<WordDefinition> { new WordDefinition
                {
                   Id = index,
                   Definition = $"definition of {val}",
                   Language = new Language { Id = 2, Name = "Русски" },
                   LanguageId = 2,
                   Translation = val.Item2,
                   WordId = index
                }}
            })
            .AsQueryable()
            .Where(predicate);
        }
    }
}
