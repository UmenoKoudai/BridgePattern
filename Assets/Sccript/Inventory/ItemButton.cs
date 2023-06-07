using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditorInternal.Profiling.Memory.Experimental;

public class ItemButton : MonoBehaviour, IPointerClickHandler
{
    ItemState _myItem;
    public ItemState MyItem { get => _myItem; set => _myItem = value; }

    public void OnPointerClick(PointerEventData eventData)
    {
        _myItem.Ability.Use();
    }
    private void Awake()
    {
        _myItem = new ItemState();
    }
    void Update()
    {
        if (_myItem.ItemID != -1)
        {
            GetComponent<Image>().sprite = _myItem.ItemImage;
            GetComponentInChildren<Text>().text = _myItem.ItemCount.ToString();
        }
    }
}
