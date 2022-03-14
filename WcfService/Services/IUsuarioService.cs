using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfService
{

    /// <summary>
    /// Interface do service necessários annotations para especificar o serviço
    /// </summary>
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        void AdicionaUsuario(Usuario user);
        [OperationContract]
        Usuario BuscaUsuariosPeloNome(string nome);
    }
}
