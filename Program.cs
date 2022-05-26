using BenchmarkDotNet.Running;
using EnumToString;

BenchmarkRunner.Run<BenchmarkEnumToString>();

Console.WriteLine(SessionState.STARTED.AsString());