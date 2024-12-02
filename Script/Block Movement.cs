using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockMovement : MonoBehaviour
{
    Rigidbody rb;
    bool isKeyDown , isLeftDown , isRightDown;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        isKeyDown = isLeftDown = isRightDown = false;
    }
    void Update()
    {
        var childCounter = transform.childCount;
        print(childCounter);
        if (childCounter == 0) {
            SceneManager.LoadScene("LoosePage");
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -2.27f || isLeftDown || Input.GetKey(KeyCode.LeftArrow))
        {
            isKeyDown = true;
            //touchLeftDown(isDown);
            var newPosition = transform.position;
            newPosition.x -= 0.05f;
            transform.position = newPosition;
        }
        else if (Input.GetKey(KeyCode.D)  && transform.position.x < 2.27f || isRightDown || Input.GetKey(KeyCode.RightArrow))
        {
            isKeyDown = true;
            var newPosition = transform.position;
            newPosition.x += 0.05f;
            transform.position = newPosition;
        }
        if (isKeyDown)
        {
            var pos = transform.position;
            pos.z += 5 * Time.deltaTime;
            transform.position = pos;
        }
    }
    public void OnClickReset() 
    {
        SceneManager.LoadScene("Level-" + PlayerPrefs.GetInt("Level"));
    }
    public void touchLeftDown(bool isDown)
    {
        isLeftDown = isDown;
    }
    public void touchRightDown(bool isDown)
    {
        isRightDown = isDown;
    }
}
