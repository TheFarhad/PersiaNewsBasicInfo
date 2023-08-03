namespace BasicInfo.Core.Domain.Keywords.Aggregate.Entity;

using Event;
using Sky.Kernel.Shared;
using Sky.App.Core.Domain.Shared;
using Sky.App.Core.Domain.Aggregate;

public class Keyword : Aggregate
{
    public Title Title { get; private set; }
    public Description Description { get; private set; }

    private Keyword() { }
    private Keyword(Title title, Description description) => Init(title, description, () => { });

    public static Keyword Instnce(Title title, Description description) => new Keyword(title, description);

    private void Init(Title title, Description description, Act action)
    {
        Apply(KeywordCreatedEvent.Instance(Code.Value, title.Value, description.Value));
        action?.Invoke();
    }

    public void Edit(Title title, Description description) =>
         Apply(KeywordEditedEvent.Instance(Code.Value, title.Value, description.Value));


    private void On(KeywordCreatedEvent source) =>
        SetProperties(source.Code, source.Title, source.Description);

    private void On(KeywordEditedEvent source) =>
        SetProperties(source.Code, source.Title, source.Description);

    private void SetProperties(Guid code, string title, string description)
    {
        Code = code;
        Title = title;
        Description = description;
    }
}
