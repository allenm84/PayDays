using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PayDays
{
  static class Program
  {
    private const long TwoWeeksTicks = 12096000000000;
    private static readonly DateTime firstPayDay = DateTime.Parse("1/11/0001");

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static bool IsPayDay(this DateTime date)
    {
      long ticks = (date - firstPayDay).Ticks;
      return (ticks % TwoWeeksTicks) == 0;
    }
  }
}
