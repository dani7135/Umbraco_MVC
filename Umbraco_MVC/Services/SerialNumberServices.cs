using System;
using System.Collections.Generic;
using System.IO;

namespace Umbraco_MVC.Services
{
    public class SerialNumberServices : ISerialNumber
    {//Her skal validationen af tingene ligge

        readonly string textFile = @".\serialNumbers.txt";

        public List<int> GetSerialsNumbers()
        {
            List<int> validSerialsNumbers = new List<int>();
            if (File.Exists(textFile))
            {
                using (StreamReader file = new StreamReader(textFile))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        validSerialsNumbers.Add(Convert.ToInt32(ln));
                    }
                    file.Close();
                }
            }
            return validSerialsNumbers;

        }

        public bool ValidedSerialsNumber(int number)
        {
            List<int> listOfNumber = GetSerialsNumbers();
            foreach (var item in listOfNumber)
            {
                if (number == item)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
