using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Test
{
    public class Carro
    {
        private List<Roda> _rodas;
        private List<Porta> _portas;
        private Lataria _lataria;

        public Motor Motor { get; private set; }
        public Lataria Lataria { get; private set; }
        public List<Roda> Rodas
        {
            get
            {
                return _rodas;
            }
        }
        public List<Porta> Portas
        {
            get
            {
                return _portas;
            }
        }

        public Carro()
        {
            Motor = new Motor();
            Lataria = new Lataria();

            CriarRodas();
            CriarPortas();
        }

        private void CriarPortas()
        {
            _portas = new List<Porta>();

            Porta portaDireita = new Porta();
            Porta portaEsquerda = new Porta();

            _portas.Add(portaDireita);
            _portas.Add(portaEsquerda);
        }

        private void CriarRodas()
        {
            _rodas = new List<Roda>();

            Roda rodaDianteiraDireita = new Roda();
            Roda rodaDianteiraEsquerda = new Roda();
            Roda rodaTraseiraDireita = new Roda();
            Roda rodaTraseiraEsquerda = new Roda();

            _rodas.Add(rodaDianteiraDireita);
            _rodas.Add(rodaDianteiraEsquerda);
            _rodas.Add(rodaTraseiraDireita);
            _rodas.Add(rodaTraseiraEsquerda);
        }
    }
}
