
using System.ServiceModel;
using WcfService;


ServiceHost host = new ServiceHost(typeof(UsuarioService));
Uri adress = new Uri("http://localhost:8083/User");
host.AddServiceEndpoint(typeof(IUsuarioService), new BasicHttpBinding(), adress);

try
{
    host.Open();
    Console.ReadLine();
    host.Close();
}
catch (Exception ex)
{
    host.Abort();
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}

