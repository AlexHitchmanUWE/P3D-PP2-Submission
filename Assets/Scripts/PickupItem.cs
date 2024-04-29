using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameObject ItemOnPlayer;
    public GameObject Item;
    public GameObject ColliderBox;
    public HUD Hud;
    public TMP_Text messageText;
  
    void Start()
    {
        ItemOnPlayer.SetActive(false);
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
        messageText.SetText("Press E to Pickup!");
    }
    private void OnTriggerExit(Collider other)
    {
        Hud.CloseMessagePanel();
        ColliderBox.SetActive(false);
    }
}
