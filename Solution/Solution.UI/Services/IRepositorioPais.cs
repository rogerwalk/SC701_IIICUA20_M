using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution.UI.Services
{
    //se trabaja public por que viene a ser como una clase y a estas normalmente se le pone publicas
   public  interface IRepositorioPais
    {

        List<string> ObtenerTodos();
    }
}
