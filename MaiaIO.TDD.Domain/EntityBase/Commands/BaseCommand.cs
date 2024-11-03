using MaiaIO.TDD.Domain.EntityBase.BaseMessages;
using MaiaIO.TDD.Domain.EntityBase.Enums;

namespace MaiaIO.TDD.Domain.EntityBase.Commands
{
    public class BaseCommand<T> : BaseMessage where T : Entity
    {
        public string cmdSelector { get; protected set; }
        public CommandTypeEnum cmdType { get; protected set; }
        public T Value { get; protected set; }

        protected BaseCommand(string command)
        {
            SetCommandSelector(command);
        }

        protected void SetCommandSelector(string command)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));
            if (string.IsNullOrWhiteSpace(command)) throw new ArgumentNullException(nameof(command));

            cmdSelector = command;
        }

        protected void SetCommandType(CommandTypeEnum type)
        {
            if (type == null) throw new ArgumentNullException("Tipo de comando não informado");
            if (Enum.IsDefined(typeof(CommandTypeEnum), type)) throw new ArgumentException("O comando informado não é reconhecido");

            cmdType = type;
        }

        protected void SetValue(T value)
        {
            if (value is null) throw new ArgumentNullException("Entidade a ser persistiva está inválida");

            Value = value;

        }
    }
}
