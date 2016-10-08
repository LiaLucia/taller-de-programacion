using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    public class FabricaEncriptadores
    {
        private static readonly Lazy<FabricaEncriptadores> instance = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());
        private Dictionary<string, IEncriptador> IEncriptadores = new Dictionary<string, IEncriptador> { };

        private FabricaEncriptadores()
            {
            IEncriptadores.Add("Cesar",new EncriptadorCesar(3));
            IEncriptadores.Add("AES", new EncriptadorAES());
            IEncriptadores.Add("Null", new EncriptadorNulo());

            }

            public static FabricaEncriptadores Instance
            {
                get
                {
                    return instance.Value;
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
        /*
        private static FabricaEncriptadores cInstancia = null;
        

        private FabricaEncriptadores() { }

        public static FabricaEncriptadores Instancia()
        {
            if (cInstancia ==null)
            {
                cInstancia = new FabricaEncriptadores();
            }
            return cInstancia;
        }
       */
    }
