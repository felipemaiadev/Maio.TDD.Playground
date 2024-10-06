using MaiaIO.TDD.Domain.Factories.Entities;
using System.Data;

namespace MaiaIO.TDD.CLI
{


    public class FactoryAppService
    {

        private readonly ICriterioBusca _bucador;
        public static void GetCriterios(FactoryListarRequest request)
        {
            var propiedades = request.GetType().GetProperties();

            string commando = string.Empty;

            foreach (var property in propiedades)
            {

                foreach (var item in property.CustomAttributes)
                {
                    Console.WriteLine(item.AttributeType);


                }

            }

            var searchCondition = BuildParser(new Expedicao(2, string.Empty, false));
            ICriterioBuscarFactory busca = CriterioSelect("BuscarPorStatus");


        }

        public static ICriterioBuscarFactory CriterioSelect(string selector) =>
      selector switch
      {
          "BuscarPorId" => new BuscarFactoryPorId(),
          "BuscarPorStatus" => new BuscarFactoryPorAtivo(),
          "BuscarPorPais" => new BuscarFactoryPorPais(),
          _ => throw new ArgumentException("Ausencia de criterios"),
      };


        public static Dictionary<string, dynamic> BuildParser(object obj)
        {

            var parameterColletion = new Dictionary<string, dynamic>();

            var properties = obj.GetType().GetProperties();


            foreach (var x in properties)
                parameterColletion.Add(x.Name, x.GetValue(obj));


            //Console.WriteLine(parameterColletion["Id"] == long.MaxValue);

            return parameterColletion;
        }

    }



    public interface ICriterioBuscarFactory
    {
        Func<Factory, bool> Buscar(Dictionary<string, dynamic> search);
    }

    public class BuscarFactoryPorId : ICriterioBuscarFactory
    {
        public Func<Factory, bool> Buscar(Dictionary<string, dynamic> search)
        {

            if (!search.TryGetValue("OPR", out var value)) search["OPR"] = "==";
           
            return value switch
            {
                "==" => x => x.CodRef == search["Id"],
                ">=" => x => x.CodRef >= search["Id"],
                _ =>  x => x.CodRef == search["Id"]
            };
               
        }
    }

    public class BuscarFactoryPorAtivo : ICriterioBuscarFactory
    {
        public Func<Factory, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.IsActive == search["IsActive"];
        }
    }

    public class BuscarfactoryPorAtivoMaisId : ICriterioBuscarFactory
    {
        public Func<Factory, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.IsActive == search["IsActive"] && x.Id == search["Id"];
        }
    }

    public class BuscarFactoryPorPais : ICriterioBuscarFactory
    {
        public Func<Factory, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.Coutry.Contains(search["Country"]);
        }
    }

    public class BuscaFactoryExecutor
    {

        private readonly ICriterioBuscarFactory _busca;

        public BuscaFactoryExecutor(ICriterioBuscarFactory buscador)
        {
            _busca = buscador;
        }


        public void ExecutarBusca(dynamic param)
        {
            _busca.Buscar(param);
        }
    }

}
