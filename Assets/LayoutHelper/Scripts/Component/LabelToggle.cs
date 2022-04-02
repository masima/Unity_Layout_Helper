using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


namespace UI.LayoutHelper.Component
{
    public class LabelToggle : LabelText
    {
        [SerializeField]
        private Toggle _toggle;
        public Toggle Toggle => _toggle;

        public void Setup(string label, bool isOn, UnityAction<bool> onValueChanged)
		{
            Label = label;
            _toggle.isOn = isOn;
            Toggle?.onValueChanged.AddListener(onValueChanged);
		}
    }

}
