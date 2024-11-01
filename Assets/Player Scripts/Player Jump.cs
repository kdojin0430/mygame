using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    Transform pos;
    [SerializeField]
    float checkRadius;
    [SerializeField]
    LayerMask islayer;
    bool isGround;
    public float jumpPower;
    Rigidbody2D rigid;
    Animator anim;
    // Start is called before the first frame update

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(pos.position, checkRadius,islayer);

        if (isGround == true && Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }
        
    }
    void FixedUpdate()
    {
        if(rigid.velocity.y < 0)
        {
            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position,Vector3.down,1);
            if (rayHit.collider != null) 
            {
                if (rayHit.distance < 2.0f)
                    anim.SetBool("isJumping", false);
            }

        }   
    }
}
