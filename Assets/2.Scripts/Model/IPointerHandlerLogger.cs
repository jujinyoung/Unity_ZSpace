////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (C) 2007-2020 zSpace, Inc.  All Rights Reserved.
//
////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.EventSystems;


    public class IPointerHandlerLogger : MonoBehaviour, IPointerClickHandler
    {

        public Vector3 model_pos;
        public Vector3 model_rot;
        Main_Scene_Controller msc;
        Panel_Controller pc;
        Model model;
        int model_num;
        string model_name,species,genus,family,order,_class,division,kingdom,model_info;
        public GameObject model_ui;

        public void OnPointerClick(PointerEventData eventData)
        {
            model_ui.SetActive(false);
            msc = GameObject.Find("Main_Scene_Controller").GetComponent<Main_Scene_Controller>();
            pc = GameObject.Find("ZCanvas").transform.GetChild(2).GetComponent<Panel_Controller>();
            model = gameObject.GetComponent<Model>();
            model_num = model.model_num;
            model_info = model.model_infor;
            model_name = model.model_name;
            species = model.species;
            genus = model.genus;
            family = model.family;
            order = model.order;
            _class = model._class;
            division = model.division;
            kingdom = model.kingdom;
            pc.SetData(model_name,model_info,species,genus,family,order,_class,division,kingdom);
            gameObject.AddComponent<zSpace.Core.Samples.Draggable>();
            
            msc.Click_Model(model_num);
            
            gameObject.GetComponent<IPointerHandlerLogger>().enabled = false;
            if(model_num == 5){
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
