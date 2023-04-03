using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //주석 공간은 스페이스가 아니라  TAP


        int age;                //정수형 int선언 이름은  age
        age = 20;               //age에 30을 입력(=)은 입력
        Debug.Log(age);         //Console.log 창에 age 의 값을 보여준다

        float height1 = 160.5f; //부동소수형 float선언 선언 이름은 floart1이고 160.5f값을 보여준다
        float height2;          //float형 float2선언 (입력값은 따로 없음)
        height2 = height1;      //height1에 있는 height2에 입력
        Debug.Log(height2);     //Console.log창에 height2의 값을 보여준다

        string name;            //문자열 name선언
        name = "Sera";          //name에 Sera 입력
        Debug.Log(name);        //Console.log창에 name의 값을 보여준다
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
