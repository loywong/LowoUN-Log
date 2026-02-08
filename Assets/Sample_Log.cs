//注意: 需要添加脚本编译宏 PROJECT_LOG

using LowoUN.Util;
using UnityEngine;

public class Sample_Log : MonoBehaviour {
	[SerializeField] bool isDebug;
	void Start () {
		LLog.Init (isDebug);

		LLog.Warn("some warning log");
		LLog.Error("some error log");

		LLog.Blue("data","log data");
		LLog.Gray("asset","log asset");
		LLog.Gray("ui","log ui");
		LLog.Green("scene","log scene");
		LLog.Green("flow","log flow");
		LLog.Trace("util","log util");
		LLog.Orange("test","log test");

		LLog.Trace("map","log map");
		LLog.Trace("battle","log battle");
		LLog.Trace("nav","log nav");
	}
}