using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropItem : MonoBehaviour
{
    public GameObject ItemOnPlayer1;
    public GameObject ItemOnPlayer2;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject KeyItem;
    public GameObject ColliderBox;
    public GameObject KeyCollider;
    public HUD Hud;
    public RectTransform HudPanelBox;
    public TextMeshProUGUI messageText;
   

    private bool keyItemTimerStarted = false;

    void Start()
    {
        if (Hud == null)
        {
            Debug.LogError("HUD reference not set in DropItem script!");
            messageText = FindObjectOfType<TextMeshProUGUI>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ItemOnPlayer1 != null && ItemOnPlayer2 != null && (ItemOnPlayer1.activeInHierarchy && ItemOnPlayer2.activeInHierarchy))
            {
                if (Input.GetKey(KeyCode.Alpha1))
                {
                    Item1.SetActive(true);
                    ItemOnPlayer1.SetActive(false);
                }
                if (Input.GetKey(KeyCode.Alpha2))
                {
                    Item2.SetActive(true);
                    ItemOnPlayer2.SetActive(false);
                }
                if (Item1.activeInHierarchy && Item2.activeInHierarchy && !keyItemTimerStarted)
                {
                    StartCoroutine(ActivateKeyItemAfterDelay());
                }
            }
        }
    }

    private IEnumerator ActivateKeyItemAfterDelay()
    {
        keyItemTimerStarted = true;
        yield return new WaitForSeconds(1f); // Wait for 1 second
        KeyItem.SetActive(true);
        Item1.SetActive(false);
        Item2.SetActive(false);
        ColliderBox.SetActive(false);
        KeyCollider.SetActive(true);
        keyItemTimerStarted = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (ItemOnPlayer1 != null && ItemOnPlayer2 != null && (ItemOnPlayer1.activeInHierarchy || ItemOnPlayer2.activeInHierarchy))
        {
            Hud.OpenMessagePanel();
            messageText.text = "Press 1 or 2 to drop your items!";
            HudPanelBox.sizeDelta = new Vector2(1700f, HudPanelBox.sizeDelta.y);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Hud.CloseMessagePanel();
        if (ItemOnPlayer1 == null || ItemOnPlayer2 == null || (!ItemOnPlayer1.activeInHierarchy && !ItemOnPlayer2.activeInHierarchy))
        {
            ColliderBox.SetActive(false);
        }
    }
}
