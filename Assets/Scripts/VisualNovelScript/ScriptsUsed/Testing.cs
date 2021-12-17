using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
	DialogueSystem dialogue;
	
	//public GameObject spawnCrewSprite;
	//public GameObject crewLocation;
	//public GameObject spawnGeneralSprite;
	//public GameObject generalLocation;
	//public GameObject spawnOceanaSprite;
	//public GameObject oceanaLocation;
	
    // Start is called before the first frame update
    void Start()
    {
        dialogue = DialogueSystem.instance;
	
    }

public string[] s = new string[]
	{		
			
		"They took them…:Mark",
		
		"The two most important people in this world…",
		
		"They are going to get what’s coming to them.",
		
		"Mark enters the gang's hideout and defeats the guards in the entrance.:Narrator",
		
		"So it was you who made all that noise.:Blink",
		
		"You must have lost your mind coming here alone!",
		
		"No need to butt in, I’ll take this guy down myself!",
		
		"*He is not like the others.*:Mark",
		
		"*He has leg augments.*",
		
		"*I need to be careful.*",
		
	
		
		
	};

	int index = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
			{
				if(index>= s.Length)
				{
					return;
				}
				
				Say(s[index]);
				index++;

			}
		}
    }

	void Say(string s)
	{
		string[] parts = s.Split(':');
		string speech = parts[0];
		string speaker = (parts.Length >= 2)? parts[1] : "";
		
		dialogue.Say(speech, speaker);
	}
	


}

