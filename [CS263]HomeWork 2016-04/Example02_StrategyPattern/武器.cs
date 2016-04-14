using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02_StrategyPattern
{
    public abstract class 武器 : 攻擊招式介面
    {
        public abstract void 攻擊();
    }
}