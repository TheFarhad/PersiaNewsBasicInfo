namespace BasicInfo.Core.Domain.Keywords.Aggregate.Entity;

using Sky.Kernel.Shared;
using Sky.App.Core.Domain.Aggregate;
using Event;
using Enumers;
using ValueObject;

public class Keyword : Aggregate
{
    public KeywordTitle Title { get; private set; }
    public KeywordDescription Description { get; private set; }
    public KeywordStatus Status { get; private set; }

    private Keyword() { }
    private Keyword(KeywordTitle title, KeywordDescription description, KeywordStatus status) =>
        Init(title, description, status, null);

    public static Keyword Instnce(KeywordTitle title, KeywordDescription description, KeywordStatus status) =>
        new Keyword(title, description, status);

    private void Init(KeywordTitle title, KeywordDescription description, KeywordStatus status, Act action)
    {
        // validations...
        Apply(KeywordCreatedEvent.Instance(Code.Value, title.Value, description.Value, status.Value));
        action?.Invoke();
    }

    public void Edit(KeywordTitle title, KeywordDescription description, KeywordStatus status) =>
         Apply(KeywordEditedEvent.Instance(Code.Value, title.Value, description.Value, status.Value));

    private void On(KeywordCreatedEvent source) =>
        SetProperties(/*source.Code,*/ source.Title, source.Description, source.Status);

    private void On(KeywordEditedEvent source) =>
        SetProperties(/*source.Code,*/ source.Title, source.Description, source.Status);

    private void SetProperties(/*Guid code, */string title, string description, string status)
    {
        //Code = code;
        Title = title;
        Description = description;
        Status = KeywordStatus.Instance(status);
    }
}
