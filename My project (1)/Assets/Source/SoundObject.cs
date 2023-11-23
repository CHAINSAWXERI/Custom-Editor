using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewSoundObject", menuName = "SO/SoundObject")]
public class SoundObject : ScriptableObject
{
    public List<Sound> soundObjectList = new List<Sound>();
    public string longText;

    public void ShowList()
    {
            for (int i = 0; i < soundObjectList.Count; i++)
            {
                Debug.Log(soundObjectList[i]);
            }
    }
}