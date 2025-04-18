using EditorExtend;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PawnBrain))]
public class PawnBrainEditor : AutoEditor
{
    [AutoProperty]
    public SerializedProperty humanControl, personality, plans, prepared;

    protected override void MyOnInspectorGUI()
    {
        humanControl.BoolField("由玩家控制");
        if (!humanControl.boolValue)
            personality.PropertyField("个性(与全局系数相加)");
        if (Application.isPlaying)
        {
            plans.ListField("当前计划");
            prepared.BoolField("准备好行动");
        }
    }
}