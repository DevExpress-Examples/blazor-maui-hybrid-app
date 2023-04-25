using BlazorDemo.Shared.Data.DataProviders;

namespace BlazorDemo.Shared.Data.Services
{
    public class IssuesDataService
    {
        readonly IIssuesDataProvider _dataProvider;

        public IssuesDataService(IIssuesDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }
        public Task<IEnumerable<Issue>> GetIssuesAsync(CancellationToken ct = default)
        {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetIssuesAsync(ct);
            /*EndHide*/
        }
        public Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default)
        {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetProjectsAsync(ct);
            /*EndHide*/
        }
        public Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default)
        {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetUsersAsync(ct);
            /*EndHide*/
        }
    }
}
