using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.HashSet.Exercicios
{
    public class SistemaDeVotacao
    {
        private Dictionary<string, HashSet<string>> votosPorCategoria;

        public SistemaDeVotacao()
        {
            votosPorCategoria = new Dictionary<string, HashSet<string>>();
        }

        public bool RegistrarVoto(string categoria, string usuarioId)
        {
            if (!votosPorCategoria.ContainsKey(categoria))
            {
                votosPorCategoria[categoria] = new HashSet<string>();
            }

            if (!votosPorCategoria[categoria].Add(usuarioId))
            {
                Console.WriteLine($"Voto duplicado rejeitado para o usuário {usuarioId} na categoria {categoria}.");
                return false;
            }
            Console.WriteLine($"Voto registrado para o usuário {usuarioId} na categoria {categoria}.");
            return true;
        }
    }
}