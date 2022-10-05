using U.Types.Identities;

namespace U.Types.Components;


public interface IReporter
{
    public void Report(IReportExeption e);
}

public interface IReportExeption
{
    public string message { get; set; }
    public Service service { get; set; }

}