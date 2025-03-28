using PrototypeSample.Protypes.Contracts;

namespace PrototypeSample.Factories;

public class DocumentFactory
{
	#region Field
	private readonly IPrototype _wordPrototype;
    private readonly IPrototype _spreadsheetPrototype;
    #endregion

    public DocumentFactory(IPrototype wordPrototype, IPrototype spreadsheetPrototype)
    {
        _wordPrototype = wordPrototype;
        _spreadsheetPrototype = spreadsheetPrototype;
    }

    public IPrototype CreateWordDocument()
    {
        return _wordPrototype.Clone();
    }

    public IPrototype CreateSpreadsheet()
    {
        return _spreadsheetPrototype.Clone();
    }
}
