using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public void AdicionarMusica(Musica musica) 
        { 
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}: ");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Para ouvir esse álbum você gastará {DuracaoTotal}");
        }

    }
 
}
