using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.KawaiiRed.NET.Enums;

public class GenericEndpointType
{
    public GenericEndpointType(string Singular, string Verb)
    {
        this.Singular = Singular;
        this.Verb = Verb;
    }

    public string Singular { get; }

    public string Verb { get; }
}
