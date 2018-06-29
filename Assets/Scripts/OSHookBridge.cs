﻿using System.Runtime.InteropServices;

public class OSHookBridge
{
#if UNITY_IOS

    #region 高德SDK

    [DllImport("__Internal")]
	public static extern void LocateInit(); //初始化定位

	[DllImport("__Internal")]
	public static extern void LocateOnce(); //单次定位

	[DllImport("__Internal")]
	public static extern void LocateUpdate(); //持续定位

    [DllImport("__Internal")]
    public static extern void LocateStop(); //结束定位

    //[DllImport("__Internal")]
	//public static extern void ShowMapView(); //显示地图

    #endregion

#elif UNITY_ANDROID

    [DllImport("OSHook", CallingConvention=CallingConvention.Cdecl)]
	public static extern void LocateInit();

#endif
}
