using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TourService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool addUser(String email, String fname, String lname, String password);
    }
}
