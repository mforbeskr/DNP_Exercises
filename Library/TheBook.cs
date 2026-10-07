namespace Library;

public class TheBook
{
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public int? ReleaseYear { get; set; }
    public string? ShortDescription { get; set; }
    public string? Introduction { get; set; }
    public string? Language { get; set; }
    public int? Pages { get; set; }
    public int? ReadabilityScore { get; set; }


    private static void AddIfSet(List<string> list, object? value, string? text = null)
    {
        string? valueText = value?.ToString();
        if (string.IsNullOrWhiteSpace(valueText)) return;
        
        list.Add(text ?? valueText);
    }

    public void Inspect()
    {
        var sentences = new List<string>();
        sentences.Add(string.IsNullOrWhiteSpace(Name) ? "Untitled book" : $"{Name}");
        
        AddIfSet(sentences, Author, $"Written by {Author}");
        AddIfSet(sentences, Publisher, $"Written by {Publisher}");
        AddIfSet(sentences, ReleaseYear, $"Written by {ReleaseYear}");
        AddIfSet(sentences, ShortDescription, $"The back cover reads: {ShortDescription}");
        AddIfSet(sentences, Language, $"Original language: {Language}");
        AddIfSet(sentences, ReadabilityScore,$"Readability score: {ReadabilityScore}");
        AddIfSet(sentences, Pages, $"Pages: {Pages}");

        Console.WriteLine(string.Join (", ", sentences));
    }

    public override string ToString()
    {
        var givenInfo = new List<string>();
        AddIfSet(givenInfo, Name);
        AddIfSet(givenInfo, Author);
        AddIfSet(givenInfo, ReleaseYear);
        
        return string.Join(", ", givenInfo);
    }
}