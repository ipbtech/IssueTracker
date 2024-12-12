using IssueTracker.Entities;
using IssueTracker.Entities.Projections;

namespace IssueTracker.DAL.Contracts
{
    public interface IIssueRepository : IRepository<Issue>
    {
        public Task<IEnumerable<IssueView>> GetWorkTaskTableViewsAsync(int count, int page, int sortType, int? userFilter, int? statusFilter);
    }
}
