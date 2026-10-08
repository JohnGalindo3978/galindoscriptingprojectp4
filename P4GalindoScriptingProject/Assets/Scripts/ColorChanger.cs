using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0f); // Orange
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0f, 0.5f); // Purple
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f); // Brown
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f); // Gray
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Renderer>().material.color = new Color(0f, 0.5f, 0.5f); // Teal
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0f, 0f); // Maroon
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0f); // Olive
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Renderer>().material.color = new Color(0f, 0f, 0.5f); // Navy
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 1f); // Light Blue
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.5f); // Light Red
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 0.5f); // Light Green
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 1f, 0.5f); // Light Yellow
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 1f); // Light Magenta
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 1f); // Light Cyan
        }
    }
}
