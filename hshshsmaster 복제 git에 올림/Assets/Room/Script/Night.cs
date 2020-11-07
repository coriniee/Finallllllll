using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    public GameObject NightPanel;
    private bool isNight = false;
    private float timer;

    //문, 침대, 컴퓨터 체크... 해제
    Collider2D[] cArray = new Collider2D[4];
    public GameObject[] gArray = new GameObject[4];

    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        if (Random.Range(1, 3) == 1)
        {
            isNight = true;
            Debug.Log("눈송늦잠엔딩[5]");
            for(int i =0; i<4; i++)
            {
                cArray[i] = gArray[i].GetComponent<Collider2D>();
            }
            
        }
        NightPanel.SetActive(isNight);
        for (int i = 0; i < 4; i++)
        {
            cArray[i].enabled = !isNight;
        }
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (isNight && timer > 7)
        {
            //포탈 사용 X
            Debug.Log("늦잠자서 지각엔딩... ㅎㅎ...");
            EndArray.setEndingArray(5, true);
        }
    }
}
