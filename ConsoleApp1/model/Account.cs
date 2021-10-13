using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.model
{
   public class Account
    {

        public string TableName = "opportunity";

        public IOrganizationService Service { get; set; }

        public Account (IOrganizationService service)
        {
            this.Service = service;
        }


        public void UpdateAccount1()
        {
            
            double desconto = 0.10;
            double total2;
            Console.WriteLine("DIGITE O VALOR TOTAL");
            
             total2 = double.Parse(Console.ReadLine());
            

            double Toltal;
            Toltal =desconto *total2 ;
            Entity account = new Entity(this.TableName);
            account.Id = new Guid("303fd6c6-b335-4511-886b-fe3a2075c3dc");
            account["discountamount"] = Toltal;
                this.Service.Update(account);

        }

        public void UpdateAccount2()
        {

            double desconto = 0.03;
            double total2;
            Console.WriteLine("DIGITE O VALOR TOTAL");

            total2 = double.Parse(Console.ReadLine());


            double Toltal;
            Toltal = desconto * total2;
            Entity account = new Entity(this.TableName);
            account.Id = new Guid("303fd6c6-b335-4511-886b-fe3a2075c3dc");
            account["discountamount"] = Toltal;
            this.Service.Update(account);

        }


        public void UpdateAccount3()
        {

            double desconto = 0.05;
            double total2;
            Console.WriteLine("DIGITE O VALOR TOTAL");

            total2 = double.Parse(Console.ReadLine());


            double Toltal;
            Toltal = desconto * total2;
            Entity account = new Entity(this.TableName);
            account.Id = new Guid("303fd6c6-b335-4511-886b-fe3a2075c3dc");
            account["discountamount"] = Toltal;
            this.Service.Update(account);

        }



        public void UpdateAccount4()
        {

            double desconto = 0.07;
            double total2;
            Console.WriteLine("DIGITE O VALOR TOTAL");

            total2 = double.Parse(Console.ReadLine());


            double Toltal;
            Toltal = desconto * total2;
            Entity account = new Entity(this.TableName);
            account.Id = new Guid("303fd6c6-b335-4511-886b-fe3a2075c3dc");
            account["discountamount"] = Toltal;
            this.Service.Update(account);

        }





    }
}
