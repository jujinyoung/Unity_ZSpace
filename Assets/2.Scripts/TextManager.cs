using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    
    public Text[] Black_Text;
    public Right_Answer right_answer;


    public void Select()
    {
        if(!right_answer.check_answer){
            this.GetComponent<Text>().color = new Color(1, 0, 0);
            foreach (Text B in Black_Text)
            {
                B.color= new Color(0.196f, 0.196f, 0.196f);
            }
        }
    }

    public void Red_Color_For_5Quiz()
    {
        this.GetComponent<Text>().color = new Color(1, 0, 0);
    }

    public void Initialize(){
        this.GetComponent<Text>().color = new Color(0.196f, 0.196f, 0.196f);
        foreach (Text B in Black_Text)
        {
            B.color= new Color(0.196f, 0.196f, 0.196f);
        }
    }

}
