namespace TestProject1;

using ClassLibrary1;

/*
Compilar

dotnet test --configuration Debug --no-restore --no-build --collect:"Code Coverage" --settings:ms.runsettings.xml

cd .\TestProject1\TestResults\9ddb0e75-236f-48a4-9a9e-c8908f275e98\
reportgenerator -reports:coverage.cobertura.xml -reportTypes:Html -targetDir:.

*/

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 class1 = new ClassLibrary1.Class1();

        string result = class1.Function1();

        Assert.True(result == "ok");
    }
}