using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange2 : MonoBehaviour
{
    public Image Empty; //�����ϴ� �����
    public Sprite InCorrect; //Ʋ���� �� ��Ÿ���� ���� ���� �׸�
    public Sprite NotPicture; //�ƴ� �� ���ٰ� �����ϴ� ���� �׸�(Ʋ���� �ƴ�)
    public Sprite Return; //�ٽ� �� ��������
    public GameObject tmp;

    
    public void ChangeImageX()  //�׸��� �ƴ� �׸� ����
    {
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        

        if (GameObject.Find("Obutton").GetComponent<BtnActive>().BtnO == 1) //ObuttonȰ��ȭ�϶�
        {
            Empty.sprite = InCorrect; //Ʋ�� ������ �̹��� �ٲٱ�
            GameObject.Find("HeartCanvas").GetComponent<Heart>().life--;
        }
        else
        {
            if(Empty.sprite != InCorrect) //Ʋ���� ���� ��
            {
                if(Empty.sprite == NotPicture) //�ٽ� ���ư���
                {
                    if(GameObject.Find("Square").GetComponent<Autoo>().finish == 1)
                    {
                        Empty.sprite = NotPicture;
                    }
                    else
                    {
                        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
                        Empty.sprite = Return;
                    }
                    
                }
                else //���� ǥ���ϱ�
                {
                    Empty.sprite = NotPicture;
                }
            }
            
        }

        
    }
}
