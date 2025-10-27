namespace RestWithASPNET10Erudio.Model;

public class Greeting
{
    public long Id { get; init; }
    public string Content { get; init; }

    public Greeting(long id, string content) => (Id, Content) = (id, content);
}
