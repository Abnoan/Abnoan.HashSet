using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.HashSet.Exercicios
{
    public class SistemaDeDeteccaoDeFraude
    {
        private HashSet<string> transacoes;

        public SistemaDeDeteccaoDeFraude()
        {
            transacoes = new HashSet<string>();
        }

        public bool AdicionarTransacao(string transacaoId)
        {
            if (!transacoes.Add(transacaoId))
            {
                Console.WriteLine($"Alerta de Fraude! Transação duplicada detectada: {transacaoId}");
                return false;
            }
            Console.WriteLine($"Transação {transacaoId} adicionada com sucesso.");
            return true;
        }
    }
}