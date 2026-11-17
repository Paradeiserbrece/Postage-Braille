using IO;
using Settings;

namespace Tutorial
{
    /// <summary>
    /// Holds the Outputs for the Tutorial.
    /// Only handles the Outputs and not the necessary transitions needed for the tutorial to continue to the next steps.
    /// Tutorial flow is handled in <see cref="TutorialFlow"/>
    /// <remarks>
    /// It is primarily used as a shorthand for assistive output invocations and is prepared for introducing data driven
    /// outputTexts, which is why we have so many string declarations that are not used anywhere else.
    /// In the future you would want to have something along the lines of `string outputText = getTextForCurrentLanguage(TutorialStep)`
    /// Every method also has a return value as you can control the tutorial flow with the use of the string being output via `AssistiveOutput.WaitForSpeakingToFinish(..., text);`
    /// </remarks>
    /// </summary>
    public static class TutorialOutputs
    {
        private static string outputText = "";

        public static string FirstLetterOutput()
        {
            outputText =
                "Willkommen zum Braille Lernprogramm Postage Braille! Die Einführung kann man mit der Escape-Taste überspringen. Der ausgegebene und oben dargestellte Text kann jederzeit mit der Leertaste oder F1 Taste in einem separaten Fenster angezeigt werden. Du befindest dich gerade am Spiel Bildschirm. Am Anfang ist immer der Brief ausgewählt. Dieser beinhaltet die aktuelle Frage. Drücke die Tabulator taste um zu den Antwortmöglichkeiten zu gelangen.";
            Output(outputText);
            return outputText;
        }

        public static string FirstAnswerOutput()
        {
            outputText =
                "Das ist die erste Antwortmöglichkeit. Mit Pfeiltaste rechts und Pfeiltaste links kann man die Antworten navigieren. Wähle doch mal die zweite Antwort aus.";
            Output(outputText);
            return outputText;
        }

        public static string SecondAnswerFocus()
        {
            outputText = "Das ist die Zweite Antwort. Mit der Enter-Taste kannst du die Antwort bestätigen. Probier es gleich mal aus!";
            Output(outputText);
            return outputText;
        }

        public static string SecondAnswerSubmit()
        {
            outputText =
                "Du hast die Antwort bestätigt und bekommst danach eine Rückmeldung! Wenn eine Rückmeldung angezeigt wird kannst du eine beliebige Taste drücken um fortzufahren. Drücke auch jetzt eine beliebige Taste um fortzufahren.";
            Output(outputText);
            return outputText;
        }

        public static string ThirdAnswerOutput()
        {
            outputText =
                "Das ist die Dritte Antwort. Es gibt immer drei Antwortmöglichkeiten. Gehe doch zur Zweiten zurück. Nutze dafür die linke Pfeiltaste";
            Output(outputText);
            return outputText;
        }

        public static string SecondLetterOutput()
        {
            outputText =
                "Nach beantworten der Frage kommt man zum Brief zurück. Verwende die Tabulator Taste um zum Menü zu gelangen.";
            Output(outputText);
            return outputText;
        }

        public static string SecondFirstAnswerOutput()
        {
            outputText = "Das ist die erste Antwortmöglichkeit. Drücke die Tabulator-Taste erneut.";
            Output(outputText);
            return outputText;
        }

        public static string FirstSwitchPackButtonOutput()
        {
            outputText =
                "Das ist die Spielmenü-Leiste. Zuerst ist der \"Einheit Auswählen\" Knopf ausgewählt. Drücke die Enter-Taste um eine andere Einheit auszuwählen.";
            Output(outputText);
            return outputText;
        }

        public static string FirstPackageBackButtonOutput()
        {
            outputText =
                "Auf diesem Bildschirm kannst du die Einheiten auswählen. Am anfang ist der Zurück Knopf ausgewählt. Mit den Pfeiltasten kannst du im Menü navigieren. Navigiere zum nächsten Knopf mit Pfeiltaste rechts.";
            Output(outputText);
            return outputText;
        }

        public static string FirstSelectedUnitOutput()
        {
            outputText =
                "Hier kannst du die ausgewählte einheit Überprüfen. Navigiere zum nächsten Knopf mit Pfeiltaste rechts.";
            Output(outputText);
            return outputText;
        }


        public static string FirstDeleteButtonOutput()
        {
            outputText =
                "Dieser Knopf löscht deinen Fortschritt falls du deinen Speicherstand zurücksetzen willst. Das sind alle Buttons in der Menüleiste. Mit der Tabulator-Taste wechselst du auf die Einheitenliste.";
            Output(outputText);
            return outputText;
        }

        public static string FirstUnitpickerOutput()
        {
            outputText =
                "Das ist die Einheitenliste. Mit der Enter-Taste kann man eine Einheit auswählen. Versuche jetzt selbstständig zum Spielbildschirm zurück zu navigieren. Vergiss nicht: Mit der Tabulator Taste wechselst du in das Menü und mit den Pfeiltasten navigierst du im Untermenü. Mit Enter kannst du die Aktion ausführen.";
            Output(outputText);
            return outputText;
        }

        public static string SecondUnitpickerOutput()
        {
            outputText =
                "Einheit eins. In der Einführung kannst du nur diese Auswählen. Versuche jetzt selbstständig zum Spielbildschirm zurück zu navigieren. Vergiss nicht: Mit der Tabulator Taste wechselst du in das Menü und mit den Pfeiltasten navigierst du im Untermenü. Mit Enter kannst du die Aktion ausführen.";
            Output(outputText);
            return outputText;
        }

