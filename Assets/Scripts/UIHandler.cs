using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public HUD Hud;
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
    private void OnTriggerEnter(Collider other)
    {
        Hud.OpenMessagePanel();
        messageText.text = "Press E to Open Chest!";
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
