namespace HolidayRequest
{
    public class PendingRequestState : RequestState
    {
        public override void Process(HolidayRequest request)
        {
            new EmailSender().SendMail(request.ManagerEmail);
        }
    }
}