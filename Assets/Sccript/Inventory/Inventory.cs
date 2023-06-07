using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : InstanceSystem<Inventory>
{
    [SerializeField] GameObject _inventory;
    ItemState[] _myItems;
    int _itemSlotCount;

    public ItemState[] MyItems { get => _myItems; set => _myItems = value; }
    public int ItemSlotCount { get => _itemSlotCount; }

    private void Awake()
    {
        _itemSlotCount = _inventory.transform.childCount;
        _myItems = Enumerable.Repeat(new ItemState(), ItemSlotCount).ToArray();
        SetItem();
        //_inventory.SetActive(false);
    }

    public void SetItem()
    {
        for(int i = 0; i < _itemSlotCount; i++)
        {
            var viewItemParent = _inventory.transform.GetChild(i);
            var viewItem = viewItemParent.transform.GetChild(0).GetComponent<ItemButton>();
            if (_myItems[i].ItemID != -1)
            {
                viewItem.MyItem = _myItems[i];
            }
        }
    }
}
