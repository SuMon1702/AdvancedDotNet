﻿namespace SMAdvancedC_DotNet.shared
{
    public static class Extension
    {
        public static IQueryable<TSource> Paginate<TSource>(this IQueryable<TSource> sources, int pageNo, int pageSize)
        {
            return sources.Skip((pageNo - 1) * pageSize).Take(pageSize);
        }
    }
}
