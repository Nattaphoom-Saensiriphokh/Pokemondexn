using PokemondexN.pokemondex3;

namespace PokemondexN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowPokemon("Pikachu");
        }

        private void ShowPokemon(string name)
        {
            Pokemon pokemon = PokemonFactory.GetPokemon(name);

            if (pokemon != null)
            {
                lbName.Text = pokemon.Name;
                lbType.Text = pokemon.Type;
                lbStats.Text = $"Height : {pokemon.Height}\nWeight : {pokemon.Weight}\n" +
                    $"HP : {pokemon.HP}\nAttack : {pokemon.Attack}\n" +
                    $"Defense : {pokemon.Defense}\nSpecial Attack : {pokemon.SpecialAttack}\n" +
                    $"Special Defense : {pokemon.SpecialDefense}\nSpeed : {pokemon.Speed}\n" +
                    $"Total : {pokemon.Total}";

                // ‚À≈¥√Ÿª®“°‚ø≈‡¥Õ√Ï Images/
                string imagePath = $"Images/{pokemon.Name}.jpg";
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show($"‰¡Ëæ∫√Ÿª¿“æ∑’Ë {imagePath}");  // Debug message
                }
            }

        }

        private void btnPikachu_Click(object sender, EventArgs e)
        {
            ShowPokemon("Pikachu");
        }

        private void btnEspeon_Click(object sender, EventArgs e)
        {
            ShowPokemon("Espeon");
        }

        private void bthHatterene_Click(object sender, EventArgs e)
        {
            ShowPokemon("Hatterene");
        }

        private void btnSwirlix_Click(object sender, EventArgs e)
        {
            ShowPokemon("Swirlix");
        }

        private void bthJigglypuff_Click(object sender, EventArgs e)
        {
            ShowPokemon("Jigglypuff");
        }

        private void bthAlcremie_Click(object sender, EventArgs e)
        {
            ShowPokemon("Alcremie");
        }
    }

}
