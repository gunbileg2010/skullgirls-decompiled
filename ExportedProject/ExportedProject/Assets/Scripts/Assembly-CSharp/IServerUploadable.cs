using System.Collections.Generic;

public interface IServerUploadable
{
	Dictionary<string, object> GetServerUploadData();
}
