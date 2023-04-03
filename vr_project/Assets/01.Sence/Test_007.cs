using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{

    void sayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        sayHello();
        sayHello();
        CallName("TOM");
        CallName("Sam");
        int answer = Add(2, 5);
        Debug.Log(answer);
    }

    
}
