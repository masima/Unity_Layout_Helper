using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UI.LayoutHelper;
using UI.LayoutHelper.Parts;

public class LayoutHelperSample : MonoBehaviour
{
    public GameObject BaseImage;

    private LayoutHelper m_layoutHelper;





    // Start is called before the first frame update
    void Start()
    {
        m_layoutHelper = GetComponent<LayoutHelper>();
        m_layoutHelper.InstantiateContent(BaseImage);
        m_layoutHelper.InstantiateContent<LabelButton>(m_layoutHelper.LabelButton)
            .Setup("Button1", onClick: () => Debug.Log("Button1 clicked"));
        m_layoutHelper.InstantiateContent<LabelText>(m_layoutHelper.Text)
            .Label = "Something message.\nSomething message.";
        {
            HorizontalLayoutGroup layoutGroup = m_layoutHelper.InstantiateHorizontalLayout();
            Transform parent = layoutGroup.transform;
            m_layoutHelper.InstantiateContent<LabelButton>(m_layoutHelper.LabelButton, parent)
                .Setup("Button2", onClick: () => Debug.Log("Button2 clicked"));
            m_layoutHelper.InstantiateHolizontalFlexibleSpace(parent: parent);
            m_layoutHelper.InstantiateContent<LabelButton>(m_layoutHelper.LabelButton, parent)
                .Setup("Button3", onClick: () => Debug.Log("Button3 clicked"));
        }
        {
            HorizontalLayoutGroup layoutGroup = m_layoutHelper.InstantiateHorizontalLayout();
            Transform parent = layoutGroup.transform;
            m_layoutHelper.InstantiateContent<ToggleElement>(m_layoutHelper.ToggleLeft, parent)
                .Setup("Left", isOn: true, value => Debug.Log($"Left:{value}"));
            m_layoutHelper.InstantiateContent<ToggleElement>(m_layoutHelper.ToggleRight, parent)
                .Setup("Right", isOn: false, value => Debug.Log($"Right:{value}"));
            m_layoutHelper.InstantiateHolizontalFlexibleSpace(parent: parent);
            m_layoutHelper.InstantiateContent<LabelButton>(m_layoutHelper.LabelButton, parent)
                .Setup("Button4", onClick: () => Debug.Log("Button4 clicked"));
        }
        m_layoutHelper.InstantiateContent(m_layoutHelper.VerticalScrollView);
        m_layoutHelper.InstantiateContent(m_layoutHelper.HorizontalScrollView);

    }


}
