using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        public ExpedicaoListarRequest()
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
        public string Descricao { get; set; }

        public ExpedicaoTypeEnum ExpedicaoType { get; set; }


        public Expedicao(long id, string nome, bool isActive)
        {
            Id = id;
            Nome = nome;
            IsActive = isActive;
        }

        public Expedicao(long id, string nome, bool isActive, ExpedicaoTypeEnum expedicaoType)
        {
            ExpedicaoType = expedicaoType;
            Id = id;
            Nome = nome;
            IsActive = isActive;

        }
    }

    public enum ExpedicaoTypeEnum
    {

        None = 0b_0000,
        Correios = 0b_0001,
        Transportadora = 0b_0010,
        CarroPropio = 0b_0100,
        Retira = 0b_1000
    }
}
