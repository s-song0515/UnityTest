using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{

    void OnGUI()
    {
        Rect posScale = new Rect(Screen.width-150 ,0 , 150, 30);
        if (GUI.Button(posScale, "Move TestScene"))
        {
            //Debug.Log("��ư Ŭ��!!!");
            SceneManager.LoadScene("TestScene");
        }
    }
}
