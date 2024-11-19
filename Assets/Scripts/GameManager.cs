using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static WaitForSeconds waitForMOneSecond = new WaitForSeconds(0.1f);

    public GameObject PlayerPerfab;

    public Vector3 PlayerV3;

    public static GameManager instance { get; private set; }

    public bool LoadedPlayerv3 = false;

    //��ѡ�����Ʒ����Ϣ
    public int SelectItemNum;
    public string SelectItemName;
    public string SelectItemInfo;

    //public Item ItemSelected;

    public GameObject MuseumGroup;

    public GameObject LookItemGroup;

    private void Start()
    {
        Cursor.visible = false;
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //ǰ�����ӽ���
    public void LookItem()
    {
        LookItemGroup.SetActive(true);
        MuseumGroup.SetActive(false);
        ItemUI.instance.RefreshItemInfo();
    }

    //�����������
    public void ToMuseum()
    {
        LookItemGroup.SetActive(false);
        MuseumGroup.SetActive(true);
    }
}
