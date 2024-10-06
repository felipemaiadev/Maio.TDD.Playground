namespace MaiaIO.TDD.CLI.CustomFilters
{
    public interface IGenericFilter<T>
    {
        Func<T, bool> Filter(Dictionary<string, dynamic> search);
    }

    //public  class GenericFilterById<T> : IGenericFilter<T>
    //{
    //    public T instace;
    //    public Func<T, bool> Filter(Dictionary<string, dynamic> search)
    //    {
    //        var predicate = nameof(T) switch(this T obj)
    //        {
    //            nameof(Expedicao) => x => x.Id == search["Id"],
    //            _ => throw new ArgumentNullException("Not Defined Type"),
    //        };

    //        return predicate;
    //    }

    //    public static Func<T, bool> sw
    //}

}
