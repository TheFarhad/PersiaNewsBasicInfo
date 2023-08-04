namespace BasicInfo.Core.Domain.Keywords.Aggregate.Enumers;

using Sky.Kernel.Shared;

public class KeywordStatus : Enumer
{
    private KeywordStatus(string value) : base(value) { }
    private KeywordStatus() : this(String.Empty) { }

    public static KeywordStatus Instance() => new KeywordStatus();
    public static KeywordStatus Instance(string value) => new KeywordStatus(value);

    public override string Display
    {
        get
        {
            var result = Value switch
            {
                "Preview" => "پیش نمایش",
                "Active" => "فعال",
                "Inactive" => "غیر‌فعال",
                _ => "ناشناخته",
            };
            return result;
        }
    }

    public static readonly KeywordStatus Unknown = new KeywordStatus();
    public static readonly KeywordStatus Preview = new KeywordStatus("Preview");
    public static readonly KeywordStatus Active = new KeywordStatus("Active");
    public static readonly KeywordStatus Inactive = new KeywordStatus("Inactive");

    public static readonly List<KeywordStatus> Items = new();
    static KeywordStatus()
    {
        //Items.Add(Unknown);
        Items.Add(Preview);
        Items.Add(Active);
        Items.Add(Inactive);
    }
}
