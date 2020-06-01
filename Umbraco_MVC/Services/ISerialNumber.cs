using System.Collections.Generic;

namespace Umbraco_MVC.Services
{
    public interface ISerialNumber
    {
        bool ValidedSerialsNumber(int number);
        List<int> GetSerialsNumbers();
    }
    public interface IAge
    {
        bool IsValid(object value);
        string FormatErrorMessage(string name);
    }

    public interface IEntries
    {

    }
    public interface IDrawing
    {

    }
}
