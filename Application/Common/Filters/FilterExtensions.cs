using Core.Abstractions;
using Core.Abstractions.Entities;

namespace Application.Common.Filters;

public static class FilterExtensions
{
    /// <summary>
    /// Aplica un filtrado a todos los campos string de la Entidad
    /// </summary>
    /// <param name="queryable"></param>
    /// <param name="text"></param>
    /// <param name="strict"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IQueryable<T> ApplySearch<T>(this IQueryable<T> queryable, string text, bool strict = false) 
        where T : IEntity
    {
        return queryable;
    }
    
}