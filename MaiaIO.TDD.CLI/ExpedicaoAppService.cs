using System.Data;

namespace MaiaIO.TDD.CLI
{


    public class ExpedicaoAppService
    {
        private static readonly IQueryable<Expedicao> MockResult =
            new[] { new Expedicao(1,"TCC", true),
                    new Expedicao(2,"WCC", true),
                    new Expedicao(3, "UTC", false),
                    new Expedicao(4, "XTC", false)}.AsQueryable();


        private readonly ICriterioBusca _bucador;
        public static void GetCriterios(FabricaListarRequest request)
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
            ICriterioBusca busca = CriterioSelect("BuscarPorStatus");


            Console.WriteLine(@"<===== BUSCA POR STATUS =====>");

            var result = MockResult.Where(busca.Buscar(searchCondition));


            foreach (var item in result)
            {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine(@"<===== BUSCA POR ID =====>");

            busca = CriterioSelect("BuscarPorId");



            result = MockResult.Where(busca.Buscar(searchCondition));

            foreach (var item in result)
            {
                Console.WriteLine(item.Nome);
            }
        }

        public static ICriterioBusca CriterioSelect(string selector) =>
      selector switch
      {
          "BuscarPorId" => new BuscarPorId(),
          "BuscarPorStatus" => new BuscarPorAtivo(),
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



    public interface ICriterioBusca
    {
        Func<Expedicao, bool> Buscar(Dictionary<string, dynamic> search);
    }

    public class BuscarPorId : ICriterioBusca
    {
        public Func<Expedicao, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.Id == search["Id"];
        }
    }

    public class BuscarPorAtivo : ICriterioBusca
    {
        public Func<Expedicao, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.IsActive == search["IsActive"];
        }
    }

    public class BuscarPorAtivoMaisId : ICriterioBusca
    {
        public Func<Expedicao, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.IsActive == search["IsActive"] && x.Id == search["Id"];
        }
    }


    public class BuscaExecutor
    {

        private readonly ICriterioBusca _busca;

        public BuscaExecutor(ICriterioBusca buscador)
        {
            _busca = buscador;
        }


        public void ExecutarBusca(dynamic param)
        {
            _busca.Buscar(param);
        }
    }

}
