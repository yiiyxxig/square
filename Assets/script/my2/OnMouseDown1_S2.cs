using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnMouseDown1_S2 : MonoBehaviour
{
    public GameObject GameObject1;
    void Start()
    {
        GameObject1 = GameObject.Find("Select");

    }
    public void OnMouseDown()
    {
        GameObject1.GetComponent<MoveControlS2>().IsSelect = 0;
    }
}
