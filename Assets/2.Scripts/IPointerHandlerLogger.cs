////////////////////////////////////////////////////////////////////////////////
//
//  Copyright (C) 2007-2020 zSpace, Inc.  All Rights Reserved.
//
////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.EventSystems;

namespace zSpace.Core.Samples
{

    public class IPointerHandlerLogger : MonoBehaviour, IPointerClickHandler
    {

        public GameObject ObjectPanel;

        public void OnPointerClick(PointerEventData eventData)
        {
            ObjectPanel.SetActive(true);


            SceneMove.instance.LoadTest();
        }
    }
}
