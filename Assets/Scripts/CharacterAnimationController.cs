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
            animator.SetBool("test", true);
            Debug.Log("working");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetBool("test", false);
            Debug.Log("working");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("3");
            Debug.Log("working");
        }
    }
}
