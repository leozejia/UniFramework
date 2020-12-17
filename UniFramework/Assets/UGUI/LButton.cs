using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LButton : Button
{
    public bool scaleAnim = false;
    public Vector3 clickDownScale = new Vector3(0.95f, 0.95f, 0.95f);
    public Vector3 normalScale = Vector3.one;

    public bool sound = false;
    public AudioClip clickSound = null;

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        if (scaleAnim)
            transform.localScale = clickDownScale;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);

        if (scaleAnim)
            transform.localScale = normalScale;
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        if (sound && clickSound != null)
        {
            Debug.LogError("PlaySound");
        }
    }
}

[CustomEditor(typeof(LButton))]
public class LButtonEditor : UnityEditor.UI.ButtonEditor
{
    LButton lButton;

    protected override void OnEnable()
    {
        base.OnEnable();
        lButton = (LButton)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.Space();
        serializedObject.Update();

        var prop_ScaleAnim = this.serializedObject.FindProperty("scaleAnim");
        EditorGUILayout.PropertyField(prop_ScaleAnim);
        if (prop_ScaleAnim.boolValue)
        {
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("clickDownScale"));
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("normalScale"));
        }

        var prop_Sound = this.serializedObject.FindProperty("sound");
        EditorGUILayout.PropertyField(prop_Sound);
        if (prop_Sound.boolValue)
        {
            EditorGUILayout.PropertyField(this.serializedObject.FindProperty("clickSound"));
        }

        serializedObject.ApplyModifiedProperties();
    }
}