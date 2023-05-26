using System;

public interface IRunOnMainThread
{
	void RunOnMainThread(Action callback);
}
