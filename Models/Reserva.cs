namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes, int capacidade)
        {
            var quantidadeHospedes = ObterQuantidadeHospedes(hospedes);

            if (quantidadeHospedes <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade é menor que o número de hóspedes recebido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            var quantidadeHospedes = hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria(int diasReservados, decimal valorDiaria)
        {
            decimal valor;
            valor = diasReservados * valorDiaria;
            
            if(diasReservados >= 10)
            {
                valor = valor - (valor * 0.1m);
            }

            return valor;
        }
    }
}