using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Image Empty; //�����ϴ� �����
    public Sprite Picture; //�׸���� �׸�
    public Sprite NotPicture; //�ƴ� �� ���ٰ� �����ϴ� ���� �׸�(Ʋ���� �ƴ�)
    public Sprite Return; //�ٽ� �� ��������
    
    public void start()
    {
        Empty=this.gameObject.GetComponent<Image>();
    }


    public void ChangeImage() //�׸��� �´� �׸� ����
    {
        
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        


        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1) //ObuttonȰ��ȭ�϶�
        {
            Empty.sprite = Picture; //���� ���� �̹���
            gameObject.tag = "square3";
        }
        else
        {
            if(Empty.sprite != Picture) //�׸��� ���߱� ��
            {
                if (Empty.sprite == NotPicture) //�ٽ� ���ư���
                {
                    gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                    Empty.sprite = Return;
                }
                else
                {
                    Empty.sprite = NotPicture; //���� ǥ���ϱ�
                }
            }
        }


    }     
}
