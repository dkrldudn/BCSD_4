using UnityEngine;
using UnityEngine.InputSystem;

public class LifeCycle : MonoBehaviour
{
    /*void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Onable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    void Update()
    {
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }*/

    /*void Update()
    {
        if(Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }
        /*
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입했습니다.");
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 이동 중");
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        }*/

    /*if(Input.GetMouseButtonDown(0))
    {
        Debug.Log("미사일 발사!");
    }
    if(Input.GetMouseButton(0))
    {
        Debug.Log("미사일 모으는 중..");
    }
    if(Input.GetMouseButtonUp(0))
    {
        Debug.Log("슈퍼 미사일 발사!");
    }*/

    /*if(Input.GetButtonDown("Jump"))
    {
        Debug.Log("점프!");
    }
    if(Input.GetButton("Jump"))
    {
        Debug.Log("점프 모으는 중..");
    }
    if(Input.GetButtonUp("Jump"))
    {
        Debug.Log("슈퍼 점프!");
    }*/

    /*if(Input.GetButton("Horizontal"))
    {
        Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
    }

    if(Input.GetButton("Vertical"))
    {
        Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
    }
}*/

    /*void Start()
    {
        Vector2 vec = new Vector2(5, 0);
        transform.Translate(vec);
    }*/

    void Update()
    {
        Vector2 vec = new Vector2(Input.GetAxis("Horizontal")*Time.deltaTime, Input.GetAxis("Vertical")*Time.deltaTime);
        transform.Translate(vec);
    }
}