using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task9.Models
{
    internal class TextModel : INotifyPropertyChanged
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("Text");
            }
        }
        private List<string> words;
        public List<string> Words
        {
            get { return words; }
            set
            {
                words = value;
                OnPropertyChanged("Words");
            }
        }
        private string reversedText;
        public string ReversedText
        {
            get { return reversedText; }
            set
            {
                reversedText = value;
                OnPropertyChanged("ReversedText");
            }
        }
        public void SplitText()
        {
            Words = Text.Trim().Split(' ').ToList();            
        }
        public void ReverseText()
        {            
            SplitText();
            List<string> buf = Words;
            buf.Reverse();
            ReversedText = string.Join(" ", buf);
        }
        public TextModel(string text)
        {
            Text = text;
            SplitText();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
