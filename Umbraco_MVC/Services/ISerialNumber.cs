using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
