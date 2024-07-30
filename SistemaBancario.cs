using System;
using System.Collections.Generic;
using System.Linq;

namespace banking_app
{
    public class SistemaBancario
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void CadastrarUsuario(Usuario usuario)
        {
            if (usuarios.Any(u => u.CPF == usuario.CPF || u.Email == usuario.Email))
            {
                throw new InvalidOperationException("CPF ou e-mail já cadastrado.");
            }
            usuarios.Add(usuario);
        }

        public Usuario Login(string email, string senha)
        {
            var usuario = usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
            if (usuario == null)
            {
                throw new InvalidOperationException("Credenciais inválidas.");
            }
            return usuario;
        }

        public void RealizarTransferencia(UsuarioComum remetente, Usuario destinatario, decimal valor)
        {
            remetente.EnviarTransferencia(destinatario, valor);
            var transferencia = new Transferencia(remetente, destinatario, valor);
            // Registrar a transferência no histórico se necessário
        }
    }
}
