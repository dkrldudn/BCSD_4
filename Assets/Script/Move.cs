using UnityEngine;

public class Move : MonoBehaviour
{
    Vector2 target = new Vector2(8, 1.5f);
    void Update()
    {
        //MoveTowards
        //transform.position = Vector2.MoveTowards(transform.position, target, 1f);

        //SmoothDamp
        //Vector2 velo = Vector2.zero;

        //transform.position = Vector2.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //Lerp (선형 보간)
        //transform.position = Vector2.Lerp(transform.position, target, 0.1f);

        //SLerp (구면 선형 보간)
        //transform.position = Vector2.Slerp(transform.position, target, 0.05f);
    }
}
