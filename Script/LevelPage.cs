using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPage : MonoBehaviour
{
    public GameObject ButtonPrefab;
    public GameObject Grid;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject gameObject = Instantiate(ButtonPrefab, Grid.transform);
            Button button = gameObject.GetComponent<Button>();
            Text txt = button.GetComponentInChildren<Text>();
            txt.text = (i + 1).ToString();
            int level = i;
            button.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("Level", level+1);
                SceneManager.LoadScene("Level-" + (level + 1));

            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
