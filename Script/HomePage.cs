using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomePage : MonoBehaviour
{
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void onClickStart() {
        SceneManager.LoadScene("LevelPage");
    }

}
