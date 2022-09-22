namespace Example.Services;

public class TestService : ITestService, ITestService2
{
    public string GetOne()
    {
        throw new NotImplementedException();
    }

    public string GetTwo()
    {
        throw new NotImplementedException();
    }
}