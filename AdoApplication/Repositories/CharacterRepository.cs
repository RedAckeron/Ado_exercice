using AdoApplication.Class;
using AdoApplication.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApplication.Repositories
{
    public class CharacterRepository
    {
        private string connectionString = "server=E6KOLL0102\\TFTIC;database=HeroVsMonster;integrated security=true";

        public int AddChar(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Character newchar = new Character(
                    0,
                    name,
                    new Random().Next(15, 21),
                    new Random().Next(15, 21),
                    new Random().Next(50, 101),
                    false,
                    DateTime.Now,
                    new Random().Next(80, 101)
                    );
                EnregistrerLePersonnage(newchar);
                //ouverture de la connection vers le server sql
                connection.Open();
                //pour pouvoir executer du sql il nous faut une commande 
                SqlCommand command = connection.CreateCommand();
                command.CommandText = @"insert into character ([Name],[Strength],[Stamina],[Hp],[Money],[CreationDate],[IsDead])OUTPUT INSERTED.Id VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                command.Parameters.AddWithValue("p1", newchar.Name);
                command.Parameters.AddWithValue("p2", newchar.Strength);
                command.Parameters.AddWithValue("p3", newchar.Stamina);
                command.Parameters.AddWithValue("p4", newchar.Hp);
                command.Parameters.AddWithValue("p5", newchar.Money);
                command.Parameters.AddWithValue("p6", newchar.CreationDate);
                command.Parameters.AddWithValue("p7", newchar.IsDead);
                //SqlDataReader reader = 
                return (int)command.ExecuteScalar();

            }//disposer automatiquement a la fin de l accolade
        }
        public IEnumerable<Character> ChargerLesPersonnages()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //ouverture de la connection vers le server sql
                connection.Open();
                //pour pouvoir executer du sql il nous faut une commande 
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from Character";
                SqlDataReader reader = command.ExecuteReader();
                List<Character> result = new List<Character>();
                while (reader.Read())
                {
                  
                Character character = Mapper.ToCharacter(reader);
                yield return character;
                }
            }//disposer automatiquement a la fin de l accolade
        }
        int EnregistrerLePersonnage(Character newchar)
        {
            return 0;
        }
    }
}
