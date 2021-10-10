using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGA
{
    public static class CsvHelper
    {
        public static List<CsvData> ReadCsv(string filepath)
        {
            var list = new List<CsvData>();

            using (var parser = new TextFieldParser(filepath, Encoding.UTF8))
            {
                parser.Delimiters = new string[] { "," };

                parser.HasFieldsEnclosedInQuotes = true;
                var headerRecord = true;
                var headers = new List<string>();
                while (!parser.EndOfData)
                {

                    var values = parser.ReadFields();
                    if (headerRecord)
                    {
                        headers = values.ToList();
                        headerRecord = false;
                    }
                    else
                    {
                        var csvdata = new CsvData();
                        var idx = 0;
                        foreach (var h in headers)
                        {
                            if (h == nameof(CsvData.col1))
                            {
                                csvdata.col1 = values[idx];
                            }
                            if (h == nameof(CsvData.col2))
                            {
                                csvdata.col2 = values[idx];
                            }
                            if (h == nameof(CsvData.col3))
                            {
                                csvdata.col3 = values[idx];
                            }
                            idx++;
                        }
                        list.Add(csvdata);

                    }

                }
            }

            return list;


        }

    }


}
