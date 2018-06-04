using System;
using System.Collections.Generic;
using System.Text;

using Genesis.AppServices;
using Genesis.Domain.Repository;
using Genesis.Infrastructure.Repository;


namespace TestConsole
{

    public class Services
    {

        private readonly IUnitOfWork UnitOfWork;
        
        public Services(IUnitOfWork uow)
        {
            this.UnitOfWork = uow;
            //ölköl
        }

        public void Serv1()
        {

            //public async Task Send(string PlattformEmail, string PlattformName, string ToEmail, string ToName, string Subject, string Content)
            //gridServ.SendAsync( "gomal.tao@gmail.com", "gabriel.tekin@gmail.com", "sub1", "cont1", "p1", "g1" ).Wait();

            //var xx = StripeTestSettings.baseUrl;
        }

        public void Serv2()
        {

            //OrderProcesser op = new OrderProcesser(uow, null, EService, conf);
            //op.ConfirmOrderSendGrid();
        }

        public void Serv3()
        {

/*
            IEmailService EService = new EmailService(conf);
            IEmailService EService = new EmailServiceMailGun(conf);
            EmailMessage message = new EmailMessage();
            message.FromAddresses.Add(new EmailAddress() { Name = "gabtek", Address = "gabriel.tekin@gmail.com" });
            message.ToAddresses.Add(new EmailAddress() { Name = "t1", Address = "gabriel.tekin@gmail.com" });
            message.Subject = "gun1";
            message.Content = "cont1";
            EService.Send(message);
*/
        }
        public void Serv4()
        {
            //var OrderServ = new OrderServices(uow);
            //var rep = OrderServ.GetOrdersByCompany("o1");
        }

        public void Serv5()

        {

            //OrderProcesser op = new OrderProcesser(uow, new OrderProcessDTO(), EService);
            //var ord = rep.InstantList.FirstOrDefault();
            //OrderProcesser op = new OrderProcesser(uow, new OrderProcessDTO(), EService);
            //var ord = rep.InstantList.FirstOrDefault();
            //op.ConfirmOrder("gabriel.tekin@gmail.com", ord);  
            //op.ConfirmOrder(new Order("c1", "o1", new DateTime(2018, 1, 1), null));
        }

        public void Serv8()
        {
            //var DepServ = new DepartmentServices(uow);
            //var deps = DepServ.getOpenDepartments("o1", new DateTime(2018, 2, 21));
            //var res = DepServ.getClosedDates("o1", new DateTime(2018, 2, 18), new DateTime(2018, 2, 28));
            //var res = DepServ.getClosedDates("o1", new DateTime(2018, 3, 1), new DateTime(2020, 3, 1));
        }

        public void Serv9()
        {
            //var PersonalService = new PersonalCustomerServices(CompRep,  PersRep);
            //PersonalService.AddPersonalCustomer( "o1","gabrie", "tekin", "gabriel.tekin@gmail.com", "s1", "p1", "c1");
        }

        public void Serv10()
        {

            //var str = "hejacder";
            //var res = IdentityHelper.getParts(str);
            //var res2 = IdentityHelper.GetUserName("hello","gabriel");
        }

        public void Serv11()
        {
            ////var ExceptionService = new OpenHourExceptionServices(uow);
            //ExceptionService.Add(97, new DateTime(2018, 2, 28), new   TimeSpan(0,0,0), TimeSpan.FromHours(19));
            //var res = ExceptionService.Delete(138);
            //ExceptionService.Delete(110, new DateTime(2018, 2, 24));
            //var res = ExceptionService.Delete(158);
        }

        public void Serv12()
        {

            //var CatServ = new CategoryServices(uow);
            //CatServ.DeleteCategory(137);
            //CatServ.AddCategory("o1",0,"t11","d11"  );
        }

        public void Serv13()
        {
            //var OrderServ = new OrderServices(uow);
            //var OrderID =  OrderServ.CreateOrder("customer1", new DateTime(2018, 2,23));


        }



    }
}
