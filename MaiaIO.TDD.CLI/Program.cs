// See https://aka.ms/new-console-template for more information


using MaiaIO.TDD.CLI;

var busca = new ExpedicaoListarRequest (0,"",true);
var service = new ExpedicaoAppService();

ExpedicaoAppService.GetCriterios(busca);
