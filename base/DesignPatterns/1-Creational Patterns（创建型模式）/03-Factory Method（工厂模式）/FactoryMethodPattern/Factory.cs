using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Factory
    {
        public abstract Product CreateProduct();
    }
}
