using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConfigManager;

namespace ParameterViewGenerator.Test.ViewModels
{
    public class ParameterViewModel : Screen
    {
        private ParamData _uiParamData = IoC.Get<ParamData>();

        public ParamData UiParamData
        {
            get => _uiParamData;
            set
            {
                if (_uiParamData != value)
                {
                    _uiParamData = value;
                    NotifyOfPropertyChange();
                }
            }
        }
    }
}
