using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [Range(0,100)]
    public int num1;
    public int num2;
    public string action;
    int i=1;
    int health=1;
    void WelcomePlayer(){
        health += 1;
        print("Hello Player=" + health);
    }

    string[] names=new string[]{"bob","tom","noa"};

    // Start is called before the first frame update
    void Start()
    {
        
        if(action=="add"){
                        print(num1+num2);

        }else if(action=="subtract"){
                        print(num1-num2);

        }else if(action=="multiply"){
                        print(num1*num2);

        }else if(action=="divide"){
                        print(num1/num2);
        }else{
            print("The action does not exists");
        }

        while(i<=100){
            if(i%5==0 && i%3==0){
                print(i);
            }
            i+=1;
        }
    print(names[1]);
        
        // WelcomePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            WelcomePlayer();
        }
    }
}
