using UnityEngine;

public class StatementsString : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (name == "HANAWAT")
        {
            print("YOU ARE HANAWAT!");
        }
        else
        {
            print("YOU ARE NOT HANAWAT");
        }
    }
}