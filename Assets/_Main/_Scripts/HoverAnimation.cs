using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverAnimation : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    Vector3 initialPos;
    private void Awake()
    {
        initialPos = transform.localPosition;
    }
    public void OnToggleValueChanged(bool value)
    {
        if (value)
        {
            iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(initialPos.x, initialPos.y +25f,initialPos.z), "time", .5f, "islocal", true, "easetype", iTween.EaseType.easeInOutSine));
        }
        else
        {
            iTween.MoveTo(gameObject, iTween.Hash("position", new Vector3(initialPos.x, initialPos.y,initialPos.z), "time", .5f, "islocal", true, "easetype", iTween.EaseType.easeInOutSine));
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnToggleValueChanged(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnToggleValueChanged(false);

    }
}
