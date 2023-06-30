# Jinzo

Jinzo is an abstraction and conversion library for converting HTML to numerous other formats.

This library is currently available on NuGet and can be installed using the dotnet

```bash
dotnet add package Jinzo --version 0.1.0
```

## Usage

```csharp
using Jinzo;

class Program
{
    static void Main()
    {
        // Convert to another format
        Jinzo.Jinzo.Convert("<HTML>.html", "<OUTPUT>.ext");
    }
}
```

This project is currently in a very early stage with only the ability to convert HTML to TXT. More updates will hopefully be coming soon!