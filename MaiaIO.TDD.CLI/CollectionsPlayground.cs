using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI
{
    public static class CollectionsPlayground
    {

        public static int GetIndexOfFirstNonEMptyBin(int[] bins) => Array.FindIndex(bins, IsNonZero);

        private static bool IsNonZero(int value) => value != 0;

        public static int FindIndex<T>(T[] vetor, Predicate<T> match) 
        {
           return Array.FindIndex<T>(vetor, match);
        }
    }


    public class Equipamento
    {

        public int valor { get; set; }
        public string nome { get; set; }
        public int  code {  get; set; }

        public bool IsValid { get; set; }
        public Equipamento()
        {
            
        }
    }
}
