using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SelfHostedAPI.Controller
{
    public class HelloController : ApiController
    {
        [Route("Hello")]
        public IHttpActionResult GetHello()
        {
            return Content(System.Net.HttpStatusCode.OK, "SelfHostedServer");
        }
        [Route("api/get")]
        // GET api/values 
        public IEnumerable<string> Get()
        {
            MailMessage mailMessage = new MailMessage();
            MailAddress fromAddress = new MailAddress("mail@mail.com");
            mailMessage.From = fromAddress;
            mailMessage.To.Add("mail@mail.com");
            mailMessage.Body = "This is Testing Email Without Configured SMTP Server";
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = " Testing Email";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "localhost";
            smtpClient.Send(mailMessage);
            return new string[] { "value1", "value2" };
        }

        [Route("api/get/{id}")]
        // GET api/values/5 
        public string Get(int id)
        {
            MailMessage mailMessage = new MailMessage();
            MailAddress fromAddress = new MailAddress("mail@mail.com");
            mailMessage.From = fromAddress;
            mailMessage.To.Add("mail@mail.com");
            mailMessage.Body = "This is Testing Email Without Configured SMTP Server";
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = " Testing Email";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("localhost");
            smtp.Send(mailMessage);//Handles all messages in the protocol
            smtp.Dispose();//sends a Quit message
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }
        [Route("api/post")]

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }
        [Route("api/delete")]

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
    [HubName("myHub")]
    public class MyHub : Hub
    {
        public override Task OnConnected()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            Console.WriteLine("ConnectedId : " +Context.ConnectionId);
            return base.OnConnected();

        }
        public void Send(string data)
        {
            ////IN ORDER TO INVOKE SIGNALR FUNCTIONALITY DIRECTLY FROM SERVER SIDE WE MUST USE THIS
            //var hubContext = GlobalHost.ConnectionManager.GetHubContext<MyHub>();

            ////PUSHING DATA TO ALL CLIENTS
            //hubContext.Clients.All.Add(data);


        }
    }
}
