using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass;

public partial class MinhaPartialClass
{
    public TimeSpan CalculaIdade(DateTime DataNascimento)
    {
        return (DateTime.Now.Date - DataNascimento);
    }

    public TimeSpan DiferencaEntreDatas(DateTime data1,  DateTime data2)
    {
        var diferenca = data1.Subtract(data2);
        return diferenca;
    }
}
