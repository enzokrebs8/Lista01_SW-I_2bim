using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe7
{
    class Playlist
    {
        private List<Música> músicas;
        public string Dono { get; }

        public Playlist(string dono)
        {
            Dono = dono;
            músicas = new List<Música>();
        }

        public void AdicionarMúsica(Música música)
        {
            músicas.Add(música);
        }

        public void TocarMúsicaAleatória()
        {
            if (músicas.Count == 0)
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas antes de tentar reproduzir.");
                return;
            }

            Random random = new Random();
            int índiceAleatório = random.Next(0, músicas.Count);
            Música músicaAleatória = músicas[índiceAleatório];
            Console.WriteLine($"Tocando música aleatória: {músicaAleatória.Nome}");
        }
    }
}
