using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {

    }
}
