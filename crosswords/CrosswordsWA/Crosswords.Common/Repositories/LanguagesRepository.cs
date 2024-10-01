using Crosswords.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crosswords.Common.Repositories
{
    public class LanguagesRepository : ILanguagesRepository
    {
        public IEnumerable<Language> GetLanguages(Expression<Func<Language, bool>> predicate)
        {
            return new List<Language>
            {
                new Language { Id = 1, Name = "English" },
                new Language { Id = 2, Name = "Russian" },
                new Language { Id = 3, Name = "Chinese" },
                new Language { Id = 4, Name = "German" }
            }
            .AsQueryable()
            .Where(predicate);
        }
    }
}
