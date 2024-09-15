using Bogus;
using Bogus.DataSets;
using MaiaIO.TDD.CLI.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Id = Guid.NewGuid(),
                cargo = "Analista de Sistemas",
                nome = "Fulano De Tal",
                idade = 30
            };

        }




        public void Dispose()
        {
            Debug.WriteLine(@"Dispose Object: " , this.ToString());

        }
    }
}
