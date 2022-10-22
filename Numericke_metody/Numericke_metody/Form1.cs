using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Numericke_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = -10;
            chart1.ChartAreas[0].AxisX.Maximum = 10;
            chart1.ChartAreas[0].AxisY.Minimum = -2000;
            chart1.ChartAreas[0].AxisY.Maximum = 2000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            double y = 0;
            a = Convert.ToInt32(richTextBoxA.Text);
            b = Convert.ToInt32(richTextBoxB.Text);
            c = Convert.ToInt32(richTextBoxC.Text);
            d = Convert.ToInt32(richTextBoxD.Text);

            for(int i = -10; i <= 10; i++)
            {
                y = a * Math.Pow(i, 3) + b * Math.Pow(i, 2) + c * i + d;
                chart1.Series["Graf"].Points.AddXY(i, y);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < chart1.Series.Count; i++)
            {
                xlWorkSheet.Cells[1, 1] = "X";
                xlWorkSheet.Cells[1, 2] = "Y";
                xlWorkSheet.Cells[2, 2] = "Graf";
                for (int j = 0; j < chart1.Series[i].Points.Count; j++)
                {
                    xlWorkSheet.Cells[j + 3, 1] = chart1.Series["Graf"].Points[j].XValue;
                    xlWorkSheet.Cells[j + 3, 2] = chart1.Series["Graf"].Points[j].YValues[0];
                }
            }

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            //Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(120, 80, 500, 300);
            Excel.Chart chartPage = myChart.Chart;

            
            chartRange = xlWorkSheet.get_Range("A2", "B21");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlLine;

            xlWorkBook.SaveAs("graf.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\graf.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
