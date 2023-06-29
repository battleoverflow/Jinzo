# Jinzo

Jinzo is a C# abstraction and conversion library for converting HTML to numerous other formats

## Example

```csharp
using System;
using Jinzo;

namespace Program
{
    class Program
    {
        static void Main()
        {
            // Convert to another format
            Jinzo.Conversion.Convert("<HTML>.html", "<OUTPUT>.ext");
        }
    }
}
```
