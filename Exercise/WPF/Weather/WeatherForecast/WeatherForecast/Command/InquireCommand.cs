using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherForecast.Command
{
    public class InquireCommand : ICommand
    {
        public InquireCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc)
        {
            this.ExecuteAction = executeAction;
            this.CanExecuteFunc = canExecuteFunc;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null) return false;
           return CanExecuteFunc.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            if (ExecuteAction == null) return;
            ExecuteAction.Invoke(parameter);
        }

        public Action<object> ExecuteAction { get; set; }

        public Func<object,bool> CanExecuteFunc { get; set; }

    }
}
