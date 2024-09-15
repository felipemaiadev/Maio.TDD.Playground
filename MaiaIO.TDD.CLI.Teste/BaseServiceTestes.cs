using MaiaIO.TDD.CLI.Entities;
using MaiaIO.TDD.CLI.Repository;
using MaiaIO.TDD.CLI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Moq;

namespace MaiaIO.TDD.CLI.Teste
{
    [Collection(nameof(UserCollection))]
    public class BaseServiceTestes
    {
     
        UsuarioTesteFixture _fixture;
        private readonly IConfiguration _configuration;

        public BaseServiceTestes(UsuarioTesteFixture fixture,
                                 IConfiguration configuration)
        {
            this._fixture = fixture;
            this._configuration = configuration;
        }

        [Fact(DisplayName ="Testa chamadas interna do servico")]
        [Trait("UserService", "Testa persistencia do usuario")]
        public async void BaseService_DevePersistirUsuarioNoCadastro()
        {
            //Arrange
            //var userService = new Mock<IBaseService<User>>();

            var context = new LocalContext(_configuration);

            var userServiceBase = new BaseRepository<User>(context);

            //Act
            var user = _fixture.GerarUserValido();


            //Assert
            
            //userService.Setup(x => x.AddUser(It.IsAny<User>())).ReturnsAsync(true);

             Assert.True(await userServiceBase.AddUser(user));

        }
    }
}