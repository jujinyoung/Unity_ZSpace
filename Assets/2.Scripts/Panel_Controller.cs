using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Controller : MonoBehaviour
{
    public GameObject[] panels;

    public GameObject left_arrow,right_arrow;

    public Text title,content,species,genus,family,order,_class,division,kingdom;
    
    int panel_num = 0;

    public AudioSource audioSource;
    
    public void Left_btn(){
        audioSource.Play();
        panel_num = 0;
        right_arrow.SetActive(true);
        left_arrow.SetActive(false);
        Show(panel_num);
    }

    public void Right_btn(){
        audioSource.Play();
        panel_num = 1;
        left_arrow.SetActive(true);
        right_arrow.SetActive(false);
        Show(panel_num);
        
    }

    private void Show(int num){
        foreach(GameObject panel in panels){
            panel.SetActive(false);
        }
        panels[num].SetActive(true);
    }

    public void SetData(string title, string content, string species, string genus, 
    string family, string order, string _class, string division, string kingdom)
    {
        this.title.text = title + " 은(는) " + species + "에 속한다.";
        this.content.text = content.Replace("\\n","\n");
        this.species.text = species;
        this.genus.text = genus;
        this.family.text = family;
        this.order.text = order;
        this._class.text = _class;
        this.division.text = division;
        this.kingdom.text = kingdom;
    }
}
