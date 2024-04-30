using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChestBehaviour : MonoBehaviour
{
    public Animator animator;
    public GameObject Coins;
    public GameObject ItemOnPlayer;
    public GameObject Item;
    public GameObject ColliderBox;


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
            if (other.tag == "Player")
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Item.SetActive(true);
                    ItemOnPlayer.SetActive(false);
                    animator.SetTrigger("open");
                    Coins.SetActive(true);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Item.activeInHierarchy)
        {
            ColliderBox.SetActive(false);
        }
    }
}
