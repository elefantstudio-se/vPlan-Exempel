
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.IdentityModel;


namespace vPlanRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class vPlanRole : IvPlanRole
    {
       public string userAuth()
        {
            
            var claims = ((ClaimsIdentity)Thread.CurrentPrincipal.Identity).Claims;
            var username = claims.SingleOrDefault(c => c.Type == "username").ToString();

            return "Välkommen till vPlanAPI, " + Thread.CurrentPrincipal.Identity.Name +" (" + username + ")";

            
        }
    }
}
