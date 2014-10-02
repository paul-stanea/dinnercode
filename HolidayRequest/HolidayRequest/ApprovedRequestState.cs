namespace HolidayRequest
{
    public class ApprovedRequestState : RequestState
    {
        public override void Process(HolidayRequest request)
        {
            new EmailSender().NotifyHR();
        }
    }
}