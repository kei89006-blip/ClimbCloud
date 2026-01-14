using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce= 600.0f;
    float walkForce =300.0f;
    float maxWalkSpeed =2.0f;
    public Sprite[]walkSprites;
    public Sprite jumpSprite;
    float time =0;
    int idx =0;
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate =60;
        this.rigid2D =GetComponent<Rigidbody2D>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    } // Update is called once per frame

    void Update()
    {
       //ジャンプする
       if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            this.rigid2D.AddForce(transform.up*this.jumpForce);
        }

        //右へ移動
        if(this.rigid2D.linearVelocityX < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * walkForce);
        }

        //アニメーション
        if (this.rigid2D.linearVelocityY !=0)
        {
            this.spriteRenderer.sprite = this.jumpSprite;
        }
        else
        {
            this.time +=Time.deltaTime;
            if(this.time > 0.1f)
            {
                this.time =0;
                this.spriteRenderer.sprite =walkSprites [this.idx];
                this.idx =1- this.idx;
            }
        }       
    }

    //ゴールに到着
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ゴール");
    }
}
