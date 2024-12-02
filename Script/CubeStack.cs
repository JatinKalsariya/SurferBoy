using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeStack : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Playing Cube") {
            collision.transform.SetParent(transform.parent);
            collision.transform.AddComponent<CubeStack>();
            collision.transform.tag = "Player";
            collision.transform.position = transform.position;
            var childCounter = transform.parent.childCount;
            var y = childCounter;
            transform.position = new Vector3(transform.position.x,y,transform.position.z);
        }
        
    }
    private void OnTriggerEnter(Collider wall)
    {
        if (wall.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (wall.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("WinPage" , LoadSceneMode.Additive);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
