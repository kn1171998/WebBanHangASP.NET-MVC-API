namespace WebData.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}