// Create original prototype documents
using PrototypeSample.Factories;
using PrototypeSample.Protypes.Contracts;
using PrototypeSample.Protypes.Implements;

IPrototype originalWordDoc = new WordDocument("This is a Word document content.", "John Doe");
IPrototype originalSpreadsheet = new Spreadsheet("Sales Data", "Jane Smith", "Q1: 1000, Q2: 2000, Q3: 1500");

// Create the document factory with prototypes
DocumentFactory documentFactory = new DocumentFactory(originalWordDoc, originalSpreadsheet);

// Display original and cloned documents
Console.WriteLine("Original Documents:");
((WordDocument)originalWordDoc).Display();
((Spreadsheet)originalSpreadsheet).Display();

// Clone the documents using the factory
IPrototype clonedWordDoc = documentFactory.CreateWordDocument();
IPrototype clonedSpreadsheet = documentFactory.CreateSpreadsheet();

Console.WriteLine("Cloned Documents:");
((WordDocument)clonedWordDoc).Display();
((Spreadsheet)clonedSpreadsheet).Display();

