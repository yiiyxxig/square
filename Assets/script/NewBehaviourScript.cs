using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {

        pos = this.gameObject.transform.position;

        Debug.Log($"{this.gameObject.name}{pos}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
