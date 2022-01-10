using System;
using System.Linq.Expressions;
using BelajarCoreThree.Infrastructures.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace BelajarCoreThree.Infrastructures
{
    public class BaseRepository
    {
        protected readonly DataContext _dbContext;

        public BaseRepository(DataContext dataContext)
        {
            dataContext.Database.SetCommandTimeout(180);
            _dbContext = dataContext;
        }
        
        public static Expression<Func<T, object>> CreateExpression<T>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T)); //x =>
            Expression property = parameter;
            if (propertyName.Contains('.'))
            {
                //x => x.{table}.{kolom}
                foreach (var member in propertyName.Split('.'))
                {
                    property = Expression.PropertyOrField(property,
                        member);
                }
            }
            else
            {
                //x => x.{kolom}
                property = Expression.Property(parameter, propertyName);
            }
            var convert = Expression.Convert(property, typeof(object));
            var finalExpression = Expression.Lambda<Func<T, object>>(convert, parameter);
            return finalExpression;
            
        }
    }
}