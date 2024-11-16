namespace TaskManager.Contracts
{
    public interface IDbTransaction
    {
        public Task UsingTransactionAsync(Func<Task> asyncAction, CancellationToken token = default);
    }
}
