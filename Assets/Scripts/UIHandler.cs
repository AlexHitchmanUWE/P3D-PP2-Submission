using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public GameObject ChestHud;
    public TextMeshProUGUI messageText;
    public RectTransform HudPanelBox;
    public GameObject Item;
    public GameObject ColliderBox;
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
        ChestHud.SetActive(true);
        if (Item.activeInHierarchy)
        {
            ChestHud.SetActive(false);
            ColliderBox.SetActive(false);
        }
    }
   
}
