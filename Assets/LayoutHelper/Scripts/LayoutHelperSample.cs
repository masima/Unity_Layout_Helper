using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UI.LayoutHelper;

public class LayoutHelperSample : MonoBehaviour
{
    public GameObject BaseImage;

    private LayoutHelper m_layoutHelper;





    // Start is called before the first frame update
    void Start()
    {
        m_layoutHelper = GetComponent<LayoutHelper>();
        m_layoutHelper.InstantiateContent(BaseImage);
        m_layoutHelper.InstantiateContent(m_layoutHelper.LabelButton);
        m_layoutHelper.InstantiateContent(m_layoutHelper.Text);
        {
            HorizontalLayoutGroup layoutGroup = m_layoutHelper.InstantiateHorizontalLayout();
            Transform parent = layoutGroup.transform;
            m_layoutHelper.InstantiateContent(m_layoutHelper.LabelButton, parent);
            m_layoutHelper.InstantiateHolizontalFlexibleSpace(parent: parent);
            m_layoutHelper.InstantiateContent(m_layoutHelper.LabelButton, parent);
        }
        {
            HorizontalLayoutGroup layoutGroup = m_layoutHelper.InstantiateHorizontalLayout();
            Transform parent = layoutGroup.transform;
            m_layoutHelper.InstantiateContent(m_layoutHelper.ToggleLeft, parent);
            m_layoutHelper.InstantiateContent(m_layoutHelper.ToggleRight, parent);
            m_layoutHelper.InstantiateHolizontalFlexibleSpace(parent: parent);
            m_layoutHelper.InstantiateContent(m_layoutHelper.LabelButton, parent);
        }
        m_layoutHelper.InstantiateContent(m_layoutHelper.VerticalScrollView);
        m_layoutHelper.InstantiateContent(m_layoutHelper.HorizontalScrollView);

    }


}
