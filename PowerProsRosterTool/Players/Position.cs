using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerProsRosterTool.Players
{
    public class Position
    {
        public int Id { get; private set; }
        public int Number { get; private set; }
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }
        public string SingularPlayerName { get; private set; }
        public string PluralPlayerName { get; private set; }

        protected Position() { }

        public static Position FindByNumber(int number)
        {
            var dbContext = new PowerProsDbContext();
            return dbContext.Position.FromSqlRaw("SELECT * FROM pp.Position")
                .Where(p => p.Number == number)
                .Single();
        }
    }
}
