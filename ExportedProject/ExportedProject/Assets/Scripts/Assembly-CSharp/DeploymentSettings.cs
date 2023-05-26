using System;
using System.Collections.Generic;
using UnityEngine;

public class DeploymentSettings : ScriptableObject, IServerUploadable
{
	[Serializable]
	public class DeploymentWeightPair
	{
		public DeploymentData deploymentData;

		public float weight;
	}

	[SerializeField]
	private List<DeploymentWeightPair> shortDeploymentDataWeighted;

	[SerializeField]
	private List<DeploymentWeightPair> mediumDeploymentDataWeighted;

	[SerializeField]
	private List<DeploymentWeightPair> longDeploymentDataWeighted;

	[SerializeField]
	private long shortDurationMinutes;

	[SerializeField]
	private long mediumDurationMinutes;

	[SerializeField]
	private long longDurationMinutes;

	[SerializeField]
	private Price refreshCost;

	[SerializeField]
	private Price shortHurryUpMaxCost;

	[SerializeField]
	private Price mediumHurryUpMaxCost;

	[SerializeField]
	private Price longHurryUpMaxCost;

	[SerializeField]
	private int maxNumberOfDeploymentsPerDay;

	[SerializeField]
	private double fighterScoreExponent;

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
