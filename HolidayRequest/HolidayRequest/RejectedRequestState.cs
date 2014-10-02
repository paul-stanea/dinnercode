namespace HolidayRequest
{
    public class RejectedRequestState : RequestState
    {
        public override void Process(HolidayRequest request)
        {
            new EmailSender().SendMail(request.EmployeeEmail);
        }
    }
}