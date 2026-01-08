using UnityEngine;
using unityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidboby2D rigid2D;
    float jumpForce= 600.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate =60;
        this.rigid2D =GetComponent<Rigidbody2D>();
    } // Update is called once per frame
    void Update()
    {
       //ジャンプする
       if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rigid2D.AddForce(transform.up*this.jumpForce);
        }
        
    }
}
