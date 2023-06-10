using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RecoveryCondition : ICondition
{
    public bool Check(Evaluator evl)
    {
        return evl.Player;
    }
}
