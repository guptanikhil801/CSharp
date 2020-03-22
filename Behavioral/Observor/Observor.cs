using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Behavioral.Observor
{
    interface Observor
    {
        public void PriceNotification();
        public void OfferNotification();
    }
}
