using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace vPlanDBApi
{
    public class vPlanDB: IvPlanDB
    {
        vPlanLinqSQLDataContext data = new vPlanLinqSQLDataContext();


        //-------------------------------------
        // Användar operationer, admin api
        //-------------------------------------
        public bool addUser(User newUser)
        {
            try
            {
                data.Users.InsertOnSubmit(newUser);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delUser(Guid userID)
        {
            try
            {
                User userToDelete = (from user in data.Users
                                             where user.Id == userID
                                             select user).Single();
                data.Users.DeleteOnSubmit(userToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool modUser(User newUser)
        {
            try
            {
                User userToModify = (from user in data.Users
                                             where user.Id == newUser.Id
                                             select user).Single();
                userToModify.FirstName = newUser.FirstName;
                userToModify.LastName = newUser.LastName;
                userToModify.EmailAdress = newUser.EmailAdress;
                userToModify.Arbetsplats = newUser.Arbetsplats;
                userToModify.employForm = newUser.employForm;
                userToModify.employProcent = newUser.employProcent;
                userToModify.createdOn = newUser.createdOn;
                userToModify.Active = newUser.Active;
                userToModify.UserName = newUser.UserName;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> getAllUsers()
        {
            try
            {
                return (from user in data.Users
                        select user).ToList();
            }
            catch
            {
                return null;
            }
        }

        //
        //


        public bool addArbetsplats(Arbetsplat newArb)
        {
            try
            {
                data.Arbetsplats.InsertOnSubmit(newArb);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delArbetsplats(Guid arbID)
        {
            try
            {
                Arbetsplat ArbToDelete = (from arb in data.Arbetsplats
                                          where arb.Id == arbID
                                          select arb).Single();
                data.Arbetsplats.DeleteOnSubmit(ArbToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool modArbetsplats(Arbetsplat newArb)
        {
            try
            {
                Arbetsplat ArbToModify = (from arb in data.Arbetsplats
                                          where arb.Id == newArb.Id
                                          select arb).Single();
                ArbToModify.Namn = newArb.Namn;
                ArbToModify.Ansvarig = newArb.Ansvarig;
                ArbToModify.Adress = newArb.Adress;
                ArbToModify.Postnummer = newArb.Postnummer;
                ArbToModify.Stad = newArb.Stad;
                ArbToModify.Telefonummer = newArb.Telefonummer;
                ArbToModify.Direktnummer = newArb.Direktnummer;
                ArbToModify.Organisations = ArbToModify.Organisations;
                ArbToModify.personal_id = ArbToModify.personal_id;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Arbetsplat> getAllArbetsplatser()
        {
            try
            {
                return (from org in data.Arbetsplats
                        select org).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Arbetsplat> getAllPersonal(Arbetsplat arbPersonal)
        {
            try
            {
                return (from p in data.Arbetsplats
                        where p.personal_id == arbPersonal.personal_id
                        select p).ToList();
            }
            catch
            {
                return null;
            }
        }

        //
        //

        public bool addOrganisation(Organisation newOrg)
        {
            try
            {
                data.Organisations.InsertOnSubmit(newOrg);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delOrganisation(Guid orgID)
        {
            try
            {
                Organisation OrgToDelete = (from org in data.Organisations
                                            where org.Id == orgID
                                            select org).Single();
                data.Organisations.DeleteOnSubmit(OrgToDelete);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool modOrganisation(Organisation newOrg)
        {
            try
            {
                Organisation OrgToModify = (from org in data.Organisations
                                            where org.Id == newOrg.Id
                                            select org).Single();
                OrgToModify.Namn = newOrg.Namn;
                OrgToModify.Telefonummer = newOrg.Telefonummer;
                OrgToModify.Ansvarig = newOrg.Ansvarig;
                OrgToModify.Arbetsplat = newOrg.Arbetsplat;
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Organisation> getAllOrganisations()
        {
            try
            {
                return (from org in data.Organisations
                        select org).ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Organisation> listAllArbetsplatser(Organisation orgArbetsplatser)
        {
            try
            {
                return (from p in data.Organisations
                        where p.arbetsplatser_id == orgArbetsplatser.arbetsplatser_id
                        select p).ToList();
            }
            catch
            {
                return null;
            }
        }
    }
}