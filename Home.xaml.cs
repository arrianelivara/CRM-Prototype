using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace CRMFinal
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.PieChart();
            this.Cartesian();
        }

        public void Cartesian()
        {

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Product 1"  , Values = new ChartValues<double>{100,600,500,500}
                },
                new LineSeries
                {
                    Title = "Product 2"  , Values = new ChartValues<double>{600,700,300,700},
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Product 3"  , Values = new ChartValues<double>{400,200,300,700},
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 20
                },
               

            };

            Labels = new[] { "August", "September", "October", "November" };
            yFormatter = value => value.ToString("C");

            SeriesCollection.Add(new LineSeries{

                Title = "Product",
                Values = new ChartValues<double> { 5,4,3},
                LineSmoothness = 0,
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Green

            });
                      
            SeriesCollection[3].Values.Add(5d);
            DataContext = this;

        }


        //Cartesian Chart
        public Func<double, string> yFormatter { get; set; }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set;}



        //PieChart
        public Func<ChartPoint,string> PointLabel { get; set; }

        public void PieChart()
        {

            PointLabel = ChartPoint => string.Format("{0}({1:P})", ChartPoint.Y, ChartPoint.Participation);
            DataContext = this;
        }
        private void PieChart_DataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;
            foreach (PieSeries pieSeries in chart.Series)
                pieSeries.PushOut = 0;
            var selectionSeries = (PieSeries)chartPoint.SeriesView;
            selectionSeries.PushOut = 0;

        }
    }

}
