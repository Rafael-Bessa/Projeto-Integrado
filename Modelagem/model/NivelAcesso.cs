using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.model
{
    //O cliente vai poder interagir com o sistema através de páginas web/mobile
    public enum NivelAcesso
    {
        ADMINISTRADOR = 1,    
        FUNCIONARIO = 2,
        CLIENTE = 3,
        SEM_ACESSO = 4
    }
}
