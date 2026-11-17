using Braille;
using UI;
using Color = UnityEngine.Color;

namespace Settings
{
    [System.Serializable]
    public class GlobalSettings
    {
        // General settings
        public AssistiveOutput.OutputType StandardOutputType = AssistiveOutput.OutputType.Both;
        public UITextObject.DisplayMode StandardDisplayMode = UITextObject.DisplayMode.Braille;
        public bool StartTutorial = true;
        public int IgnoreDoubleInputTime = 0; //in milliseconds

        // Braille size
        public float MinBrailleSize = 30f;
        public float BaseBrailleSize = 50f;
        public float MaxBrailleSize = 70f;
        public float BrailleSizeIncrement = 5f;
        public float BrailleSize = 50f;

        // Dot size
        public float MinDotSize = 0.2f;
        public float BaseDotSize = 0.7f;
        public float MaxDotSize = 0.9f;
        public float DotSizeIncrement = 0.1f;
        public float DotSize = 0.7f;

        // Braille spacing
        public float MinBrailleSpacing = 0f;
        public float BaseBrailleSpacing = 5f;
        public float MaxBrailleSpacing = 50f;
        public float BrailleSpacingIncrement = 5f;
        public float BrailleSpacing = 5f;

        // Line spacing
        public float MinLineSpacing = 20f;
        public float BaseLineSpacing = 100f;
        public float MaxLineSpacing = 150f;
        public float LineSpacingIncrement = 10f;
        public float LineSpacing = 100f;

        // Text settings
        public float TextScrollDelay = 1f;
        public float TextResetDelay = 1f;
        public float TextScrollSpeed = 520f;

        // Audio settings
        public bool AdditionalAudioOutput = true;

        // Colors
        public Color BrailleColor = Color.black;
        public Color HighlightedColor = Color.red;
        public Color HighlightedButtonColor = Color.brown;
        public Color TextColor = Color.white;
        public Color MenuOptionColor = Color.white;
        public Color SortingBoxColor = Color.white;
        public Color QuestionBrailleColor = Color.black;
        public Color QuestionTextColor = Color.black;
        public Color PackageTextColor = Color.black;
    }
}
