using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour 
{
	
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
			state_lock_0();
		}
		else if(current_state == PrisonStates.cell_mirror)
		{
			state_cell_mirror();
		}
		else if(current_state == PrisonStates.sheets_1)
		{
			state_sheets_1();
		}
		else if (current_state == PrisonStates.lock_1)
		{
			state_lock_1();
		}
		else if(current_state == PrisonStates.freedom)
		{
			state_freedom();
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
			"Press T to take the mirror off of the wall or R to return to pacing your cell.";
		
		if(Input.GetKeyDown(KeyCode.T))
		{
			current_state = PrisonStates.cell_mirror;
		}
		if(Input.GetKeyDown(KeyCode.R))
		{
			current_state = PrisonStates.cell;
		}
	}
	
	private void state_lock_0()
	{
		text.text = "Hmmm. It appears to be locked. We may want to find something in the room to jimmy it open. \n\n" + 
			"Press R to continue pacing.";
			
		if(Input.GetKeyDown(KeyCode.R))
		{			
			current_state = PrisonStates.cell;
		}
	}
	
	private void state_cell_mirror()
	{
		text.text = "Alright, we're getting somewhere. Where would you like to try to use this mirror? \n\n" +
			"Press B to place it in the bed or L to see if it fits in the lock.";
			
			if(Input.GetKeyDown (KeyCode.B))
			{
				current_state = PrisonStates.sheets_1;
			}
			else if(Input.GetKeyDown (KeyCode.L))
			{
				current_state = PrisonStates.lock_1;
			}
	}
	
	private void state_sheets_1()
	{
		text.text = "You sure look pretty laying down with this mirror, but you have work to do. \n\n"+
			"Press R to get up with your lovely mirror and try something else.";
			
		if(Input.GetKeyDown (KeyCode.R))
		{
			current_state = PrisonStates.cell_mirror;
		}
	}
	
	private void state_lock_1()
	{
		text.text = "It appears you can jimmy this thing open with the mirror... \n\n" + 
		"Press J to jimmy open or R to return to your cell.";
		
		if(Input.GetKeyDown (KeyCode.J))
		{
			current_state = PrisonStates.freedom;
		}
		else if(Input.GetKeyDown (KeyCode.R))
		{
			current_state = PrisonStates.cell_mirror;
		}
		
	}
	
	private void state_freedom()
	{
		text.text = "Congratulations! You have escaped! The End. \n\nPress P to play again";
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			current_state = PrisonStates.cell;
		}
	}
	
}


















