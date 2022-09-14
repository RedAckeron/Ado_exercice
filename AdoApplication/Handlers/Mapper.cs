using AdoApplication.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdoApplication.Handlers
{
    public static class Mapper
    {
        public static Character ToCharacter(IDataRecord record)
        {
            if (record is null) return null;
            return new Character(
                (int)record[nameof(Character.Id)],
                (string)record[nameof(Character.Name)],
                (int)record[nameof(Character.Strength)],
                (int)record[nameof(Character.Stamina)],
                (int)record[nameof(Character.Hp)],
                (bool)record[nameof(Character.IsDead)],
                (DateTime)record[nameof(Character.CreationDate)],
                (int)record[nameof(Character.Money)]
                );
        }
    }
}
