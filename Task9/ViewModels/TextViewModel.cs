using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Task9.Models;

namespace Task9.ViewModels
{
    internal class TextViewModel : INotifyPropertyChanged
    {
        private TextModel textModel;
        public TextModel TextModel
        {
            get { return textModel; }
            set 
            {
                textModel = value;
                OnPropertyChanged("TextModel");
            }
        }        
        private TextCommand splitTextCommand;
        public TextCommand SplitTextCommand
        {
            get            
            {
                return splitTextCommand ??
                    (splitTextCommand = new TextCommand(obj =>
                    {
                        textModel.SplitText();
                    }));
            }
        }
        private TextCommand reverseTextCommand;
        public TextCommand ReverseTextCommand
        {
            get
            {
                return reverseTextCommand ??
                    (reverseTextCommand = new TextCommand(obj =>
                    {
                        textModel.ReverseText();
                    }));
            }
        }
        public TextViewModel()
        {
            textModel = new TextModel("Hello world!");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
