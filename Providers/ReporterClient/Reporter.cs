using U.Types.Components;

namespace U.Providers.Reporter;


public class Reporter : IReporter
{
    public void Report(IReportExeption e)
    {
        throw new NotImplementedException("Send HTTP Message to Reporter Server, which handles further Actions");

    }
}