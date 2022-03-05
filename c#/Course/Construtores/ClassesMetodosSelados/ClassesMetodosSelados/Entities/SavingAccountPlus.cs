using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetodosSelados.Entities
{
    class SavingAccountPlus : SavingAccount
    {
        ///não vai deixar fazer sobreposição pois esse método está selado
        /*
        public override void Withdraw (double amount)
        {

        }
        */
    }
}
