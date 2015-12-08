﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationAppMainServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ITrainServices" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ITrainServices
    {
        [OperationContract]
        int Add(int firstNumber, int secondNumber);

        [OperationContract]
        List<string> GetCalculations();


        //[OperationContract]
        //int AddStatic(int firstNumber, int secondNumber);



    }
}
