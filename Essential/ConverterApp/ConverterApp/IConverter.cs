using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    public interface IConverter
    {
        decimal Convert(string outputType);
    }
}
