using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obutton : MonoBehaviour
{
    public Image Active; //Ȱ��ȭ �׸�
    public Sprite InActive; //��Ȱ��ȭ �׸�
    public Sprite ReActive; //�ٽ� Ȱ��ȭ �׸�

    private void Update()
    {
        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1)
        {
            Active.sprite = ReActive; //�̹��� �ٲٱ�
            
        }
        else
        {
            Active.sprite = InActive; //�̹��� �ٲٱ�
            
        }
    }

    
}
