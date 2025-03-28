using PrototypeSample.Protypes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrototypeSample.Protypes.Implements;

public class Spreadsheet : IPrototype
{
    #region Field
    private readonly string _title;
    private readonly string _author;
    private readonly string _data;
    #endregion

    public Spreadsheet(string title, string author, string data)
    {
        _title = title;
        _author = author;
        _data = data;
    }

    public IPrototype Clone()
    {

        return new Spreadsheet(_title, _author, _data);
    }

    public void Display()
    {
        Console.WriteLine($"Spreadsheet - Title: {_title}, Author: {_author}");
        Console.WriteLine($"Data: {_data}\n");
    }
}
