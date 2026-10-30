using UnityEngine;
using UnityEngine.UIElements;

public class OtherBall : MonoBehaviour
{
    SpriteRenderer sprite;
    Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        mat = sprite.material;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Circle2S")
        {
            mat.color = new Color(0, 0, 0);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Circle2")
        {
            sprite.color = Color.black;
            Debug.Log("Circle2와 충돌하여 색상이 변경되었습니다.");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Circle2")
        {
            sprite.color = new Color(1, 1, 1);
        }
    }
}
