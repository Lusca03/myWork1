using ConsoleApp1.model;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          IOrganizationService service = ConnectionFactory.GetCrmService();

            Conta conta = new Conta(service);
            EntityCollection resultado = conta.RetrieveMutipleContaByAccount(new Guid("12f16f51-cc2b-ec11-b6e6-00224837acd7"));

            foreach (Entity ContaCRM in resultado.Entities)
            {
                string choice;
                Console.WriteLine("VOCE DESEJA APLICAR O DESCONTO ? y/n");
                choice = Console.ReadLine();
                if (choice == "y")
                {
                    
                    EntityReference niveldocliente = (EntityReference)ContaCRM["fyi_oniveldocliente"];
                    Console.WriteLine(niveldocliente.Name);
                    Console.WriteLine(ContaCRM.KeyAttributes);
                    if (niveldocliente.Name == "Diamond")
                    {
                        Account account = new Account (service);
                        account.UpdateAccount1();
                    }

                    if(niveldocliente.Name == "Silver") 
                    {
                        Account account = new Account(service);
                        account.UpdateAccount2();
                    }

                    if (niveldocliente.Name=="Gold")
                    {
                        Account account = new Account(service);
                        account.UpdateAccount3();
                    }

                    if (niveldocliente.Name == "Platinum")
                    {
                        Account account = new Account(service);
                        account.UpdateAccount4();

                    }
                }
                else
                {
                    Console.WriteLine("OK, OBRIGADO E TENHA UM BOM DIA");
                }
            }
            
            Console.ReadKey();
        }

    }
}
