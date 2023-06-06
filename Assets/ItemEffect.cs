using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemEffect
{
    [SerializeField, SerializeReference, SubclassSelector]
    List<IConditions> _condition = new List<IConditions>();

    [SerializeField, SerializeReference, SubclassSelector]
    IAbility _ability = null;

    
}
