using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using test.Models;
using Xamarin.Forms;

namespace test.ViewModels
{
    public class WordCounterViewModel: INotifyPropertyChanged
    {
        private int _counter;
        private string _input;
        public event PropertyChangedEventHandler PropertyChanged;

        public WordCounterViewModel()
        {
            Counter = 0;
            SetCounter = new Command(LunchSetCounter);
        }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        public string Input
        {
            get { return _input; }
            set
            {
                _input = value;
                OnPropertyChanged(nameof(Input));
            }
        }

        private void LunchSetCounter()
        {
            Counter = WordCounter.WordsCounter(Input);
        }


        public ICommand SetCounter { get; private set; }

    }
}
