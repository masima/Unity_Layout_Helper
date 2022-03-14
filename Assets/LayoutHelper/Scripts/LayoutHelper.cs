using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UI.LayoutHelper
{
    public class LayoutHelper : MonoBehaviour
    {
        public RectTransform Content;


        public GameObject LabelButton;
        public GameObject Text;
        public GameObject HorizontalScrollView;
        public GameObject VerticalScrollView;
        public GameObject ToggleLeft;
        public GameObject ToggleRight;



        static System.Type[] s_horizontalLayoutTypes = new[] { typeof(HorizontalLayoutGroup) };
        static System.Type[] s_verticalLayoutTypes = new[] { typeof(HorizontalLayoutGroup) };
        static System.Type[] s_layoutElementTypes = new[] { typeof(LayoutElement) };

        // Start is called before the first frame update
        void Start()
        {

        }


        private Transform GetParent(Transform parent)
		{
            if (null == parent)
            {
                parent = Content;
            }
            return parent;
        }
        private void SetParent(Transform transform, Transform parent)
		{
            transform.SetParent(GetParent(parent), worldPositionStays: false);
        }


        public GameObject InstantiateContent(GameObject prefab, Transform parent = null)
		{
            GameObject newGameObject = Instantiate(prefab, GetParent(parent));
            return newGameObject;
		}
        public T InstantiateContent<T>(GameObject prefab, Transform parent = null)
            where T : Component
        {
            GameObject newGameObject = Instantiate(prefab, GetParent(parent));
            return newGameObject.GetComponent<T>();
        }


        public HorizontalLayoutGroup InstantiateHorizontalLayout(
            bool childForceExpandWidth = false
            , float spacing = 8
            , Transform parent = null
            )
        {
            var layoutGroup = new GameObject("HorizontalLayoutGroup", s_horizontalLayoutTypes)
                .GetComponent<HorizontalLayoutGroup>();
            layoutGroup.childControlWidth = true;
            layoutGroup.childControlHeight = true;
            layoutGroup.childForceExpandWidth = childForceExpandWidth;
            layoutGroup.childForceExpandHeight = false;
            layoutGroup.spacing = spacing;
            layoutGroup.childAlignment = TextAnchor.MiddleCenter;
            SetParent(layoutGroup.transform, parent);
            return layoutGroup;
        }

        public VerticalLayoutGroup InstantiateVerticalLayout(
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
            layoutGroup.childForceExpandHeight = false;
            layoutGroup.spacing = spacing;
            SetParent(layoutGroup.transform, parent);
            return layoutGroup;
        }

        public LayoutElement InstantiateHolizontalFlexibleSpace(
            float flexibleWidth = 10000
            , Transform parent = null
            )
        {
            var layoutElement = new GameObject("FlexibleSpace", s_layoutElementTypes)
                .GetComponent<LayoutElement>();
            layoutElement.flexibleWidth = flexibleWidth;
            SetParent(layoutElement.transform, parent);
            return layoutElement;
        }

        public LayoutElement InstantiateVerticalFlexibleSpace(
            float flexibleHeight = 10000
            , Transform parent = null
            )
        {
            var layoutElement = new GameObject("FlexibleSpace", s_layoutElementTypes)
                .GetComponent<LayoutElement>();
            layoutElement.flexibleHeight = flexibleHeight;
            SetParent(layoutElement.transform, parent);
            return layoutElement;
        }
    }

}
