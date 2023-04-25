using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.MAUI.ViewModels {
    public class PageviewsAreaChartViewModel {
        public ObservableCollection<DateCountValue> PageviewStats { get; set; }
        public PageviewsAreaChartViewModel() {
            PageviewStats = new ObservableCollection<DateCountValue>();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) {
                PageviewStats.Add(new DateCountValue(DateTime.Now.AddMonths(-i), rnd.Next(3000, 6000)));
            }
        }
    }

    public class DateCountValue {
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public DateCountValue(DateTime date, int count) {
            Date = date;
            Count = count;
        }
    }
}
