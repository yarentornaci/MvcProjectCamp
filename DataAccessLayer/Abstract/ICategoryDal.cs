using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD 
        //type, name();
        List<Category> List();


        //void kullandık geriye değer döndürmesini istemediğimiz için
        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);

    }
}
