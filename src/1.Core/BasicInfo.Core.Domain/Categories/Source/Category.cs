namespace BasicInfo.Core.Domain.Categories.Source;

using Sky.App.Core.Domain.Aggregate;
using Events;
using Elements;

public class Category : Aggregate
{
    public CategoryTitle Title { get; private set; }
    public CategoryDescription Description { get; private set; }

    private Category() { }
    private Category(CategoryTitle title, CategoryDescription description) => Init(title, description, null);

    public static Category Instance(CategoryTitle title, CategoryDescription description) => new(title, description);

    private void Init(CategoryTitle title, CategoryDescription description, Action action)
    {
        // validations...
        Apply(CategoryCreatedEvent.Instance(Code.Value, title.Value, description.Value));
        action?.Invoke();
    }

    public void Edit(CategoryTitle title, CategoryDescription description) =>
             Apply(CategoryEditedEvent.Instance(Code.Value, title.Value, description.Value));

    private void On(CategoryCreatedEvent source) => SetProperties(source.Title, source.Description);

    private void On(CategoryEditedEvent source) => SetProperties(source.Title, source.Description);

    private void SetProperties(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
