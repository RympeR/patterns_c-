using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver.weather
{
    public interface Subject
    {
            void registerObserver(Observer o);
            void removeObserver(Observer o);
            void notifyObservers();
    }
}
