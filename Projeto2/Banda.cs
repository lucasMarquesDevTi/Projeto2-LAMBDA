using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Banda
    {
        private List<Album> albums = new List<Album>();

        public string Nome { get; set; }

        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }

        public void ExibirDiscografica() 
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach (Album album in albums) 
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
