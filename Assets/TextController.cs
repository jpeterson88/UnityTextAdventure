using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	public Text text;
	private PrisonStates current_state;
	
	private enum PrisonStates
	{
		cell,
		mirror,
		sheets_0,
		lock_0,
		sheets_1,
		lock_1,
		cell_mirror,
		freedom		
	}
		
		// Use this for initialization
	void Start () 
	{
		current_state = PrisonStates.cell;		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(current_state == PrisonStates.cell)
		{
			state_cell();
		}
		else if(current_state == PrisonStates.sheets_0)
		{
			state_sheets_0();
		}
		else if(current_state == PrisonStates.mirror)
		{
			state_mirror();
		}
		else if(current_state == PrisonStates.lock_0)
		{
		
		}
		
	}
	
	private void state_cell()
	{
		text.text = "You are in a prison cell and you want to escape. Ther are some dirty " +
			"sheets on the bed, a mirror on the wall and the door is locked from the outside. \n\n" +
				"Press B to hop in bed, M for mirror and L for lock.";
				
		if(Input.GetKeyDown(KeyCode.B))
		{			
			current_state = PrisonStates.sheets_0;
		}		
		else if(Input.GetKeyDown(KeyCode.M))
		{			
			current_state = PrisonStates.mirror;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{			
			current_state = PrisonStates.lock_0;
		}
	}
	
	private void state_sheets_0()
	{
		text.text = "That bed looks nasty...You should reconsider getting back in " +
			"bed if you want to bust out of here" + " \n\n" + 
				"Press R to return to pacing around in your cell.";
			
		if(Input.GetKeyDown(KeyCode.R))
		{			
			current_state = PrisonStates.cell;
		}
	}
	
	private void state_mirror()
	{
		text.text = "This mirror looks quite interesting and may be of some use. \n\n" +
			"Press T to take the mirror off of the wall or R to return to your cell.";
			
		if(Input.GetKeyDown(KeyCode.T))
		{
			current_state = PrisonStates.cell_mirror;
		}
	}
	
	private void state_lock_0()
	{
		text.text = "";
	}
	
	
	
}
