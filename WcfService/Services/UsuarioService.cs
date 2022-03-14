using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Context;

namespace WcfService
{
    public class UsuarioService : IUsuarioService
    {
        UsuarioFakeContext context;
        public UsuarioService()
        => context = new UsuarioFakeContext();

        public void AdicionaUsuario(Usuario user)
        => context.AdicionaUsuario(user);


        public Usuario BuscaUsuariosPeloNome(string nome)
        => context.BuscaUsuariosPeloNome(nome);
    }
}
