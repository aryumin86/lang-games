﻿using Crosswords.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crosswords.Common.Repositories
{
    public interface IDefinitionsRepository
    {
        public IEnumerable<WordDefinition> GetWordsDefinitions(Expression<Func<WordDefinition, bool>> predicate);
    }
}
