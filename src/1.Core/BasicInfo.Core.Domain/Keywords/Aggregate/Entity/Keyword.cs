namespace BasicInfo.Core.Domain.Keywords.Aggregate.Entity;

using Sky.Kernel.Shared;
using Sky.App.Core.Domain.Shared;
using Sky.App.Core.Domain.Aggregate;
using Event;
using Enumers;

public class Keyword : Aggregate
{
    public Title Title { get; private set; }
    public Description Description { get; private set; }
    public KeywordStatus Status { get; private set; }

    private Keyword() { }
    private Keyword(Title title, Description description, KeywordStatus status) => Init(title, description, status, () => { });

    public static Keyword Instnce(Title title, Description description, KeywordStatus status) =>
        new Keyword(title, description, status);

    private void Init(Title title, Description description, KeywordStatus status, Act action)
    {
        Apply(KeywordCreatedEvent.Instance(Code.Value, title.Value, description.Value, status.Value));
        action?.Invoke();
    }

    public void Edit(Title title, Description description, KeywordStatus status) =>
         Apply(KeywordEditedEvent.Instance(Code.Value, title.Value, description.Value, status.Value));

    private void On(KeywordCreatedEvent source) =>
        SetProperties(source.Code, source.Title, source.Description, source.Status);

    private void On(KeywordEditedEvent source) =>
        SetProperties(source.Code, source.Title, source.Description, source.Status);

    private void SetProperties(Guid code, string title, string description, string status)
    {
        Code = code;
        Title = title;
        Description = description;
        Status = KeywordStatus.Instance(status);
    }
}
