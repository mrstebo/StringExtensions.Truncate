[![Build status](https://ci.appveyor.com/api/projects/status/1rf621l2p5pu9d7i?svg=true)](https://ci.appveyor.com/project/mrstebo/stringextensions-truncate)
[![MyGet Prerelease](https://img.shields.io/myget/mrstebo/v/StringExtensions.Truncate.svg?label=MyGet_Prerelease)](https://www.myget.org/feed/mrstebo/package/nuget/StringExtensions.Truncate)
[![NuGet Version](https://img.shields.io/nuget/v/StringExtensions.Truncate.svg)](https://www.nuget.org/packages/StringExtensions.Truncate/)

# StringExtensions.Truncate
Simple library for adding the Truncate method to string.

## How to use it

This library adds a simple extension to the `string` class. Here are some examples:

```cs
"Hello".Truncate(10);       // Prints "Hello"
"Hello".Truncate(2);        // Prints "He"
"Hello".Truncate(2, "..."); // Prints "He..."
```
