using PrototypeSample.Protypes.Contracts;

namespace PrototypeSample.Protypes.Implements;
public class WordDocument : IPrototype
{
    #region Field
    private readonly string _content;
    private readonly string _author;
    #endregion

    public WordDocument(string content, string author)
    {
        _content = content;
        _author = author;
    }

    public IPrototype Clone()
    {
        return new WordDocument(_content, _author);
    }

    public void Display()
    {
        Console.WriteLine($"Word Document - Author: {_author}");
        Console.WriteLine($"Content: {_content}\n");
    }
}
