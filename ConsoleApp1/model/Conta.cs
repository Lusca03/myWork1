using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
    public class Conta
    {
        public IOrganizationService Service { get; set; }

        public string TableName = "account";


        public Conta(IOrganizationService service)
        {
            int n;
            this.Service = service;
        }


        public EntityCollection RetrieveMutipleContaByAccount(Guid accountId) 
        {
            QueryExpression queryConta = new QueryExpression(this.TableName);
            queryConta.ColumnSet.AddColumns ("fyi_oniveldocliente");
            queryConta.Criteria.AddCondition("accountid", ConditionOperator.Equal, accountId);
            

            return   this.Service.RetrieveMultiple(queryConta);

                

            
        
        }
        
        public EntityCollection RetrieveMutipleContaByAccountfetch(Guid accountId)
             
        {
            QueryExpression queryConta = new QueryExpression(this.TableName);
            queryConta.Criteria.AddCondition("accountid", ConditionOperator.Equal, accountId);
            queryConta.AddLink("account", "parentcontactid", "accountid", JoinOperator.Inner);
            queryConta.LinkEntities[0].Columns.AddColumns("fyi_oniveldocliente");
            queryConta.LinkEntities[0].EntityAlias = "foportunity";

            return this.Service.RetrieveMultiple(queryConta);
        }
    }
}
