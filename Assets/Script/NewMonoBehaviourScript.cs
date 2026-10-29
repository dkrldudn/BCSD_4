using UnityEngine;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    string title = "전설의";
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;
    int health = 30;
    int exp = 1500;
    int mana = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity!");

        //변수
        /*int level =5;
        float strength = 15.5f;
        string playerName = "나검사";
        bool isFullLevel = false;*/
        /*
        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel); */

        //그룹형 변수
        /*string[] monsters = {"슬라임", "사막뱀", "악마"};
        int[] monsterLevels = new int[3];
        monsterLevels[0] = 1;
        monsterLevels[1] = 6;
        monsterLevels[2] = 20;*/

        /*Debug.Log("멥에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);*/

        /*List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");*/

        /*
        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);*/

        //연산자
        //int exp = 1500;

        /*exp = 1500+320;
        exp = exp - 10;
        level = exp/300;
        strength = level*3.1f;

        Debug.Log("용사의 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp%300);
        Debug.Log("다음 레벨까지 필요한 경험치는?");
        Debug.Log(nextExp);

        //string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = (level == fullLevel);
        Debug.Log("용사는 만렙인가?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼을 끝냈는가?" + isEndTutorial);

        //int health = 30;
        //int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁜가?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태는?" + condition);

        //키워드
        //int float string bool new List

        //조건문
        if(condition == "나쁨")
        {
            Debug.Log("용사는 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        if(isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용했습니다.");
        }
        else if(isBadCondition && items[1] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나물약30을 사용했습니다.");
        }

        string monsterAlarm;
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                monsterAlarm = "소형 몬스터가 출현!";
                break;
            case "악마":
                monsterAlarm = "중형 몬스터가 출현!";
                break;
            case "골렘":
                monsterAlarm = "대형 몬스터가 출현!";
                break;
            default:
                monsterAlarm = "??? 몬스터가 출현!";
                break;
        }
        Debug.Log(monsterAlarm);

        //반복문
        while (health > 0)
        {
            health--;
            if(health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
            {
                Debug.Log("사망했습니다.");
            }
            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for(int count =0; count<10; count++)
        {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }
        for(int index=0; index<monsters.Length; index++)
        {
            //Debug.Log("이 지역에 있는 몬스터: " + monsters[index]);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터: " + monster);
        }

        Heal();

        for (int index=0; index<monsters.Length; index++)
        {
            //Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevels[index]));
        }*/

        //클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.weapon = "나무 지팡이";
        player.strength = 2.4f;
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");
        Debug.Log(player.move());
    }

    //함수(메소드)
    /*void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if(level >= monsterLevel)
        {
            result = "승리";
        }
        else
        {
            result = "패배";
        }
        return result;
    }*/
}
