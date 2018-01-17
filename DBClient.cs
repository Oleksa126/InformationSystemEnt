using System;
using System.Collections.Generic;
using System.Linq;

namespace InformationSystemEnt
{
    public class DBClient
    {
        public readonly informationSystemEntities DBinformationSystemEntities = new informationSystemEntities();

        public List<Client> getAllClient() {
            return DBinformationSystemEntities.Client.ToList();
        }

        public List<Client> linq() {
            var query = from Clients in DBinformationSystemEntities.Client
                        where
                            Clients.idClient == 5
                        select new 
                        {
                            idClient = Clients.idClient,
                            lastName = Clients.lastName,
                            firstName = Clients.firstName,
                            city = Clients.city,
                            loginClient = Clients.loginClient,
                            email = Clients.email,
                            passwordClient = Clients.passwordClient,
                            phoneNumber = Clients.phoneNumber
                        };
            var res = query.ToList().Select(r => new Client()
            {
                idClient = r.idClient,
                lastName = r.lastName,
                firstName = r.firstName,
                city = r.city,
                loginClient = r.loginClient,
                email = r.email,
                passwordClient = r.passwordClient,
                phoneNumber = r.phoneNumber

            }).ToList();

            return res;
        }

        public List<Client> procedure(int id) {
            var client = from res in DBinformationSystemEntities.P_GetClientInfo(id).ToList()
                         select new Client()
                         {                           
                             lastName = res.lastName,
                             firstName = res.firstName,
                             city = res.city,
                             loginClient = res.loginClient,
                             email = res.email,
                             phoneNumber = res.phoneNumber
                         };
            return client.ToList();
        }
        
    }
}
