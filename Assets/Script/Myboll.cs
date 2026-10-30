using UnityEngine;

public class Myboll : MonoBehaviour
{
    Rigidbody2D rigid;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.linearVelocity = Vector2.forward; 속력 바꾸기
        //rigid.linearVelocity = new Vector2(2, 4);
        // 힘을 가하기
        if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector2.up*5, ForceMode2D.Impulse);
            Debug.Log(rigid.linearVelocity);
        }
        Vector2 vec = new Vector2(Input.GetAxisRaw("Horizontal"), 0);

        rigid.AddForce(vec, ForceMode2D.Impulse);

        //회전력
        //rigid.AddTorque(-1f);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.name == "Square3")
        {
            rigid.AddForce(Vector2.up*2, ForceMode2D.Impulse);
        }
    }
}
