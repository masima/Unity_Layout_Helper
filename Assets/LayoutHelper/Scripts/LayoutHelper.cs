using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutHelper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static System.Type[] s_horizontalLayoutTypes = new[] { typeof(HorizontalLayoutGroup) };
    static System.Type[] s_verticalLayoutTypes = new[] { typeof(HorizontalLayoutGroup) };
    static System.Type[] s_layoutElementTypes = new[] { typeof(LayoutElement) };

    public HorizontalLayoutGroup CreateHorizontalLayout(
        bool childForceExpandWidth = false
        , float spacing = 0
        , Transform parent = null
        )
	{
        var layoutGroup = new GameObject("HorizontalLayoutGroup", s_horizontalLayoutTypes)
            .GetComponent<HorizontalLayoutGroup>();
        layoutGroup.childControlWidth = true;
        layoutGroup.childControlHeight = true;
        layoutGroup.childForceExpandWidth = childForceExpandWidth;
        layoutGroup.spacing = spacing;

        if (null != parent)
		{
            layoutGroup.transform.SetParent(parent);
		}
        return layoutGroup;
    }

    public VerticalLayoutGroup CreateVerticalLayout(
        bool childForceExpandWidth = true
        , float spacing = 0
        , Transform parent = null
        )
    {
        var layoutGroup = new GameObject("VerticalLayoutGroup", s_verticalLayoutTypes)
            .GetComponent<VerticalLayoutGroup>();
        layoutGroup.childControlWidth = true;
        layoutGroup.childControlHeight = true;
        layoutGroup.childForceExpandWidth = childForceExpandWidth;
        layoutGroup.spacing = spacing;

        if (null != parent)
        {
            layoutGroup.transform.SetParent(parent);
        }
        return layoutGroup;
    }

    public LayoutElement CreateHolizontalFlexibleSpace(
        float flexibleWidth = 10000
        , Transform parent = null
        )
    {
        var layoutElement = new GameObject("FlexibleSpace", s_layoutElementTypes)
            .GetComponent<LayoutElement>();
        layoutElement.flexibleWidth = flexibleWidth;

        if (null != parent)
		{
            layoutElement.transform.SetParent(parent);
		}
        return layoutElement;
	}

    public LayoutElement CreateVerticalFlexibleSpace(
        float flexibleHeight = 10000
        , Transform parent = null
        )
    {
        var layoutElement = new GameObject("FlexibleSpace", s_layoutElementTypes)
            .GetComponent<LayoutElement>();
        layoutElement.flexibleHeight = flexibleHeight;

        if (null != parent)
        {
            layoutElement.transform.SetParent(parent);
        }
        return layoutElement;
    }
}
