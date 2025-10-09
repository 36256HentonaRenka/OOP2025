using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter{
    internal class MainWindowViewModel : BindableBase {

        //フィールド
        private double metricValue;
        private double imperialValue;

        //▲で呼ばれるコマンド
        public ICommand ImperialUnitToMetric { get; private set; }

        //▼で呼ばれるコマンド
        public ICommand MetoricToImperialunit { get; private set; }

        //上のCommboboxに選択
        public MetricUnit CurrentMetricUnit { get; set; }

        //下のCommboboxに選択
        public ImperialUnit CurrnetImperialUnit { get; set; }

        //プロパティ
        public double MetricValue {
            get => metricValue;
            set => SetProperty(ref metricValue, value);
        }

        public double ImprialValue {
            get => imperialValue;
            set => SetProperty(ref imperialValue, value);
        }

        public MainWindowViewModel() {
            /*CurrentMetricUnit = MetricUnit.Units.First();
            CurrnetImperialUnit = ImperialUnit.Units.First();

            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue = 
                   CurrentMetricUnit.FromImperialUnit(CurrnetImperialUnit, ImprialValue));

            MetoricToImperialunit = new DelegateCommand(
                () => ImprialValue =
                   CurrnetImperialUnit.FromMetricUnit(CurrentMetricUnit, MetricValue));*/

            ChangeCommand = new DelegateCommand(Changed, Canchanged)
                .ObservesProperty(() => MetricValue)
                .ObservesProperty(() => imperialValue);
        }

        public DelegateCommand ChangeCommand { get; }


        public void Changed() {
            CurrentMetricUnit = MetricUnit.Units.First();
            CurrnetImperialUnit = ImperialUnit.Units.First();

            ImperialUnitToMetric = new DelegateCommand(
                () => MetricValue =
                   CurrentMetricUnit.FromImperialUnit(CurrnetImperialUnit, ImprialValue));

            MetoricToImperialunit = new DelegateCommand(
                () => ImprialValue =
                   CurrnetImperialUnit.FromMetricUnit(CurrentMetricUnit, MetricValue));
        }

        public void Canchanged() {

        }
    }
}
