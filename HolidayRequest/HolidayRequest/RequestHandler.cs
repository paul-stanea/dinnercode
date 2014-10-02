namespace HolidayRequest
{
    public class RequestHandler
    {
        public HolidayRequest request;

        public RequestHandler(HolidayRequest request)
        {
            request.Process(new PendingRequestState());
        }

        public void Aprove(HolidayRequest request)
        {
            request.Process(new ApprovedRequestState());
        }

        public void Reject(HolidayRequest request)
        {
            request.Process(new RejectedRequestState());
        }
    }
}