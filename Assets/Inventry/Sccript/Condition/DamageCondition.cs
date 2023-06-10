using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCondition:ICondition
{
    public bool Check(Evaluator evl)
    {
        return evl.Enemy.Count > 0;
    }
}

