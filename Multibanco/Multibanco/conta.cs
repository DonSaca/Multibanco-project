using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multibanco
{
    public class conta
    {
        public string NumeroConta { set; get; }
        public string Titular { set; get; }
        public double Saldo { set; get; }
        public string PIN { set; get; }
        public bool IsAdmin { set; get; }
        public DateTime DataCriacao { set; get; }
        public Credito CreditoAtivo { get; private set; }
        public List<transacao> Transacoes { get; set; } = new List<transacao>();


        //Construtor
        public conta(string numConta, string titular, double saldo, string pin)
        {
            NumeroConta = numConta;
            this.Titular = titular;
            this.Saldo = saldo;
            PIN = pin;
        }

        public conta(string numConta, string titular, double saldo, string pin, DateTime data)
        {
            NumeroConta = numConta;
            this.Titular = titular;
            this.Saldo = saldo;
            PIN = pin;
            this.DataCriacao = data;
        }

        public conta(string numConta, string titular, double saldo, string pin, bool adminStatus)
        {
            NumeroConta = numConta;
            this.Titular = titular;
            this.Saldo = saldo;
            PIN = pin;
            this.IsAdmin = adminStatus;
        }
        public conta()
        {
          
        }

        //Metodos
        public void Deposito(double amount)
        {
            this.Saldo += amount;
            this.Transacoes.Add(new transacao(amount, "Deposito"));
        }

        public void Levantamento(double amount)
        {
            if (this.Saldo >= amount)
            {
                Saldo -= amount;
                Transacoes.Add(new transacao(amount, "Levantamento"));
            }
            else
            {
                throw new InvalidOperationException("Saldo Insuficiente");
            }
        }


        public void CriarConta(string accountNumber, string titular, double saldo, string pin, DateTime data)
        {
            //Centificar que a conta é unica
            if (Generic.ListaContas.Any(acc => acc.NumeroConta == accountNumber))
            {
                throw new InvalidOperationException("Conta ja existe!");
            }

            conta novaConta = new conta(accountNumber, titular, saldo, pin, data);
            Generic.ListaContas.Add(novaConta);

        }

        public void ApagarConta (conta conta)
        {

        }

        
        public conta GetContaMaiorSaldo()
        {
            return Generic.ListaContas.Where(s => !s.IsAdmin).OrderByDescending(acc => acc.Saldo).FirstOrDefault();
        }

        
        public conta GetContaMenorSaldo()
        {
            return Generic.ListaContas.Where(s => !s.IsAdmin).OrderBy(acc => acc.Saldo).FirstOrDefault();
        }

        
        public double CalcularMediaSaldos()
        {
            return Generic.ListaContas.Where(s => !s.IsAdmin ).Average(acc => acc.Saldo); 
        }

        public bool PodeSolicitarCredito()
        {
            // Ensure more than 5 years have passed
            return (DateTime.Now - DataCriacao).TotalDays >= 365 * 5 && CreditoAtivo == null;
        }

        public void SolicitarCredito()
        {
            if (PodeSolicitarCredito())
            {
                CreditoAtivo = new Credito(Saldo * 10);  // Create new credit with balance * 10
            }
            else
            {
                throw new InvalidOperationException("Não pode solicitar novo credito.");
            }
        }

        public void AprovarCredito()
        {
            if (CreditoAtivo != null && !CreditoAtivo.Aprovado)
            {
                CreditoAtivo.Aprovado = true;
            }
        }

    }
}
