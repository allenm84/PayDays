using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayDays
{
  public partial class MainForm : Form
  {
    private readonly BindingList<DateItem> dateItemBindingList;

    public MainForm()
    {
      InitializeComponent();
      MinimumSize = Size;

      dateItemBindingList = new BindingList<DateItem>();
      gridPayDays.DataSource = dateItemBindingList;
    }

    private void AddDate(DateTime date)
    {
      dateItemBindingList.Add(new DateItem
      {
        Text = date.ToShortDateString(),
      });
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      LoadPayDays(DateTime.Today, new Progress<DateTime>(AddDate));
    }

    private async void LoadPayDays(DateTime date, IProgress<DateTime> progress)
    {
      Enabled = false;
      Cursor = Cursors.AppStarting;

      await Task.Run(() =>
      {
        DateTime firstPayDay = new DateTime(date.Year, 1, 1);
        while (!firstPayDay.IsPayDay())
        {
          firstPayDay = firstPayDay.AddDays(1.0);
        }

        DateTime end = new DateTime(date.Year + 1, 1, 1);
        for (DateTime i = firstPayDay; i < end; i = i.AddDays(14))
        {
          progress.Report(i);
        }
      });

      Enabled = true;
      Cursor = Cursors.Default;
      dateItemBindingList.ResetBindings();
    }

    private void gridPayDays_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      var text = (string)e.Value;
      DateTime date = DateTime.Parse(text);
      if (dateItemBindingList.Count(di => DateTime.Parse(di.Text).Month == date.Month) == 3)
      {
        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
      }

      if (date < DateTime.Today)
      {
        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
      }

      if (date == DateTime.Today)
      {
        e.CellStyle.ForeColor = Color.Red;
      }
    }
  }
}
