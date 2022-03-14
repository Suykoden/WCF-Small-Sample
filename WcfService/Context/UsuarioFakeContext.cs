using System.Collections.Generic;
using System.Linq;

namespace WcfService.Context
{

    /// <summary>
    /// Contexto falso para simular ida ao banco de dados
    /// </summary>
    public class UsuarioFakeContext
    {
        private static List<Usuario> Usuarios = new List<Usuario>();
        public void AdicionaUsuario(Usuario user)
          => Usuarios.Add(user);

        public Usuario BuscaUsuariosPeloNome(string nome)
          => Usuarios.FirstOrDefault(a => a.Nome.Equals(nome));
    }
}
