using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal interface IBancarOp
    {
        void Deposit(double suma);
        void WithDrawal(double suma);

    }
}