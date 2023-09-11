using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    //void Start()
    //{
    //     
    //}

    void OnGUI()
    {        
        Rect posScale = new Rect(0, Screen.height - 30, 150, 30);
        if (GUI.Button(posScale, "Move SampleScene"))
        {
            //Debug.Log("버튼 클릭!!!");
            SceneManager.LoadScene("SampleScene");
        }        
    }
}
