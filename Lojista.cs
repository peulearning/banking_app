namespace banking_app
{
    public class Lojista : Usuario
    {
        public Lojista(string nomeCompleto, string cnpj, string email, string senha)
            : base(nomeCompleto, cnpj, email, senha) { }

        public override void ReceberTransferencia(decimal valor)
        {
            Saldo += valor;
        }
    }
}
