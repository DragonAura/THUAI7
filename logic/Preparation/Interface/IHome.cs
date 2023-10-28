﻿using Preparation.Utility;

namespace Preparation.Interface
{
    public interface IHome
    {
        public AtomicLong TeamID { get; }
        public LongWithVariableRange HP { get; }
        public long Score { get; }
        public void AddScore(long add);
    }
}