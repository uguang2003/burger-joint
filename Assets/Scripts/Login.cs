using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public InputField rUseranem;
    public InputField rPassword;
    public InputField rRPassword;

    public InputField tttext;

    public Text ttext;

    public Toggle isAudio;
    public Slider changeAudio;

    public GameObject rPanel;   
    public GameObject settingPanel;

    string user = "admin";
    string pass = "admin";

    AudioSource au;


    public void OpenRPlane()
    { 
       rPanel.SetActive(true);
    }

    public void CloseRPlane()
    {
        rUseranem.text = "";
        rPassword.text = "";
        rRPassword.text = "";
        rPanel.SetActive(false);
    }

    public void OpenSettingPlane()
    {
        settingPanel.SetActive(true);
    }

    public void CloseSettingPlane()
    {
        settingPanel.SetActive(false);
    }

    public void Register()
    {
        user = rUseranem.text;
        pass = rPassword.text;
        if (rPassword.text == rRPassword.text)
        {
            rPanel.SetActive(false);
        }
        else
        {
            rPassword.text = "";
            rRPassword.text = "";
            pass = "";
        }
        rUseranem.text = "";
        rPassword.text = "";
        rRPassword.text = "";
    }

    public void LoginButton()
    {
        if (username.text == user && password.text == pass && tttext.text == ttext.text)
        {
            Debug.Log("登录成功");
        }
        else
        {
            Debug.Log("登录失败");
        }
        username.text = "";
        password.text = "";
    }

    void Start()
    {
        ChangeText();
        au = GetComponent<AudioSource>();
    }

    void Update()
    {
        au.mute = isAudio.isOn;
        au.volume = changeAudio.value;
    }

    public void ChangeText()
    {
        //随机生成4位验证码
        string code = "";
        for (int i = 0; i < 4; i++)
        {
            code += Random.Range(0, 10);
        }
        ttext.text = code;
    }

}
