
namespace AM.Business.Interfaces
{
    public interface IGenericService<IModel>
    {
        public List<IModel> GetAll();

        public void Add(IModel model);
        public void Update(IModel model);
        public void Delete(int id);
    }
}
