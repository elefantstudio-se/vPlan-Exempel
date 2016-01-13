using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace vPlanDBApi
{
    [ServiceContract]
    public interface IvPlanDB
    {
        [OperationContract]
        bool addUser(User newUser);

        [OperationContract]
        bool delUser(Guid userID);

        [OperationContract]
        bool modUser(User newUser);

        [OperationContract]
        List<User> getAllUsers();

        [OperationContract]
        bool addArbetsplats(Arbetsplat newArb);

        [OperationContract]
        bool delArbetsplats(Guid arbID);

        [OperationContract]
        bool modArbetsplats(Arbetsplat newArb);

        [OperationContract]
        List<Arbetsplat> getAllArbetsplatser();

        [OperationContract]
        List<Arbetsplat> getAllPersonal(Arbetsplat arbPersonal);

        [OperationContract]
        bool addOrganisation(Organisation newOrg);

        [OperationContract]
        bool delOrganisation(Guid orgID);

        [OperationContract]
        bool modOrganisation(Organisation newOrg);

        [OperationContract]
        List<Organisation> getAllOrganisations();

        [OperationContract]
        List<Organisation> listAllArbetsplatser(Organisation orgArbetsplatser);
    }
}