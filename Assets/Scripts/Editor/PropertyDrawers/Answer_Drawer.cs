using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Answer))]
public class Answer_Drawer : PropertyDrawer {

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) + 50;
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        
        GUI.Box(position, GUIContent.none);

        SerializedProperty isCorrectProp = property.FindPropertyRelative("_isCorrect");
        Rect isCorrectRect = new Rect(position.x + 5, (position.y + position.height / 1.5f) - 7.5f, 15, 25);
        isCorrectProp.boolValue = EditorGUI.Toggle(isCorrectRect, isCorrectProp.boolValue, EditorStyles.radioButton);

        Rect labelRect = new Rect(position.x + isCorrectRect.width + 10, position.y, 85, 85);
        GUIStyle labelStyle = new GUIStyle(EditorStyles.miniLabel)
        {
            alignment = TextAnchor.MiddleLeft
        };
        GUI.Label(labelRect, new GUIContent("Answer:", "Define an Answer."), labelStyle);

        SerializedProperty infoProp = property.FindPropertyRelative("_info");
        Rect infoRect = new Rect(labelRect.x + labelRect.width, (position.y + position.height / 2) - 18, position.width - 75, 35);

        GUIStyle textAreaStyle = new GUIStyle(EditorStyles.textArea)
        {
            alignment = TextAnchor.MiddleLeft,
            fontStyle = FontStyle.Bold,
        };

        infoProp.stringValue = EditorGUI.TextArea(infoRect, infoProp.stringValue, textAreaStyle);

        
    }
}