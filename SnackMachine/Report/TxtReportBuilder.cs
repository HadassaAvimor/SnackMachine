using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Report;

internal class TxtReportBuilder : ReportBuilder
{
    public TxtReportBuilder()
    {
        report = "----------- Action Description -----------\n";
        report += $"Date: {DateTime.Now}";
    }

    public override void AddEntry(string actionDescription)
    {
        report += $"{actionDescription}\n";
    }

    public override string GetReport()
    {
        // האם צריך לכתוב באמת לקובץ טקסט?
        return report;
    }
}

