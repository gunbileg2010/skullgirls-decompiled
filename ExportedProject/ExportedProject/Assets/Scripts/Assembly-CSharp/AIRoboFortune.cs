using System.Collections;

public class AIRoboFortune : AICharacter
{
	private AIOptions commandOptions;

	private const float kMinimumSafeDroneSpawnDistance = 775f;

	private const float kMinimumDroneAttackDistance = 250f;

	private const int kMaxPossibleDrones = 4;

	private const int kMaxCommandableDrones = 3;

	private const Slot kHeadCountSlot = Slot.LIGHT_Z;

	private const int kDetonationModeFlag = 29;

	private bool willDroneSpawn;

	private bool willDroneAttack;

	public override void Init(AIInputProvider aiInputProvider)
	{
	}

	public override bool ShouldPerformOffensiveCharacterAbility()
	{
		return false;
	}

	public override IEnumerator PerformOffensiveCharacterAbility()
	{
		return null;
	}

	public override IEnumerator ActivateGear(GearStatusTracker gearTracker)
	{
		return null;
	}

	private int GetHeaddroneCount()
	{
		return 0;
	}

	private bool ShouldDroneSpawn()
	{
		return false;
	}

	private bool ShouldDroneAttack()
	{
		return false;
	}

	private IEnumerator PerformDroneAction()
	{
		return null;
	}

	private IEnumerator DroneSpawn()
	{
		return null;
	}

	private IEnumerator DroneSalvo()
	{
		return null;
	}

	private IEnumerator DroneRAM()
	{
		return null;
	}

	private IEnumerator DroneMine()
	{
		return null;
	}

	private float GetDistanceFromEnemy()
	{
		return 0f;
	}

	private IEnumerator MagneticTrap(GearStatusTracker gearTracker)
	{
		return null;
	}
}
