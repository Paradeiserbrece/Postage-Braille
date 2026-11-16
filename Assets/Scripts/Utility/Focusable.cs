using System;
using System.Collections;
using Braille;
using IO;
using Settings;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Utility
{
    public abstract class Focusable : MonoBehaviour
    {
        public string text;
        [SerializeField] public Image border;
        [SerializeField] internal string confirmText;
        public AssistiveOutput.OutputType assistiveOutputType;

        private IEnumerator Start()
        {
            border.enabled = false;
            yield return new WaitUntil(() => SettingsManager.Settings != null);
            border.color = SettingsManager.Settings.HighlightedColor;
            assistiveOutputType = SettingsManager.Settings.StandardOutputType;
        }

        public virtual void Focus()
        {
            if (!String.IsNullOrEmpty(text)) IOEventManager.InvokeAssistiveOutput(text, assistiveOutputType);
            border.enabled = true;
        }

        public virtual void Unfocus()
        {
            border.enabled = false;
        }

        public virtual void ConfirmAction()
        {
            if (!String.IsNullOrEmpty(confirmText))
                IOEventManager.InvokeAssistiveOutput(confirmText, assistiveOutputType);
        }
    }
}
