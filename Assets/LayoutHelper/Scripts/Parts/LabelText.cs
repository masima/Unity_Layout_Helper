using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UI.LayoutHelper.Parts
{
    public class LabelText : MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        public Text Text => _text;

        public string Label
		{
			get
			{
                return _text?.text ?? string.Empty;
			}
			set
			{
				if (null == _text)
				{
					return;
				}
				_text.text = value;
			}
		}

    }

}
