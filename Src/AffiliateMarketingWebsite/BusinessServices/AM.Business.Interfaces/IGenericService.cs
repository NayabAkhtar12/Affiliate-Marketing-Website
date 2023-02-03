
namespace AM.Business.Interfaces
{
    public interface IGenericService<TModel>
    {
        // public List<IModel> Search();
        public List<TModel> GetAll();
        public TModel GetById(int id);

        public void Add(TModel model);
        public void Delete(int id);

        public void Update(TModel model);
    }
}
