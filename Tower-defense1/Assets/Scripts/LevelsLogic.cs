using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsLogic : MonoBehaviour
{
    public List<object> Levels = new List<object>();

    string jsonContent;

    private void Start()
    {
        readJson();
    }

    public interface level
    {
        string Name { get; set; }
        int Level { get; set; }
        int Waves { get; set; }
        string[] Enemies { get; set; }

    }

    public class levelDetails : level
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public int Waves { get; set; }
        public string[] Enemies { get; set; }


        public void setLevel(string name, int level, int waves, string[] enemies)
        {

            Name = name;
            Level = level;
            Waves = waves;
            Enemies = enemies;

        }

    }


    public void readJson()
    {
        TextAsset jsonFile = Resources.Load<TextAsset>("levels");

        if (jsonFile != null)
        {
            string jsonContent = jsonFile.text;
            Debug.Log(jsonContent);


        }
        else
        {
            Debug.LogError("Plik JSON nie zosta³ za³adowany.");
        }
    }


}
