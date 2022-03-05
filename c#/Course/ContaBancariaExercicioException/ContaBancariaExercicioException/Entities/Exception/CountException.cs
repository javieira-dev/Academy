using System;

namespace ContaBancariaExercicioException.Entities.Exception
{
    class CountException : ApplicationException 
    {
        public CountException(string message) : base(message)
        {
        }
    }
}
