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
    public HUD Hud;
    public TextMeshProUGUI messageText;
    public RectTransform HudPanelBox;

    // Start is called before the first frame update
    void Start()
    {
        messageText = FindObjectOfType<TextMeshProUGUI>();
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
    private void OnTriggerEnter(Collider other)
    {
        Hud.OpenMessagePanel();
        messageText.text = "Press E to Open Chest!";
        HudPanelBox.sizeDelta = new Vector2(1221f, HudPanelBox.sizeDelta.y);

    }
    private void OnTriggerExit(Collider other)
    {
        Hud.CloseMessagePanel();
        if (Item.activeInHierarchy)
        {
            ColliderBox.SetActive(false);
        }
    }
}
