﻿using System;
using LuaInterface;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;


public class LuaBehaviour : UIBase
{
    //模块文件的路径
    public string luaFile;
    //对应的Lua实例的Table
    public LuaTable luaInstance;
    //lua实例名
    private string luaClassName;
    //lua中的函数
    private LuaFunction m_Awake = null;
    private LuaFunction m_Start = null;
    private LuaFunction m_OnEnable = null;
    private LuaFunction m_OnOpen = null;
    private LuaFunction m_Update = null;
    private LuaFunction m_OnClose = null;
    private LuaFunction m_OnDisable = null;
    private LuaFunction m_OnDestory = null;

    private void Awake()
    {
        luaInstance = LuaScriptManager.Instance.RunLuaFile<LuaTable>(luaFile);
        luaClassName = (string)luaInstance["className"];

        //初始化lua类
        Dictionary<string, object> param = new Dictionary<string, object>();
        luaInstance["transform"] = transform;
        luaInstance["gameObject"] = gameObject;

        //获取lua中的函数
        m_Awake = (LuaFunction)luaInstance["Awake"];
        m_Start = (LuaFunction)luaInstance["Start"];
        m_OnEnable = (LuaFunction)luaInstance["OnEnable"];
        m_OnOpen = (LuaFunction)luaInstance["OnOpen"];
        m_Update = (LuaFunction)luaInstance["Update"];
        m_OnClose = (LuaFunction)luaInstance["OnClose"];
        m_OnDisable = (LuaFunction)luaInstance["OnDisable"];
        m_OnDestory = (LuaFunction)luaInstance["OnDestory"];

        if (null != m_Awake)
        {
            m_Awake.Call<LuaTable>(luaInstance);
        }
    }
       
    private void Start()
    {
        if (null != m_Start)
        {
            m_Start.Call<LuaTable>(luaInstance);
        }
    }

    private void OnEnable()
    {
        if (null != m_OnEnable)
        {
            m_OnEnable.Call<LuaTable>(luaInstance);
        }
    }
    public override void OnOpen()
    {
        base.OnOpen();
        if (null != m_OnOpen)
        {
            m_OnOpen.Call<LuaTable>(luaInstance);
        }
    }
    private void Update()
    {
        if (null != m_Update)
        {
            m_Update.Call<LuaTable>(luaInstance);
        }
    }

    public override void OnClose()
    {
        base.OnClose();
        if (null != m_OnClose)
        {
            m_OnClose.Call<LuaTable>(luaInstance);
        }
    }

    private void OnDisable()
    {
        if (null != m_OnDisable)
        {
            m_OnDisable.Call<LuaTable>(luaInstance);
        }
    }

    private void OnDestory()
    {
        if (null != m_OnDestory)
        {
            m_OnDestory.Call<LuaTable>(luaInstance);
        }
    }
}