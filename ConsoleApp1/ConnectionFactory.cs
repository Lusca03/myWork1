using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConnectionFactory
    {
         public static IOrganizationService GetCrmService()
        {
           String connectionString=
                 "AuthType=OAuth;" +
                "Username=Grupo01FYI@grupo01fyi.onmicrosoft.com;" +
                "Password=GP01@fyi;" +
                "Url=https://orge50feebb.crm2.dynamics.com/;" +
                "AppId=147f2a6c-9c2e-4b41-8f01-639e4b2ccffb;" +
                "RedirectUri=app://58145B91-0C36-4500-8554-080854F2AC97;";
            CrmServiceClient crmServiceClient = new CrmServiceClient(connectionString);

            return crmServiceClient.OrganizationWebProxyClient;
                
        }
    }
}
