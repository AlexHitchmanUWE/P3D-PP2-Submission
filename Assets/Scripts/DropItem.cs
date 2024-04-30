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
    public GameObject HudGameObject;
    public GameObject SkeletonEyes;
   

    private bool keyItemTimerStarted = false;

    void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ItemOnPlayer1 != null && ItemOnPlayer2 != null)
            {
                if (ItemOnPlayer1.activeInHierarchy || ItemOnPlayer2.activeInHierarchy)
                {
                    HudGameObject.SetActive(true);
                }
                if (Input.GetKey(KeyCode.Alpha1))
                {
                    if (ItemOnPlayer1.activeInHierarchy)
                    {
                        Item1.SetActive(true);
                        ItemOnPlayer1.SetActive(false);
                    }
                }
                if (Input.GetKey(KeyCode.Alpha2))
                {
                    if (ItemOnPlayer2.activeInHierarchy)
                    {
                        Item2.SetActive(true);
                        ItemOnPlayer2.SetActive(false);
                    }
                }
                if (Item1.activeInHierarchy && Item2.activeInHierarchy && !keyItemTimerStarted)
                {
                    SkeletonEyes.SetActive(true);
                    StartCoroutine(ActivateKeyItemAfterDelay());
                }
            }
        }
    }

    private IEnumerator ActivateKeyItemAfterDelay()
    {
        keyItemTimerStarted = true;
        yield return new WaitForSeconds(3f); // Wait for 1 second
        KeyItem.SetActive(true);
        Item1.SetActive(false);
        Item2.SetActive(false);
        KeyCollider.SetActive(true);
        HudGameObject.SetActive(false);
        keyItemTimerStarted = false;
    }
    private void OnTriggerExit(Collider other)
    {
        HudGameObject.SetActive(false);
    }
}
