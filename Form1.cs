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

                // âËÅ´ÃÙ»¨Ò¡â¿Åà´ÍÃì Images/
                string imagePath = $"Images/{pokemon.Name}.jpg";
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show($"äÁè¾ºÃÙ»ÀÒ¾·Õè {imagePath}");  // Debug message
                }
            }

        }

        private void btnPikachu_Click(object sender, EventArgs e)
        {
            ShowPokemon("Pikachu");
        }

        private void btnBeedrill_Click(object sender, EventArgs e)
        {
            ShowPokemon("Beedrill");
        }

        private void bthBulbasaur_Click(object sender, EventArgs e)
        {
            ShowPokemon("Bulbasaur");
        }

        private void btnButterfee_Click(object sender, EventArgs e)
        {
            ShowPokemon("Butterfee");
        }

        private void bthCharizard_Click(object sender, EventArgs e)
        {
            ShowPokemon("Charizard");
        }

        private void bthSquirtle_Click(object sender, EventArgs e)
        {
            ShowPokemon("Squirtle");
        }
    }

}
