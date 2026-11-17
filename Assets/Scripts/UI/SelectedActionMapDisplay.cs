using TMPro;
using UnityEngine;
using Utility;

namespace UI
{
    public class SelectedActionMapDisplay: Focusable
    {
        [SerializeField] private TextMeshProUGUI _actionMapName;

        private void Start()
        {
            _actionMapName.text = text;
        }
        
        public void SetActionMapName(string text)
        {
            _actionMapName.text = text;
            this.text = text;
        }
    }
}
