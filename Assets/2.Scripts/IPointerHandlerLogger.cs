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

        public CameraMove cameraMove;
        public GameObject ObjectPanel;
        public GameObject cameraPos;

        public void OnPointerClick(PointerEventData eventData)
        {
            ObjectPanel.SetActive(true);

            Vector3 campos = new Vector3(gameObject.transform.position.x + 1.0f,1.0f,gameObject.transform.position.z + -1.0f);

            cameraPos.transform.position = campos;

            cameraMove.MovingCamera(cameraPos);
            
        }
    }
}
