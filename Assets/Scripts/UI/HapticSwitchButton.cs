/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticSwitchButton : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    private SpriteRenderer spriteRender;

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        if(spriteRender == null)
        {
            spriteRender.sprite = sprite1;
        }
    }

    public void Change()
    {
        if(spriteRender.sprite == sprite1)
        {
            spriteRender.sprite = sprite2;
        }
        else
        {
            spriteRender.sprite = sprite1;
        }
    }

} */

using UnityEngine.EventSystems;
using UnityEngine;

public class HapticSwitchButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click completed");
    }
}