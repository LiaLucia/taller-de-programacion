using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class FabricaEncriptadores
    {
        private static readonly Lazy<FabricaEncriptadores> cInstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());
        private Dictionary<string, IEncriptador> IEncriptadores = new Dictionary<string, IEncriptador> { };

        private FabricaEncriptadores()
        {
            IEncriptadores.Add("Cesar", new EncriptadorCesar(3));
            IEncriptadores.Add("AES", new EncriptadorAES());
            IEncriptadores.Add("Null", new EncriptadorNulo());
            IEncriptadores.Add("TripleDES", new EncriptadorTripleDES());

        }

        public static FabricaEncriptadores Instancia
        {
            get
            {
                return cInstancia.Value;
            }
        }
        public IEncriptador GetEncriptador(string nombre)
        {
            if (!IEncriptadores.ContainsKey(nombre))
            {
                return null;
            }
            return this.IEncriptadores[nombre];

        }
    }
}
