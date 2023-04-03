using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "happy";      //string형 str1선언 후 happy 값 입력
        string str2 = "birthday";   //string형 str2선언 후 birthday 값 입력
        string message;             //string형 message 선언

        message = str1 + str2;      //message에 str1,str2문자열을 더함
        Debug.Log(message);         //console.log창에 message 출력

        str1 += str2;               //str1+str2의 축약
        Debug.Log(str1);            //console.log창에 str1 출력

        int num = 123;              //int형 num선언후 123 입력
        message = str1 + num;       //message에 string형 str1과 int형 num을 더해서 입력
        Debug.Log(message);         //console.log창에 message 출력
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
