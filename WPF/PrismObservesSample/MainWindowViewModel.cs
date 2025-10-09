using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismObservesSample{
    class MainWindowViewModel : BindableBase{
        private string _input1 = "";
        public string Input1 {
            get => _input1;
            set => SetProperty(ref _input1,value);　//処理の追加
        }

        private string _input2 = "";
        public string Input2 {
            get => _input2;
            set => SetProperty(ref _input2,value);　//処理の追加
        }

        private string _result = "";
        public string Result {
            get => _result;
            set => SetProperty(ref _result, value);　//処理の追加　
        }

        //コンストラクタ
        public MainWindowViewModel() {
            SumCommand = new DelegateCommand(ExcuteSum, canExecuteSum)
            .ObservesProperty(() => Input1)
            .ObservesProperty(() => Input2);
        }

        public DelegateCommand SumCommand { get; }

        //足し算の処理
        private void ExcuteSum() {
            var n1 = double.Parse(Input1);
            var n2 = double.Parse(Input2);

            Result = (n1 + n2).ToString();

        }
        //足し算処理を実行できるか否かチェック
        private bool canExecuteSum() {
            return (int.TryParse(Input1, out _) && (int.TryParse(Input2, out _))) ;
        }
    }
}
