using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.MAUI.ViewModels {
    public class ChannelDonutViewModel {
        public ObservableCollection<TrafficChannel> TrafficChannelsData {
            get;
            set;
        }
        public Color[] TrafficColors {
            get;
            set;
        }
        public ChannelDonutViewModel() {
            TrafficChannelsData = new ObservableCollection<TrafficChannel>() {
                new TrafficChannel("Organic", 17000),
                new TrafficChannel("Direct", 6000),
                new TrafficChannel("Referral", 2500),
                new TrafficChannel("Social", 2000)
            };
            TrafficColors = new Color[] {
                Color.FromArgb("#84B9A0"),
                Color.FromArgb("#708EC8"),
                Color.FromArgb("#CF935B"),
                Color.FromArgb("#D671CC"),
            };
        }

    }
    public class TrafficChannel {
        public string ChannelName { get; }
        public double Value { get; }

        public TrafficChannel(string channelName, double value) {
            ChannelName = channelName;
            Value = value;
        }
    }
}
