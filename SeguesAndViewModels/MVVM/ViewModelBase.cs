using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace SeguesAndViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify<TProperty>(Expression<Func<TProperty>> property)
        {
            var propertyName = Reflection.GetPropertyName(property);
            if (String.IsNullOrEmpty(propertyName))
                throw new MissingMemberException("Could not resolve property name from expression. May need PreserveAttribute.");
            Notify(propertyName);
        }

        protected void Notify(params string[] propertyNames)
        {
            if (PropertyChanged != null)
                foreach(var propertyName in propertyNames)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ViewModelBase<T> : ViewModelBase, IFollow<T>
	{
		T _predecessor;
		public T Predecessor {
			get { return _predecessor; }
			set { _predecessor = value; PredecessorChanged(); }
		}

		public virtual void PredecessorChanged() {}
	}
}
