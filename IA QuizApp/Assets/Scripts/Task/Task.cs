﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task : ITask
{
    public TaskState state = TaskState.DEFAULT;
    public ISubmitButtonListner submitButtonListener;

    public abstract void init(ISubmitButtonListner submitButtonListener);
    public abstract void execute();
    public abstract void result();


    public TaskState getState()
    {
        return state;
    }

    public void setState(TaskState state)
    {
        this.state = state;
    }
}