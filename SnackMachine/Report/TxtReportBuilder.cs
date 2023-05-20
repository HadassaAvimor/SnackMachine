using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Report;

internal class TxtReportBuilder : ReportBuilder
{
    string todaysDate = DateTime.Now.Date.ToString();
    //למצוא דרך לשרשר את התאריך הנוכחי לשם הקובץ
    const string PATH = "../../../../../Report.txt";
    public TxtReportBuilder()
    {
        report = "----------- Action Description -----------\n";
        report += $"Date: {todaysDate}";
    }

    public override void AddEntry(string actionDescription)
    {
        report += $"{actionDescription}\n";
    }

    public override string GetReport()
    {
        string createText = "Hello and Welcome" + Environment.NewLine;
        File.WriteAllText(PATH, createText);
        // האם צריך לכתוב באמת לקובץ טקסט?
        return report;
    }
}

