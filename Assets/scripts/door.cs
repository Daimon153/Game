using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class door : MonoBehaviour, IInteractable
{
	public bool _isOpened;
	public Animator _animator;


	private void Start()
	{
		_animator = GetComponent<Animator>();
	}
	public string GetDescription()
	{
		if (_isOpened)
		{
			return "Нажми E, чтобы закрыть дверь";
			
		}return "Нажми E, чтобы открыть дверь";
	}
	public void Interact()
	{
		_isOpened = !_isOpened;

		if (_isOpened) {
			_animator.SetBool("_isOpened", true);
		}

		else
		{
			_animator.SetBool("_isOpened", false);
		}
	}
}





