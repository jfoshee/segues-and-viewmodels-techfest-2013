using System;
using System.ComponentModel;

namespace SeguesAndViewModels
{
    public class InitialViewModel : ViewModelBase
	{
		string _title;
		public string Title {
			get { return _title; }
            set { _title = value; Notify(() => Title); }
		}

        float _value1;
		public float Value1 {
            get { return _value1; }
            set { _value1 = value; Notify(() => Value1); }
        }

        float _value2;
        public float Value2 {
            get { return _value2; }
            set { _value2 = value; Notify(() => Value2); }
        }

		public InitialViewModel()
		{
			_title = "Hello, World!";
		}
	}
}
