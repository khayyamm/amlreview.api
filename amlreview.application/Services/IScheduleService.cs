using amlreview.dataaccess;

namespace amlreview.application
{
    public interface IScheduleService
    {
        CompanyScheduleDto CreateNotification(Company company);
    }
}