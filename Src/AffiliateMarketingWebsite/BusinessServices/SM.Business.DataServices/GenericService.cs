using AM.Business.Interfaces;
using AM.Data;
using AM.Data.Interfaces;
using AM.Data.Models;
using AutoMapper;

namespace AM.Business.DataServices
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        public GenericService(IRepository<TEntity>repository, IMapper mapper)
        {
            _repository= repository;
            _mapper= mapper;
        }

        //public List<TModel> Search()
        //{
        //    var AllEntity = _repository.GetAll();
        //    var allmodels = _mapper.Map<List<TModel>>(AllEntity);
        //    return allmodels;

        }
    public List<TModel> GetAll()
    {
        var AllEntity = _repository.GetAll();
        var allmodels = _mapper.Map<List<TModel>>(AllEntity);
        return allmodels;
    }

    public void Add(TModel model)
        {
             var entity=_mapper.Map<TEntity>(model);
            _repository.save(entity);
        }

    
        public void Update(TModel model)
        {
         var entity = _mapper.Map<TEntity>(model);
        _repository.save(entity);
        }
        public void Delete(int id)
        {
         var entity=_repository.Get(x=>x.Id==id).FirstOrDefault(); 
            if(entity!=null)
            {
                _repository.Delete(entity);
            }
        }

     
    }
