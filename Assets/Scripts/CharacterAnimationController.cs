using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            animator.SetTrigger("pickup");
            Debug.Log("working");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("take");
            Debug.Log("working");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("pickobject");
            Debug.Log("working");
        }
    }
}
