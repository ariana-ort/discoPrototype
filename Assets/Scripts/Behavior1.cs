using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior1 : MonoBehaviour
{
    // Welcome to the first debugging module.
    // In this module, we will write a script which makes an object rotate in a sin-wave motion around another object.
    // But there are errors to be had here, which you will need to investigate.

    //made each variable public
    public float speed = 10f;
    public float amplitude = 0.05f;
    //created variable to reference in transform position 
    //now a float instead of a double, so all numbers are same datatype
    public float mathy = 0.75f;

    // When you are finished, leave a comment on each line of code describing what it does in plain English. This is the opposite instruction
    // to many of your PRE-Class Assignments, where a goal is described, and you recall the function to do it. Here, you will have the code, and you
    // will write your intuition about the purpose.

    void Start()
    {
    }

 
    void Update()
    {
        //make new position on vector
        Vector3 newPos = transform.position;
        //makes the lights/bubble move up and down like a sine wave
        newPos.y += Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = newPos;

        //keep obj rotating on horizontal plane but waving on vertical plane
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
