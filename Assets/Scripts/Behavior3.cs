using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Behavior3 : MonoBehaviour
{
    public Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Start Triggered");
            animator.SetTrigger("Start");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Stop Triggered");
            animator.SetTrigger("Stop");
        }


        Debug.DrawRay(transform.position, transform.forward, Color.blue);  // This line is fine
        Debug.DrawRay(transform.position, transform.right, Color.red); // This line is fine
        Debug.DrawRay(transform.position, transform.up, Color.green); // This line is fine
    }
}
