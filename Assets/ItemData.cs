using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

[CreateAssetMenu(fileName = "DataBase", menuName = "ItemData")]
public class ItemData : ScriptableObject
{
    [SerializeField] int _id;
    [SerializeField]
    List<ItemEffect> _effect = new List<ItemEffect>();
}
