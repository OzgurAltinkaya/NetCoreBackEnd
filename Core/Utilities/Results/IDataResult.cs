using System;
namespace Core.Utilities.Results
{
    public interface IDataResult<T> :IResult // T hangi tipi döndüreceğini bana söyle
    {
        T Data { get; }
    }
}
