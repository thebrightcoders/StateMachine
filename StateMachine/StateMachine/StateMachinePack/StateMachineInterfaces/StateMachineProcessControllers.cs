using System;

namespace StateMachinePack.StateMachineInterfaces
{
    public interface StateMachineProcessControllers
    {
        void Start();
        void Proceed();
        void Stop();
        void Pause();
        void Continue();
        void Wait(TimeSpan waitTime);
    }
}