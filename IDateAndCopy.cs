using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IDateAndCopy
    {
        object DeepCopy();
        DateOnly Date { get; init; }
    }
}
