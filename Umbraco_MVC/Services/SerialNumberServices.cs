using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Umbraco_MVC.Data;

namespace Umbraco_MVC.Services
{
    public class SerialNumberServices
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
    }
}
