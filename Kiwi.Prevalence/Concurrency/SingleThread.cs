using System;

namespace Kiwi.Prevalence.Concurrency
{
    public class SingleThread : ISynchronization
    {
        private readonly object _sync = new object();

        public T Read<T>(Func<T> action)
        {
            lock(_sync)
            {
                return action();
            }
        }

        public T Write<T>(Func<T> action)
        {
            lock (_sync)
            {
                return action();
            }
        }
    }
}