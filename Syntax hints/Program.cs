using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_hints
{
    class Program
    {
        static void Main(string[] args)
        {
            [A] (Attribute)
# (Directive)
{0} (Format)
<T> (Generic)
{[0] = 1} (Indexer initializer)
: (Inheritance)
=> (Lambda)
% (Modulo)
? (Nullable)
?? (Null coalescing)
?. (Null conditional)
D (Numeric suffix)
$"{x}" (String interpolation)
? (Ternary)
* (Unsafe)
@ (Verbatim literal)

        }
    }
}
