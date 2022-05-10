using System;

namespace Observer
{
    public interface ISubject<T>
    {
        public void Subscribe(IObserver<Temperature> observer);

        public void Unsubscribe(IObserver<Temperature> observer);

    }
}