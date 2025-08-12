using ApiMangas.Entities;

namespace ApiMangas.Extensions;

public static class IQueryableExtensions
{
    public static IQueryable<T> Paginar<T>(this IQueryable<T> query, Paginacao paginacao)
    {
        return query
            .Skip((paginacao.Pagina - 1) * paginacao.QuantidadePorPagina)
            .Take(paginacao.QuantidadePorPagina);
    }
}
