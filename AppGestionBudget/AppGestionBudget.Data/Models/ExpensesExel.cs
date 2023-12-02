using Microsoft.Office.Interop.Excel;
using Exel = Microsoft.Office.Interop.Excel;
using AppGestionBudget.Enum;

namespace AppGestionBudget.Data.Models;
public class ExpensesExel {
    string path = "";
    _Application exel = new Exel.Application();
    Workbook wb;
    Worksheet ws;
    public ExpensesExel(string path, int Sheet) {
        
        this.path = path;
        wb = exel.Workbooks.Open(path);
        ws = wb.Worksheets[Sheet];
       
    }
    public int Sum(int j) {

        if (ws.Cells[1][j].Value2 != null) { 
            var t = ws.Cells[1][j].Value2;
            int rep = (int)t;
            return rep;
        }
        else { return 0; }
    }
    public string label(int j)
    {

        if (ws.Cells[2][j].Value2 != null)
        {
            var t = ws.Cells[2][j].Value2;
            return t;
        }
        else { return ""; }
    }
    public Category category(int j)
    {
        if (ws.Cells[3][j].Value2 != null) {
            var t = ws.Cells[3][j].Value2;
            switch (t){
                case "Loisir":
                    return Category.Loisir;
                case "Auto":
                    return Category.Auto;
                case "Alimentation":
                    return Category.Alimentation;
                case "Informatique":
                    return Category.Informatique;
            }
        } 
        return 0;
    }
    public string date(int j)
    {
        if (ws.Cells[4][j].Value != null)
        {
            var t = ws.Cells[4][j].Value;
            var g = $"{t.Year}-{t.Month}-{t.Day}";
            // t.Year t.Month
            return g;
        }
        else { return ""; }
    }
    public string user(int j){
        if (ws.Cells[5][j].Value2 != null)
        {
            string t = ws.Cells[5][j].Value2;
            return t;
        }
        else { return ""; }
    }

    public void close() { wb.Close(); }

    public int nbligne() { return ws.UsedRange.Count / 5; }
}
