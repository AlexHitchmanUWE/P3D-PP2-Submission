using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupItem : MonoBehaviour
{
    public GameObject ItemOnPlayer;
    public GameObject Item;
    public GameObject ColliderBox;
    public GameObject HudGameObject;

    void Start()
    {
        ItemOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && !ItemOnPlayer.activeInHierarchy)
        {
            HudGameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Item.SetActive(false);
                ItemOnPlayer.SetActive(true);
                HudGameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        HudGameObject.SetActive(false);
        if(ItemOnPlayer.activeInHierarchy)
        {
            ColliderBox.SetActive(false);
        }
    }
}
