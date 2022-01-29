# Flurl.Http without dependencies

This is a fork of Flurl (https://github.com/tmenier/Flurl) with only one change. The default serializer is removed.

Flurl.Http includes a dependency on Newtonsoft.Json as it's used as the default Json serializer.

Although you can change the serializer the dependency will remain. In constrained environments as Blazor you end downloading a big file you don’t need.

So this library is tracking the official repository of Flurl.Http and repacks it without the dependency. You should make no changes in your code replacing the official library with this one.

## Warning !!!

As there are now no default serializer your code WILL FAIL on runtime if you don’t configure any Json serializer. See in the samples how to use

* System.Text.Json: https://github.com/pablopioli/Flurl/blob/Samples/TextJson/Program.cs
* Jil: https://github.com/pablopioli/Flurl/blob/Samples/JilSample/Program.cs

For additional information about Jil see https://github.com/kevin-montrose/Jil


## Get it on NuGet:

`PM> Install-Package Flurl.Http.NoDependencies`
