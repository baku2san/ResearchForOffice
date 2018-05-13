﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectionOfWordCells.Common
{
    using System.ComponentModel;

    /// <summary> 
    /// ViewModelの基本クラス。INotifyPropertyChangedの実装を提供します。 
    /// </summary> 
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary> 
        /// プロパティの変更があったときに発行されます。 
        /// </summary> 
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary> 
        /// PropertyChangedイベントを発行します。 
        /// </summary> 
        /// <param name="propertyName">プロパティ名</param> 
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