        public static string SecondPackageBackButtonOutput()
        {
            outputText = "Zurück";
            Output(outputText);
            return outputText;
        }

        public static string SecondDeleteButtonOutput()
        {
            outputText = "Fortschritt löschen.";
            Output(outputText);
            return outputText;
        }

        public static string SecondSelectedUnitOutput()
        {
            outputText = "Das ist die ausgewählte Einheit. In der Einführung gibt es nur Einheit eins.";
            Output(outputText);
            return outputText;
        }

        public static string ThirdLetterOutput()
        {
            outputText =
                "Du bist nun wieder am Spielbildschirm. Du bist nun mit dem Hauptteil des Spiels vertraut, es gibt aber noch eine andere Funktion. Navigiere in die menüleiste.";
            Output(outputText);
            return outputText;
        }

        public static string SecondSwitchPackButtonOutput()
        {
            outputText =
                "Du bist nun wieder in der Menüleiste des Spielbildschirms. Den ersten Knopf kennst du bereits, mit diesem sind wir zum Bildschirm zum auswählen von Einheiten gekommen. Navigiere zu den anderen Knöpfen um zu lernen was sie können.";
            Output(outputText);
            return outputText;
        }

        public static string ThirdSwitchPackButtonOutput()
        {
            outputText =
                "Dieser Knopf bringt dich in den Bildschirm zum Auswählen von Einheiten, navigiere zum Einstellungen Bildschirm um die Einleitung fortzufahren.";
            Output(outputText);
            return outputText;
        }

        public static string QuestionDirectionOutput()
        {
            outputText =
                "Dieser Knopf ändert die Fragerichtung. Anfangs ist die Frage in Braille dargestellt und die Antworten durch Schwarzschrift und Audio. Nach drücken des Knopfes wird zur umgekehrten Fragerichtung gewechselt.";
            Output(outputText);
            return outputText;
        }

        public static string QuestionModeOutput()
        {
            outputText =
                "Mit diesem Knopf änderst du die Art der Fragen. Anfangs werden einzelne Buchstaben der aktuellen Einheit abgefragt. Alternativ kann man Wörter aus allen gelernten Buchstaben abfragen. Vergiss nicht hin und wieder die Art zu wechseln.";
            Output(outputText);
            return outputText;
        }

        public static string SettingsOutput()
        {
            outputText =
                "Dieser Knopf führt zum Einstellungsmenü. Drücke die Entertaste um zu den Einstellungen zu gelangen.";
            Output(outputText);
            return outputText;
        }

        public static string FirstRebindBackOutput()
        {
            outputText =
                "Du befindest dich jetzt im Einstellungsbildschirm. Anfangs ist der Zurück Knopf ausgewählt. Navigiere doch durch die anderen Menüpunkte.";
            Output(outputText);
            return outputText;
        }

        public static string NavigationOutput()
        {
            outputText =
                "Hiermit öffnest du die Tastenbelegung für die Navigation. Um eine Tastenbelegung zu ändern wähle in der Liste die zu ändernde Aktion aus und drücke die Enter-Taste. Danach drücke die gewünschte Taste. Die Aktion wird von nun an mit der neuen Taste ausgelöst. Das Ändern der Tastenbelegung ist in der Einführung nicht möglich.";
            Output(outputText);
            return outputText;
        }

        public static string BrailleSettingsOutput()
        {
            outputText =
                "Hiermit öffnest du die Tastenbelegung für die Braille Darstellung. Das ändern der Tastenbelegung erfolgt gleich als bei der Navigation.";
            Output(outputText);
            return outputText;
        }

        public static string PerkinsBraillerOutput()
        {
            outputText =
                "Hiermit öffnest du die Tastenbelegung für den Perkinsbrailler. Anfangs sind die Perkinsbraillertasten SDF und JKL an der Tastatur.";
            Output(outputText);
            return outputText;
        }

        public static string ResetOutput()
        {
            outputText =
                "Dieser Knopf setzt alle Tastenbelegungen auf die Standardeinstellungen zurück. Alternativ kann man auch die Home-Taste oder Pos1-Taste drücken. Jetzt bist du mit der Navigation vertraut. Gehe doch auf den Spielbildschirm zurück.";
            Output(outputText);
            return outputText;
        }

        public static string SecondRebindBackOutput()
        {
            outputText = "Zurück";
            Output(outputText);
            return outputText;
        }

        public static string RebindBackOutputSubmit()
        {
            outputText =
                "Super! Du hast die Einführung abgeschlossen! Du kommst jetzt zum Spielbildschirm zurück und kannst ab jetzt frei navigieren. Du kannst die Einführung mit dem Knopf in dem Menüband jederzeit erneut starten. Viel Spaß beim Lernen. Drücke eine beliebige Taste zum Fortfahren.";
            Output(outputText);
            return outputText;
        }

        public static string InvalidKeyPressOutput()
        {
            Output("Knopf in diesem Einführungsabschnitt deaktiviert. " + outputText);
            return outputText;
        }

        public static string SkipTutorial()
        {
            outputText =
                "Einführung wird Übersprungen. Du kannst sie jederzeit mit dem Knopf im Menüband erneut starten. Drücke eine beliebige Taste zum Fortfahren.";
            Output(outputText);
            return outputText;
        }

        private static void Output(string text)
        {
            IOEventManager.InvokeAssistiveOutput(text, SettingsManager.Settings.StandardOutputType);
        }
    }
}
