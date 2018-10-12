using System;

namespace DesignPatterns.Patterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject sub)
        {
            subject = sub;
        }

        public void Update()
        {
            string subjectState = subject.GetState();
            Console.WriteLine(subjectState);
        }
    }
}
