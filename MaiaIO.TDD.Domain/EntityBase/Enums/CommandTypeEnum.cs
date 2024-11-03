using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MaiaIO.TDD.Domain.EntityBase.Enums
{
    public enum CommandTypeEnum
    {
        [Display(Name="Insert Command")]
        InsertCommand = 0x001,
        [Display(Name = "Insert Command")]
        UpdateCommand = 0x010,
        [Display(Name = "Insert Command")]
        DeleteCommand = 0x100
        
    }
}
