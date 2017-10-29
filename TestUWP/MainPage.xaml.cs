using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const string FanSpeed0 = "FanSpeed0";
        const string FanSpeed1 = "FanSpeed1";
        const string FanSpeed2 = "FanSpeed2";
        const string FanSpeed3 = "FanSpeed3";
        const string FanSpeed4 = "FanSpeed4";

        class PropertyIdValue
        {
            public string Id { get; set; }
            public double Value { get; set; }
        }

        private static readonly List<PropertyIdValue> fanSpeeds = new List<PropertyIdValue>()
        {
            new PropertyIdValue { Id=FanSpeed0, Value=0 },
            new PropertyIdValue { Id=FanSpeed1, Value=1 },
            new PropertyIdValue { Id=FanSpeed2, Value=2 },
            new PropertyIdValue { Id=FanSpeed3, Value=3 },
            new PropertyIdValue { Id=FanSpeed4, Value=4 },
        };

        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            string fanSpeedId = FanSpeed0;
            double fanSpeed = PropertyIdToValue(fanSpeeds, fanSpeedId);
        }

        private double PropertyIdToValue(List<PropertyIdValue> propertyList, string propertyId)
        {
            PropertyIdValue item = propertyList.Find(x => x.Id == propertyId);
            double value = item.Value;
            return value;
        }
    }
}
