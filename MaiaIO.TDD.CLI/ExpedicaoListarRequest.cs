using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI
{
    public class ExpedicaoListarRequest
    {

        [Required]
        [DefaultValue(0)]
        public long? Id { get; set; }

        [Required]
        [DefaultValue("no")]
        public string? Nome { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool? IsActive { get; set; }

        public  ExpedicaoListarRequest()
        {

        }

        public ExpedicaoListarRequest(long? id, string? nome, bool? isActive)
        {
            Id = id;
            //Nome = nome;
            IsActive = isActive;
        }

       


    }

    public class Expedicao
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public bool IsActive { get; set; }

        public Expedicao(long id, string nome, bool isActive)
        {
            Id = id;
            Nome = nome;
            IsActive = isActive;
        }
    }
}
