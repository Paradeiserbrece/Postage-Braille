using System;
using System.Collections;
using Data;
using IO;
using Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Utility;

namespace UI
{
    public class FocusableDeleteButton : Focusable
    {
        [SerializeField] internal Image defaultIcon;
        [SerializeField] internal Image confirmIcon;
        private bool _displayConfirmText = false;
        [SerializeField] internal String confirmedText = "";

        private void Start()
        {
            defaultIcon.gameObject.SetActive(true);
            confirmIcon.gameObject.SetActive(false);
        }

        public override void ConfirmAction()
        {
            // The first time the button is pressed we prompt the user to confirm the action again
            if (!_displayConfirmText)
            {
                defaultIcon.gameObject.SetActive(false);
                confirmIcon.gameObject.SetActive(true);

                _displayConfirmText = true;
                if (!String.IsNullOrEmpty(confirmText))
                    IOEventManager.InvokeAssistiveOutput(confirmText, assistiveOutputType);
                return;
            }
            // Actually delete the save file
            _displayConfirmText = false;
            defaultIcon.gameObject.SetActive(true);
            confirmIcon.gameObject.SetActive(false);
            SaveSystem.DeleteProgress();
            IOEventManager.InvokeAssistiveOutput(confirmedText, assistiveOutputType);
                
            // Re-render the PackagePickerScreen in-place without moving focus or invoking extra focus
            LetterPackagePicker.Instance.ScrollToTop();
            LetterPackagePicker.Instance.PopulateWithCurrentLanguagePackage();
            LetterPackagePicker.Instance.SelectLetterUnit(LetterPackages.Instance.CurrentPackageUnit);
        }

        public override void Unfocus()
        {
            base.Unfocus();
            defaultIcon.gameObject.SetActive(true);
            confirmIcon.gameObject.SetActive(false);
            _displayConfirmText = false;
        }
    }
}
