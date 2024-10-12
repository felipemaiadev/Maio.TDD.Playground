using MaiaIO.TDD.CLI.Entities;
using System.Diagnostics;

namespace MaiaIO.TDD.CLI.Teste
{
    [CollectionDefinition(nameof(UserCollection))]
    public class UserCollection : ICollectionFixture<UsuarioTesteFixture> { }
    public class UsuarioTesteFixture : IDisposable
    {

        public UsuarioTesteFixture()
        {

        }

        public User GerarUserValido()
        {
            return new User
            {
                UID = Guid.NewGuid(),
                cargo = "Analista de Sistemas",
                nome = "Fulano De Tal",
                idade = 30
            };

        }




        public void Dispose()
        {
            Debug.WriteLine(@"Dispose Object: ", this.ToString());

        }
    }
}
