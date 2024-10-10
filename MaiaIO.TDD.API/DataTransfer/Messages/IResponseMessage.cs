using AutoMapper;

namespace MaiaIO.TDD.API.DataTransfer.Messages
{
    public interface IResponseMessage
    {

        Mapper ObjectResult(Object obj);
    }
}
