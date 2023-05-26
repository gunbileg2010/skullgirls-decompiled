public interface IDataSource
{
	void SetString(string key, string value);

	string GetString(string key, string defaultValue = null);

	void SetInt(string key, int value);

	int GetInt(string key, int defaultValue = 0);

	void SetLong(string key, long value);

	long GetLong(string key, long defaultValue = 0L);

	void SetFloat(string key, float value);

	float GetFloat(string key, float defaultValue = 0f);

	void SetBool(string key, bool value);

	bool GetBool(string key, bool defaultValue = false);

	void SetObject(string key, object value);

	object GetObject(string key, object defaultValue = null);

	bool Delete();

	bool DeleteKey(string key);

	bool HasKey(string key);

	bool HasUnsavedChanges();

	bool Save();
}
