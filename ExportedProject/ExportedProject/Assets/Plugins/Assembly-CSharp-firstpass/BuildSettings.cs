public static class BuildSettings
{
	public enum Partner
	{
		None = 0,
		LINE = 1,
		Autumn = 2
	}

	public enum Store
	{
		None = 0,
		Apple = 1,
		Google = 2,
		Huawei = 3
	}

	public enum DefaultBackend
	{
		None = 0,
		local = 1,
		dev_skullgirls = 2,
		qa_skullgirls = 3,
		staging_skullgirls = 4,
		Autumn_Release = 5
	}

	public enum Cdn
	{
		AWS_skullgirls_dev = 0,
		AWS_skullgirls_qa = 1,
		AWS_skullgirls_staging = 2,
		Autumn_Release = 3
	}

	public static readonly string versionNumber;

	public static readonly HVSBuildType buildType;

	public static readonly string appTitle;

	public static readonly string bundleId;

	public static readonly Partner partner;

	public static readonly Store store;

	public static readonly DefaultBackend defaultBackend;

	public static readonly bool allowDevBackends;

	public static readonly Cdn cdn;

	public static readonly bool beta;

	public static readonly bool memoryBenchmark;
}
