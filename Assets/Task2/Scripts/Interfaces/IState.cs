﻿namespace Task2.Interfaces
{
    public interface IState
    {
        public void Enter();
        public void Exit();
        public void Update();
    }
}