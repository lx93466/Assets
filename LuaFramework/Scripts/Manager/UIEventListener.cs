using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public enum UIEventType
{
    onClick,
    onClickUp,
    onClickDown,
    onBeginDrag,
    onDrag,
    onEndDrag,
    onDrop,
    onScroll
}
public class UIEventParam
{
    public Transform target = null;
    public Vector2 clickedPosition = Vector2.zero;
}
public class UIEventListener : MonoBehaviour,
                            IPointerClickHandler,
                            IPointerDownHandler,
                            IPointerUpHandler,
                            IDropHandler,
                            IBeginDragHandler,
                            IDragHandler,
                            IEndDragHandler
{
    public UnityAction<UIEventParam> onClick = null;

    public UnityAction<UIEventParam> onClickUp = null;

    public UnityAction<UIEventParam> onClickDown = null;

    public UnityAction<UIEventParam> onBeginDrag = null;

    public UnityAction<UIEventParam> onDrag = null;

    public UnityAction<UIEventParam> onEndDrag = null;

    public UnityAction<UIEventParam> onDrop = null;

    public UnityAction<Vector2> onScroll = null;

    private UIEventParam uiEventParam = new UIEventParam();
    void start()
    {
        if (onScroll != null)
        {
            ScrollRect scrollRect = transform.GetComponent<ScrollRect>();

            UnityAction<Vector2> action = new UnityAction<Vector2>(this.onScroll);
            scrollRect.onValueChanged.AddListener(action);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (onClick != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onClick(uiEventParam);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (onClickDown != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onClickDown(uiEventParam);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
         
        if (onClickUp != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onClickUp(uiEventParam);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (onDrag != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onBeginDrag(uiEventParam);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (onDrag != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onDrag(uiEventParam);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (onEndDrag != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onEndDrag(uiEventParam);
        }
    }
    /// <summary>
    /// 当使用OnDrop事件时，为了使被拖动对象A能够掉落到接受Drop事件的对象B身上，
    /// B必须优于A渲染，即：B对象位于A对象下边。
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrop(PointerEventData eventData)
    {
        if (onDrop != null)
        {
            uiEventParam.target = transform;
            uiEventParam.clickedPosition = eventData.position;
            onDrop(uiEventParam);
        }
    }

    public void OnScroll(Vector2 v2)
    {
        if (onScroll != null)
        {
            onScroll(v2);
        }
    }
}