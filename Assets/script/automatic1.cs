using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class automatic1 : MonoBehaviour, IPointerClickHandler
{
    public GameObject correct;
    public GameObject notcorrect;
    public Image ThisObject;
    public GameObject MouseDown;
    // Start is called before the first frame update
    void Start()
    {
        ThisObject=this.gameObject.GetComponent<Image>();
        correct=this.gameObject;
        notcorrect=this.gameObject;
        MouseDown=this.gameObject;
    }

    public void OnPointerClick (PointerEventData eventData)
    {
        if (this.gameObject.CompareTag("square"))
        {
            notcorrect.GetComponent<ImageChange2_S4>().ChangeImageX();
        }
        else if (this.gameObject.CompareTag("square2"))
        {
            correct.GetComponent<ImageChange>().Empty = ThisObject;
            correct.GetComponent<ImageChange>().ChangeImage();
        }
        MouseDown.GetComponent<OnMouseDown1_S4>().OnMouseDown();
    }
}
