using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior2 : MonoBehaviour
{
    public float rotateSpeed = 100f;
    public GameObject rotateAroundObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.RotateAround(rotateAroundObject.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);


        Debug.DrawLine(this.transform.position, rotateAroundObject.transform.position, Color.cyan);  // This line is fine
    }
}
