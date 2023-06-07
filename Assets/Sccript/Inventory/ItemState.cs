using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemState
{
    [SerializeField] int _itemID = -1;
    [SerializeField] Sprite _itemImage = default;
    int _itemCount = 0;
    [SerializeField, SerializeReference, SubclassSelector]
    IAbility _ability = default;

    public int ItemID { get => _itemID; }
    public Sprite ItemImage { get => _itemImage; }
    public int ItemCount { get => _itemCount; set => _itemCount = value; }
    public IAbility Ability { get => _ability; }
}
