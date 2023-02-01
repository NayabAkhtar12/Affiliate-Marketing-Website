
namespace AM.Business.Interfaces
{
    public interface IGenericService<IModel>
    {
        // public List<IModel> Search();
        public List<IModel> GetAll();

        public void Add(IModel model);
        public void Delete(int id);

        public void Update(IModel model);
    }
}
