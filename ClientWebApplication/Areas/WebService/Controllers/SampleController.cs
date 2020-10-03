using ClientWebApplication.SampleService;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ClientWebApplication.Areas.WebService.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RequestReplyOperation()
        {
            string message;
            try
            {
                SampleServiceClient client = new SampleServiceClient();
                string processingTime = client.RequestReplyOperation();
                message = $"Request-Reply Operation Completed @ {DateTime.Now} - {processingTime}";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }


            return PartialView("RequestReplyOperation", message);
        }

        public ActionResult RequestReplyOperation_ThrowsException()
        {
            string message = string.Empty;

            try
            {
                SampleServiceClient client = new SampleServiceClient();
                client.RequestReplyOperation_ThrowsException();
            }
            catch (Exception ex)
            {
                message = $"Request-Reply Throws Exception Operation Completed @ {DateTime.Now} {ex.Message}";
            }

            return PartialView("RequestReplyOperation_ThrowsException", message);
        }

        public async Task<ActionResult> RequestReplyOperationAsync()
        {
            string message;
            try
            {
                SampleServiceClient client = new SampleServiceClient();
                string processingTime = await client.RequestReplyOperationAsync();
                message = $"Request-Reply Operation Completed @ {DateTime.Now} - {processingTime}";
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }


            return PartialView("RequestReplyOperation", message);
        }

        public async Task<ActionResult> RequestReplyOperation_ThrowsExceptionAsync()
        {
            string message = string.Empty;

            try
            {
                SampleServiceClient client = new SampleServiceClient();
                await client.RequestReplyOperation_ThrowsExceptionAsync();
            }
            catch (Exception ex)
            {
                message = $"Request-Reply Throws Exception Operation Completed @ {DateTime.Now} {ex.Message}";
            }

            return PartialView("RequestReplyOperation_ThrowsException", message);
        }
    }
}