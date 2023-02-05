using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Homework10.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        /// <summary>
        /// Проверка можно ли выолнить команду
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public abstract bool CanExecute(object parameter);
        /// <summary>
        /// То что выполняет команда
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void Execute(object parameter);
    }
}
