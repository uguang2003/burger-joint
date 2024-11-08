using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class PlotText : MonoBehaviour
{
    public float speedTime = 0.15f;//���ּ��ʱ��

    float timer;//��ʱ��ʱ��
    Text TextCompnt;//Text�������
    int wordNumber;//��������
    int nNumber;//��һ�п�ʼ��λ��
    bool isStart;//�Ƿ�ʼ����

    string wordContent;//----��������

    void Awake()
    {
        TextCompnt = this.GetComponent<Text>();//�ӵ�ǰ�����ȡ��Text���
        isStart = true;//boolֵ��Ĭ��ֵ��false  ��������Ҫ����Ϊtrue
        wordContent = "����һ��û��Ҫ�ĺ��ӣ�ֱ����һ�죬\n��Ե���һ���������Ӵ�չ������Ĺ���";
    }

    void FixedUpdate()
    {
        StartTyping();
    }
    void StartTyping()
    {
        if (isStart)
        {
            timer += Time.deltaTime;//�򵥵ļ�ʱ��
            if (timer >= speedTime)//�����ʱ��ʱ��>���ּ��ʱ��
            {
                timer = 0;//����
                wordNumber++;//��������+1

                //Substring() �ٷ��ĵ����ͣ��Ӵ�ʵ���������ַ����� ���ַ�����ָ�����ַ�λ�ÿ�ʼ�Ҿ���ָ���ĳ��ȡ�
                TextCompnt.text = wordContent.Substring((nNumber), wordNumber - nNumber);//������������ʼ�ַ�λ�ã����㿪ʼ��
                if (wordNumber >= wordContent.Length)//��������=���ֵĳ���
                {
                    isStart = false;//ֹͣ����
                }
                else if (wordContent.Substring((wordNumber), 1) == "\n")
                {
                    nNumber = wordNumber + 1;
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
