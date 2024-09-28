using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepo efCategoryRepo;

        public CategoryManager()
        {
            efCategoryRepo = new EfCategoryRepo();  

        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepo.Insert(category);
        }

        public void CategoryRemove(Category category)
        {
            efCategoryRepo.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepo.Update(category);
        }

        public Category GetByID(int id)
        {
            return efCategoryRepo.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepo.GetListAll();
        }
    }
}
