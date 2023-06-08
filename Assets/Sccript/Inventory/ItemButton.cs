using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour, IPointerClickHandler
{
    ItemState _myItem;
    public ItemState MyItem { get => _myItem; set => _myItem = value; }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_myItem.Ability != null)
        {
            _myItem.Ability.Use();
            Inventory.Instance.ItemCountDown(_myItem.ItemID);
        }
    }
    private void Awake()
    {
        _myItem = new ItemState(-1, default, 0, null);
    }
    void Update()
    {
        GetComponent<Image>().sprite = _myItem.ItemImage;
        GetComponentInChildren<Text>().text = _myItem.ItemCount.ToString();
    }
}
