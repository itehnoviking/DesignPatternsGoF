﻿namespace Iterator.Interfaces;

public interface IEnumerator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}