using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.Added);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.Deleted);
        }

        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new DataResult<List<Category>>(_categoryDal.GetAll(), true, Messages.Listed);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
