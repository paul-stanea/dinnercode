using System;

namespace HolidayRequest
{
    public abstract class HolidayRequest
    {
        public string EmployeeName;
        public string EmployeeEmail;
        public string ManagerEmail;

        // holiday period
        public DateTime From;
        public DateTime To;

        public void Process(RequestState requestState)
        {
            requestState.Process(this);
        }
    }
}
