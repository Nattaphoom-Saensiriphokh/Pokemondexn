using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemondexN.pokemondex3;

namespace PokemondexN
{
    public static class PokemonFactory
    {
        public static Pokemon GetPokemon(string name)
        {
            switch (name)
            {
                case "Pikachu": return new Pikachu();
                case "Jigglypuff": return new Jigglypuff();
                case "Alcremie": return new Alcremie();
                case "Espeon": return new Espeon();
                case "Swirlix": return new Swirlix();
                case "Hatterene": return new Hatterene();

                // เพิ่มตัวอื่นๆ ตามที่มี
                default: return null;
            }
        }
    }
}
