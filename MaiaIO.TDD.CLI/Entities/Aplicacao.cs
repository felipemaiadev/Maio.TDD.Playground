using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI.Entities
{
    public class Aplicacao : Entity
    {
        public int Id { get; set; }
        public TipoApp Tipo { get; set; }
    }


    public enum TipoApp
    {
        web,
        mobile,
        desktop
    }
}
