using AutoMapper;
using DataAccessLayer.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BrandService : IBrandService
    {
        private readonly IMapper _mapper;
        protected IUnitOfWork UnitOfWork { get; private set; }

        public BrandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<BrandModel> GetAll()
        {
            var brands = UnitOfWork.BrandRepository.GetAll();
            return _mapper.Map<List<BrandModel>>(brands);
        }

        public BrandModel Get(int id)
        {
            var brand = UnitOfWork.BrandRepository.Get(id);
            return _mapper.Map<BrandModel>(brand);
        }

        public void Add(BrandModel brandModel)
        {
            if (string.IsNullOrWhiteSpace(brandModel.Name))
            {
                throw new ArgumentException("The brand name cannot be empty");
            }

            var brandEntity = _mapper.Map<Brand>(brandModel);

            UnitOfWork.BrandRepository.Add(brandEntity);
            UnitOfWork.Save();
        }
    }
}