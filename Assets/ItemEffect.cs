using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemEffect
{
    [SerializeField, SerializeReference, SubclassSelector]
    IAbility _ability = null;

}
