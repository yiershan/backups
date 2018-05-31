﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subject {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer) {
            _observers.Add(observer);
        }

        public void Detach(Observer observer) {
            _observers.Remove(observer);
        }

        public void Notify() {
            foreach (var observer in _observers) {
                observer.Update();
            }
        }
    }
}
