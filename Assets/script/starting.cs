using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starting : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip tick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Story");
            audioSource.PlayOneShot(tick);

        }
    }
}
