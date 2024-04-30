using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestUIHandler : MonoBehaviour
{
    public GameObject ChestHud;
    public GameObject Item;
    public GameObject ItemOnPlayer;
    public GameObject ColliderBox;
    public GameObject ExitHud;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (ItemOnPlayer.activeInHierarchy)
        {
            ChestHud.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                ExitHud.SetActive(true);
            }
        }
        if (Item.activeInHierarchy)
        {
            ChestHud.SetActive(false);
            ColliderBox.SetActive(false);
        }
    }
   
}
