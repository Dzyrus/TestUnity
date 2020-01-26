using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    //Init rotation speed
    public float rotSpeed = 360;

    private GameObject colorCube;

    //Create a cube to store original color
    private void Awake()
    {
        colorCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        colorCube.active = false;
    }


    //Stop obj on mouseDown and save original color
    private void OnMouseDown()
    {
        colorCube.GetComponent<Renderer>().material.color = gameObject.GetComponent<Renderer>().material.color;
        gameObject.GetComponent<Renderer>().material.color = Color.black;
        this.rotSpeed = 0;
    }

    //Reset obj speed on mouseUp and restore original color
    private void OnMouseUp()
    {
        gameObject.GetComponent<Renderer>().material.color = colorCube.GetComponent<Renderer>().material.color;
        this.rotSpeed = 360;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, this.rotSpeed * Time.deltaTime);
    }
}
    