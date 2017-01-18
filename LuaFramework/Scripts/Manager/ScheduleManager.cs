using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;

public class ScheduleManager : MonoBehaviour {

	Dictionary<UnityAction, bool> schedules = new Dictionary<UnityAction, bool> ();

    private static ScheduleManager _inst = null;
    public static ScheduleManager inst
	{
		set{ _inst = value;}
		get
		{
			if (_inst == null) {
                GameObject go = new GameObject("[ScheduleManager]");
				return go.AddComponent<ScheduleManager> ();
			}
			return _inst;
		}
	}
  
	void Awake()
	{
        //重新执行脚本生命周期时，防止做重新初始化工作。
		if (_inst != null) return;
		_inst = this;
        //在场景中添加此脚本时，每次返回添加脚本的场景，都会重新执行脚本生命周期。
        //在代码中通过inst新建对象添加脚本时，返回添加场景，不会重新执行脚本生命周期。
        DontDestroyOnLoad(this);
	}

	public static void Schedule(UnityAction action, float delayTime = 1f, bool loop = false, float loopTime = 1f)
	{
		inst._Schedule (action, delayTime, loop, loopTime);	
	}

	public static void UnSchedule(UnityAction action)
	{
		bool run = false;
		if (inst.schedules.TryGetValue (action, out run)) {
			if (run) {
				inst.schedules [action] = false;
			}
		}
	}

	private void _Schedule(UnityAction action, float delayTime, bool loop, float loopTime)
	{
		StartCoroutine (Coroutine1(action, delayTime, loop, loopTime));
	}
	IEnumerator Coroutine1(UnityAction action, float delayTime, bool loop, float loopTime)
	{
		yield return new WaitForSeconds (delayTime);
		if (action != null) {
			action ();
		}
		if (loop && action != null) {
			schedules [action] = true;
			yield return StartCoroutine (Coroutine2(action, loopTime));
		}
	}

	IEnumerator Coroutine2(UnityAction action, float loopTime)
	{
		yield return new WaitForSeconds (loopTime);
		bool run = false;
		if (schedules.TryGetValue(action, out run)) {
			if (run) {
				if (action != null) {
					action ();
				}
				yield return StartCoroutine (Coroutine2(action, loopTime));
			} else {
				schedules.Remove (action);
			}
		}
	}
}
