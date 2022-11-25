using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSkaf :MonoBehaviour, IInteractable
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
		return "Нажми E, чтобы закрыть шкаф";

	}
	return "Нажми E, чтобы открыть шкаф";
}
public void Interact()
{
		_isOpened = !_isOpened;

	if (_isOpened)
	{
		_animator.SetBool("_isOpened", true);
	}

	else
	{
		_animator.SetBool("_isOpened", false);
	}
}
}
