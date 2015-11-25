using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "HalloService" à la fois dans le code et le fichier de configuration.
    public class HalloService : IHalloService
    {
        public void DoWork()
        {
        }
    }
}
