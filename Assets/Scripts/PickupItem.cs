using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupItem : MonoBehaviour
{
    public GameObject ItemOnPlayer;
    public GameObject Item;
    public GameObject ColliderBox;
    public HUD Hud;
    public TextMeshProUGUI messageText;
    public RectTransform HudPanelBox;

    void Start()
    {
        ItemOnPlayer.SetActive(false);
        messageText = FindObjectOfType<TextMeshProUGUI>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            if (Input.GetKey(KeyCode.E))
            {
                Item.SetActive(false);
                ItemOnPlayer.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Hud.OpenMessagePanel();
        messageText.text= "Press E to Pickup!";
        HudPanelBox.sizeDelta = new Vector2(1021f, HudPanelBox.sizeDelta.y);
    }
    private void OnTriggerExit(Collider other)
    {
        Hud.CloseMessagePanel();
        if (!Item.activeInHierarchy)
        {
            ColliderBox.SetActive(false);
        }
    }
}
