using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonAnimation : MonoBehaviour
{
 	public GameObject menuButtons;
	public void showHideMenu()
	{
		if(menuButtons != null)
		{
			Animator animator = menuButtons.GetComponent<Animator>();
			if(animator != null)
			{
				bool isOpen = animator.GetBool("show");
				animator.SetBool("show", !isOpen);
			}
		}
	}
	
}
