using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemondexN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace pokemondex3
    {
        public class Pokemon
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public double Height { get; set; }
            public double Weight { get; set; }
            public int HP { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int SpecialAttack { get; set; }
            public int SpecialDefense { get; set; }

            public int Speed { get; set; }

            // คำนวณค่าพลังรวมอัตโนมัติ
            public int Total => HP + Attack + Defense + Speed + SpecialAttack + SpecialDefense;

            // คอนสตรักเตอร์ให้คลาสลูกใช้งาน
            public Pokemon(string name, string type, double height, double weight, int hp, int attack, int defense, int specialattack, int specialdefense, int speed)
            {
                Name = name;
                Type = type;
                Height = height;
                Weight = weight;
                HP = hp;
                Attack = attack;
                Defense = defense;
                SpecialAttack = specialattack;
                SpecialDefense = specialdefense;
                Speed = speed;
            }
        }
    }

}
