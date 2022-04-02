using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


namespace UI.LayoutHelper.Component
{
    public class LabelButton : LabelText
    {
        [SerializeField]
        private Button _button;
        public Button Button => _button;


        public void Setup(string label, UnityAction onClick)
		{
            Label = label;
            Button.onClick.AddListener(onClick);
		}
    }

}
