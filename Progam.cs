using banking_app;
using System;

namespace banking_app
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaBancario sistema = new SistemaBancario();

            // Cadastrar usuários
            UsuarioComum usuario1 = new UsuarioComum("Pedro Henrique", "12345678900", "pedro@example.com", "senha123");
            Lojista lojista1 = new Lojista("Loja ABC", "98765432000100", "lojaabc@example.com", "senha456");

            sistema.CadastrarUsuario(usuario1);
            sistema.CadastrarUsuario(lojista1);

            // Adicionar saldo ao usuário
            usuario1.Saldo = 1000;

            // Realizar transferência
            try
            {
                sistema.RealizarTransferencia(usuario1, lojista1, 200);
                Console.WriteLine($"Transferência realizada com sucesso!");
                Console.WriteLine($"Saldo do {usuario1.NomeCompleto}: {usuario1.Saldo}");
                Console.WriteLine($"Saldo do {lojista1.NomeCompleto}: {lojista1.Saldo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
