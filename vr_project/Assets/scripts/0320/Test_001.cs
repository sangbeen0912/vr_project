using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ּ� ������ �����̽��� �ƴ϶�  TAP


        int age;                //������ int���� �̸���  age
        age = 20;               //age�� 30�� �Է�(=)�� �Է�
        Debug.Log(age);         //Console.log â�� age �� ���� �����ش�

        float height1 = 160.5f; //�ε��Ҽ��� float���� ���� �̸��� floart1�̰� 160.5f���� �����ش�
        float height2;          //float�� float2���� (�Է°��� ���� ����)
        height2 = height1;      //height1�� �ִ� height2�� �Է�
        Debug.Log(height2);     //Console.logâ�� height2�� ���� �����ش�

        string name;            //���ڿ� name����
        name = "Sera";          //name�� Sera �Է�
        Debug.Log(name);        //Console.logâ�� name�� ���� �����ش�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
