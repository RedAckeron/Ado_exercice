using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoApplication.Class
{
    public class Character
    {

        public Character(int id, string name, int strength, int stamina, int hp, bool isDead, DateTime creationDate, int money)
        {
            Id = id;
            Name = name;
            Strength = strength;
            Stamina = stamina;
            Hp = hp;
            IsDead = isDead;
            CreationDate = creationDate;
            Money = money;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength{ get; set; }
        public int Stamina { get; set; }    
        public int Hp { get; set; }
        public bool IsDead { get; set; }    
        public DateTime CreationDate { get; set; }  
        public int Money { get; set; }  


    }
}
