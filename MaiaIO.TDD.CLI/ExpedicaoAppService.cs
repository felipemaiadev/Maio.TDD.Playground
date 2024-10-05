using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        public static void GetCriterios(ExpedicaoListarRequest request)
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

            var searchCondition = new Dictionary<string, dynamic>();

            searchCondition.Add("Id", 1);
            searchCondition.Add("Name", "XTC");
            searchCondition.Add("IsActive", false);

            ICriterioBusca busca = CriterioSelect("BuscarPorStatus");

            var predicate = new Expedicao ( long.MinValue, string.Empty, false );

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


    }




    public interface ICriterioBusca
    {
        Func<Expedicao, bool> Buscar(Dictionary<string,dynamic> search);
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
            return x => x.IsActive == search["IsActive"] ;
        }
    }

    public class BuscarPorAtivoMaisId : ICriterioBusca
    {
        public Func<Expedicao, bool> Buscar(Dictionary<string, dynamic> search)
        {
            return x => x.IsActive == search["IsActive"]  && x.Id == search["Id"];
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
