using Microsoft.SqlServer.Server;

public class TestClr
{
    [SqlFunction]
    public static string HelloWorld() => "Hello, World!";

}
