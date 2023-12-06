﻿namespace OOP.L2;
public interface IObservable
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void NotifyObservers(Movie newMovie);
}
