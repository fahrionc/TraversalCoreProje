﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID(int id);
        //şartlı listeleme yapıyoruz
        // Aşağıdaki syntax üzerinden arama yapıcaz
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
        
    }
}
