using RunLengthEncodingApp;

Console.WriteLine("Input your string");
string input = Console.ReadLine() ?? string.Empty;
Console.Write(input.RunLengthEncode());
