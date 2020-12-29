// add new damagetypes
$DamageType::LaserDrillBeam = 70;
$DamageTypeText[70] = 'laser drill';

$DamageType::ExplodingRock = 71;
$DamageTypeText[71] = 'a rock';

// add new damage profiles
LightPlayerDamageProfile.damageScale[$DamageType::LaserDrillBeam]	= 1.12;
LightPlayerDamageProfile.damageScale[$DamageType::ExplodingRock]	= 3.0;
MediumPlayerDamageProfile.damageScale[$DamageType::LaserDrillBeam]	= 1.1;
MediumPlayerDamageProfile.damageScale[$DamageType::ExplodingRock]	= 3.0;
HeavyPlayerDamageProfile.damageScale[$DamageType::LaserDrillBeam]	= 0.67;
HeavyPlayerDamageProfile.damageScale[$DamageType::ExplodingRock]	= 3.0;

// used when a player is killed by the laser drill beam
$DeathMessageLaserDrillBeamCount = 4;
$DeathMessageLaserDrillBeam[0] = '\c0%1 gets a new torso-sized body piercing.';
$DeathMessageLaserDrillBeam[1] = '\c0%1 temporarily forgot that high-energy mining lasers can kill so easily.';
$DeathMessageLaserDrillBeam[2] = '\c0%1 eats the big beam.';
$DeathMessageLaserDrillBeam[3] = '\c0%1 thought it was a good day to die.';

// used when a player is killed by an exploding rock
$DeathMessageExplodingRockCount = 3;
$DeathMessageExplodingRock[0] = '\c0%1 got a piece of the rock.';
$DeathMessageExplodingRock[1] = '\c0%1 had a nasty spelunking experience.';
$DeathMessageExplodingRock[2] = '\c0%1 becomes gravellicious!';

//--------------------------------------------------------------------------
// ForceFieldTrigger
//--------------------------------------------------------------------------

// this datablock doesn't really do anything,
// but needs to exist (useful for scheduling,
// but not for how it's being used here)
datablock TriggerData(ForceFieldTrigger)
{
	tickPeriodMS = 50;
};

// here's the sound effect for
// landing on the platform, including
// the range (7.0m) in which the
// effect is audible
datablock EffectProfile(PlatformLandEffect)
{
	effectname = "armor/heavy_RF_uw";
	minDistance = 0.0;
	maxDistance = 7.0;
};

// here's where the type of sound effect is defined
datablock AudioProfile(PlatformLandSound)
{
	fileName = "fx/armor/heavy_RF_uw.wav";
	description = AudioClose3d;
	preload = true;
	effect = PlatformLandEffect;
};

//--------------------------------------------------------------------------
// Force Fields
//--------------------------------------------------------------------------

datablock ForceFieldBareData(ShaftedSparkleField)
{
	fadeMS           = 2000;
	baseTranslucency = 0.8;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = false;
	color            = "0.2 0.2 0.3";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/enrgcore0001.png";
	texture[1] = "skins/enrgcore0002.png";
	texture[2] = "skins/enrgcore0003.png";
	texture[3] = "skins/enrgcore0004.png";
	texture[4] = "skins/enrgcore0005.png";

	framesPerSec = 10;
	numFrames = 5;
	scrollSpeed = 10;
	umapping = 0.45;
	vmapping = 0.65;
};

datablock ForceFieldBareData(ShaftedStaticField)
{
	fadeMS           = 2000;
	baseTranslucency = 0.6;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.4 0.2 0.3";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/screenstatic1.png";
	texture[1] = "skins/screenstatic2.png";
	texture[2] = "skins/screenstatic3.png";
	texture[3] = "skins/screenstatic4.png";
	texture[4] = "skins/screenstatic5.png";

	framesPerSec = 5;
	numFrames = 5;
	scrollSpeed = 5;
	umapping = 0.4;
	vmapping = 0.4;
};

datablock ForceFieldBareData(RedSimonSaysSquare)
{
	fadeMS           = 1000;
	baseTranslucency = 0.70;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "0.9 0.0 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/energydis0001";
	texture[1] = "skins/energydis0002";
	texture[2] = "skins/energydis0003";
	texture[3] = "skins/energydis0002";

	framesPerSec = 8;
	numFrames = 4;
	scrollSpeed = 0;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(RedBarrier)
{
	fadeMS           = 2000;
	baseTranslucency = 1;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.7 0.0 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/beagle.switch.png";
	framesPerSec = 1;
	numFrames = 1;
	scrollSpeed = -1;
	umapping = 0.045;
	vmapping = -0.045;
};

datablock ForceFieldBareData(YellowSimonSaysSquare)
{
	fadeMS           = 1000;
	baseTranslucency = 0.70;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "0.9 0.9 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/energydis0001";
	texture[1] = "skins/energydis0002";
	texture[2] = "skins/energydis0003";
	texture[3] = "skins/energydis0002";

	framesPerSec = 8;
	numFrames = 4;
	scrollSpeed = 0;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(YellowBarrier)
{
	fadeMS           = 2000;
	baseTranslucency = 1;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.7 0.7 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/cotp.switch.png";
	framesPerSec = 1;
	numFrames = 1;
	scrollSpeed = 1;
	umapping = 0.045;
	vmapping = -0.045;
};

datablock ForceFieldBareData(GreenSimonSaysSquare)
{
	fadeMS           = 1000;
	baseTranslucency = 0.70;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "0.0 0.9 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/energydis0001";
	texture[1] = "skins/energydis0002";
	texture[2] = "skins/energydis0003";
	texture[3] = "skins/energydis0002";

	framesPerSec = 8;
	numFrames = 4;
	scrollSpeed = 0;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(GreenBarrier)
{
	fadeMS           = 2000;
	baseTranslucency = 1;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.0 0.7 0.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/dsword.switch.png";
	framesPerSec = 1;
	numFrames = 1;
	scrollSpeed = -1;
	umapping = 0.045;
	vmapping = -0.045;
};

datablock ForceFieldBareData(BlueSimonSaysSquare)
{
	fadeMS           = 1000;
	baseTranslucency = 0.70;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "0.0 0.35 0.99";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/energydis0001";
	texture[1] = "skins/energydis0002";
	texture[2] = "skins/energydis0003";
	texture[3] = "skins/energydis0002";

	framesPerSec = 8;
	numFrames = 4;
	scrollSpeed = 0;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(BlueBarrier)
{
	fadeMS           = 2000;
	baseTranslucency = 1;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.0 0.15 0.7";
	powerOffColor    = "0.0 0.0 0.0";
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/swolf.switch.png";
	framesPerSec = 1;
	numFrames = 1;
	scrollSpeed = 1;
	umapping = 0.045;
	vmapping = -0.045;
};

datablock ForceFieldBareData(OccupiedSimonSaysSquare)
{
	fadeMS           = 300;
	baseTranslucency = 1.0;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "1.0 1.0 1.0";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/energydis0003";

	framesPerSec = 0;
	numFrames = 1;
	scrollSpeed = 0;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(IndicatedSimonSaysSquare)
{
	fadeMS           = 100;
	baseTranslucency = 0.60;
	powerOffTranslucency = 0.0;
	teamPermiable    = true;
	otherPermiable   = true;
	color            = "0.8 0.8 0.8";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/noise";

	framesPerSec = 0;
	numFrames = 1;
	scrollSpeed = 10;
	umapping = 0.6;
	vmapping = 0.6;
};

datablock ForceFieldBareData(BaseSimonSaysSquare)
{
	fadeMS           = 1000;
	baseTranslucency = 0.15;
	powerOffTranslucency = 0.0;
	teamPermiable    = false;
	otherPermiable   = false;
	color            = "0.6 0.6 0.6";
	powerOffColor    = "0.0 0.0 0.0";
	targetNameTag    = 'Force Field';
	targetTypeTag    = 'ForceField';

	texture[0] = "skins/NexDefaultFloor";

	framesPerSec = 0;
	numFrames = 1;
	scrollSpeed = 0;
	umapping = 1.0;
	vmapping = 1.0;
};

//--------------------------------------------------------------------------
// Sparks
//--------------------------------------------------------------------------

datablock ParticleData(DrillSparks)
{
	dragCoefficient      = 1;
	gravityCoefficient   = 0.0;
	inheritedVelFactor   = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS           = 300;
	lifetimeVarianceMS   = 40;
	textureName          = "special/blueSpark";
	colors[0]     = "0.9 0.4 0.3 1.0";
	colors[1]     = "0.9 0.3 0.3 1.0";
	colors[2]     = "0.8 0.8 1.0 0.0";
	sizes[0]      = 0.45;
	sizes[1]      = 0.18;
	sizes[2]      = 0.3;
	times[0]      = 0.0;
	times[1]      = 0.5;
	times[2]      = 1.0;
};

datablock ParticleEmitterData(DrillSparksEmitter)
{
	ejectionPeriodMS = 4;
	periodVarianceMS = 2;
	ejectionVelocity = 7;
	velocityVariance = 3;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 180;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	orientParticles  = true;
	particles = "DrillSparks";
};

//--------------------------------------------------------------------------
// Exploding Rock
//--------------------------------------------------------------------------

datablock BombProjectileData(ExplodingRock)
{
	projectileShapeName  = "bomb.dts";
	emitterDelay         = -1;
	directDamage         = 0.0;
	hasDamageRadius      = true;
	indirectDamage       = 1.2;
	damageRadius         = 40;
	radiusDamageType     = $DamageType::ExplodingRock;
	kickBackStrength     = 2500;

	explosion            = "VehicleBombExplosion";
	velInheritFactor     = 1.0;

	grenadeElasticity    = 0.25;
	grenadeFriction      = 0.4;
	armingDelayMS        = 250;
	muzzleVelocity       = 0.1;
	drag                 = 0.3;

	minRotSpeed          = "60.0 0.0 0.0";
	maxRotSpeed          = "80.0 0.0 0.0";
	scale                = "1.0 1.0 1.0";
};

//--------------------------------------------------------------------------
// drill turret base
//--------------------------------------------------------------------------

datablock SensorData(DrillBaseSensorObj)
{
	detects = false;
	detectsUsingLOS = false;
	detectsPassiveJammed = false;
	detectsActiveJammed = false;
	detectsCloaked = false;
	detectionPings = false;
	detectRadius = 200;
};

datablock TurretData(DrillBaseLarge) : TurretDamageProfile
{
	className      = DrillBase;
	catagory       = "Turrets";
	shapeFile      = "turret_base_large.dts";
	preload        = true;

	mass           = 1.0;  // Not really relevant

	maxDamage      = 2.45;
	destroyedLevel = 2.45;
	disabledLevel  = 1.85;
	explosion      = TurretExplosion;
	expDmgRadius = 15.0;
	expDamage = 0.66;
	expImpulse = 2000.0;
	repairRate     = 0;
	emap = true;

	thetaMin = 15;
	thetaMax = 140;

	isShielded           = true;
	energyPerDamagePoint = 30;
	maxEnergy = 230;
	rechargeRate = 0.33;
	humSound = SensorHumSound;
	pausePowerThread = true;

	canControl = false;
	cmdCategory = "Tactical";
	cmdIcon = CMDTurretIcon;
	cmdMiniIconName = "commander/MiniIcons/com_turretbase_grey";
	targetNameTag = 'Laser';
	targetTypeTag = 'Drill';
	sensorData = DrillBaseSensorObj;
	sensorRadius = DrillBaseSensorObj.detectRadius;
	sensorColor = "30 30 180";

	firstPersonOnly = true;

	debrisShapeName = "debris_generic.dts";
	debris = TurretDebris;
};

//--------------------------------------------------------------------------
// Sounds and feedback effects
//--------------------------------------------------------------------------

datablock EffectProfile(DrillSwitchEffect)
{
   effectname = "powered/turret_heavy_activate";
   minDistance = 2.5;
   maxDistance = 5.0;
};

datablock EffectProfile(DrillFireEffect)
{
   effectname = "misc/downloading";
   minDistance = 2.5;
   maxDistance = 5.0;
};

datablock EffectProfile(DrillBeamEffect)
{
   effectname = "misc/downloading";
   minDistance = 2.5;
   maxDistance = 5.0;
};

datablock AudioProfile(DrillSwitchSound)
{
   filename    = "fx/powered/turret_heavy_activate.wav";
   description = AudioClose3d;
   preload = true;
   effect = DrillSwitchEffect;
};

datablock AudioProfile(DrillFireSound)
{
   filename    = "fx/misc/downloading.wav";
   description = AudioDefaultLooping3d;
   preload = true;
   effect = DrillFireEffect;
};

datablock AudioProfile(DrillBeamSound)
{
   filename    = "fx/misc/downloading.wav";
   description = ClosestLooping3d;
   preload = true;
   effect = DrillBeamEffect;
};

//--------------------------------------------------------------------------
// Explosion
//--------------------------------------------------------------------------

datablock ParticleData(DrillExplosionParticle1)
{
	dragCoefficient      = 0.45;
	gravityCoefficient   = 0.3;
	inheritedVelFactor   = 0.0;
	constantAcceleration = 0.0;
	lifetimeMS           = 700;
	lifetimeVarianceMS   = 150;
	textureName          = "particleTest";
	colors[0]     = "0.46 0.26 0.26 0.9";
	colors[1]     = "0.36 0.26 0.26 0.4";
	sizes[0]      = 0.0625;
	sizes[1]      = 0.2;
};

datablock ParticleEmitterData(DrillExplosionEmitter)
{
	ejectionPeriodMS = 10;
	periodVarianceMS = 3;
	ejectionVelocity = 0.85;
	velocityVariance = 0.25;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 60;
	phiReferenceVel  = 0;
	phiVariance      = 360;
	overrideAdvances = false;
	particles = "DrillExplosionParticle1";
};

datablock ExplosionData(DrillExplosion)
{
	explosionShape = "energy_explosion.dts";
	soundProfile   = "";

	particleEmitter = DrillExplosionEmitter;
	particleDensity = 230;
	particleRadius = 0.85;

	faceViewer           = false;
};

//--------------------------------------------------------------------------
// Beam
//--------------------------------------------------------------------------

datablock TracerProjectileData(DrillBeam)
{
	doDynamicClientHits = true;

	//projectileShapeName = "energy_bolt.dts";
	projectileShapeName = "chaingun_shot.dts";
	directDamage		= 0.85;
	damageRadius        = 0.0;
	velInheritFactor    = 1.0;
	directDamageType	= $DamageType::LaserDrillBeam;
	sound				= DrillBeamSound;
	explosion           = "BlasterExplosion";
	//splash              = ChaingunSplash;
	splash              = SniperSplash;

	dryVelocity       = 200.0;
	wetVelocity       = 200.0;
	fizzleTimeMS      = 6000;
	lifetimeMS        = 6000;
	explodeOnDeath    = false;
	reflectOnWaterImpactAngle = 0.0;
	explodeOnWaterImpact      = false;
	deflectionOnWaterImpact   = 0.0;
	fizzleUnderwaterMS        = 6000;

	tracerLength    = 12;
	tracerAlpha     = false;
	tracerMinPixels = 3;
	tracerColor     = "0.9 0.2 0.2 0.9";
	tracerTex[0]     = "special/flareSpark";
	tracerTex[1]     = "special/redflare";
	tracerWidth     = 1.80;
	crossSize       = 1.95;
	crossViewAng    = 0.930;
	renderCross     = true;
	emap = true;
};


//--------------------------------------------------------------------------
// Turret
//--------------------------------------------------------------------------

datablock TurretImageData(DrillBarrelLarge)
{
	shapeFile = "turret_elf_large.dts";

	projectileType = TracerProjectile;
	projectile = DrillBeam;
	deleteLastProjectile = false;
	usesEnergy = true;
	fireEnergy = 0.1;
	minEnergy = 0.1;
	emap = true;

	// Turret parameters
	activationMS         = 750;
	deactivateDelayMS    = 250;
	thinkTimeMS          = 32;
	degPerSecTheta       = 200;
	degPerSecPhi         = 580;
	attackRadius         = 200;
	minTargetingDistance	= 25;

	// State transitions
	stateName[0]                        = "Activate";
	stateTransitionOnNotLoaded[0]       = "Dead";
	stateTransitionOnLoaded[0]          = "ActivateReady";

	stateName[1]                        = "ActivateReady";
	stateSequence[1]                    = "Activate";
	stateSound[1]                       = DrillSwitchSound;
	stateTimeoutValue[1]                = 1.0;
	stateTransitionOnTimeout[1]         = "Ready";
	stateTransitionOnNotLoaded[1]       = "Deactivate";
	stateTransitionOnNoAmmo[1]          = "NoAmmo";

	stateName[2]                        = "Ready";
	stateTransitionOnNotLoaded[2]       = "Deactivate";
	stateTransitionOnTriggerDown[2]     = "Fire";
	stateTransitionOnNoAmmo[2]          = "NoAmmo";

	stateName[3]                        = "Fire";
	stateTransitionOnTimeout[3]			= "Fire";
	stateTimeoutValue[3]				= 0.10;
	stateFire[3]                        = true;
	stateRecoil[3]                      = LightRecoil;
	stateAllowImageChange[3]            = false;
	stateSequence[3]                    = "Fire";
	stateSound[3]                       = DrillFireSound;
	stateScript[3]                      = "onFire";
	stateTransitionOnNotLoaded[3]		= "Deactivate";
	stateTransitionOnNoAmmo[3]			= "NoAmmo";

	stateName[4]                        = "Deactivate";
	stateSequence[4]                    = "Activate";
	stateDirection[4]                   = false;
	stateTimeoutValue[4]                = 1;
	stateTransitionOnLoaded[4]          = "ActivateReady";
	stateTransitionOnTimeout[4]         = "Dead";

	stateName[5]                        = "Dead";
	stateTransitionOnLoaded[5]          = "ActivateReady";

	stateName[6]                        = "NoAmmo";
	stateTransitionOnAmmo[6]            = "Fire";
	stateSequence[6]                    = "NoAmmo";

	stateName[7]                       = "Deconstruction";
	stateScript[7]                     = "deconstruct";
	stateTransitionOnNoAmmo[7]         = "NoAmmo";
	stateTransitionOnTimeout[7]        = "Fire";
	stateTimeoutValue[7]               = 0.1;
};

//--------------------------------------------------------------------------
// teleporter scripting
//--------------------------------------------------------------------------

datablock StaticShapeData(ShaftedTeleporter) : StaticShapeDamageProfile
{
	className = Station;
	catagory = "Stations";
	shapeFile = "station_teleport.dts";
	maxDamage = 1.20;
	destroyedLevel = 1.20;
	disabledLevel = 0.84;
	explosion = ShapeExplosion;
	expDmgRadius = 10.0;
	expDamage = 0.4;
	expImpulse = 1500.0;
	dynamicType = $TypeMasks::StationObjectType;
	isShielded = true;
	energyPerDamagePoint = 33;
	maxEnergy = 250;
	rechargeRate = 0.31;
	humSound = StationVehicleHumSound;
	// don't let these be damaged in Siege missions
	noDamageInSiege = true;
	cmdCategory = "Support";
	cmdIcon = CMDVehicleStationIcon;
	cmdMiniIconName = "commander/MiniIcons/com_vehicle_pad_inventory";
	targetNameTag = 'Underground Base';
	targetTypeTag = 'Teleport Station';
	teleporter = 1;
};

datablock ParticleData(ShaftedTeleportParticle)
{
	dragCoefficient = 1.5;
	gravityCoefficient = 0.2;
	inheritedVelFactor = 0.2;
	constantAcceleration = 0.0;
	lifetimeMS = 1000;
	lifetimeVarianceMS = 0;
	textureName = "particleTest";

	colors[0] = "0.06 0.06 0.36 1.0";
	colors[1] = "0.06 0.06 0.36 0.0";
	sizes[0] = 0.65;
	sizes[1] = 0.30;
};

datablock ParticleEmitterData(ShaftedTeleportEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 1.1;
	velocityVariance = 1.0;
	ejectionOffset = 2.0;
	thetaMin = 0.0;
	thetaMax = 10.0;
	phiReferenceVel = 0.0;
	phiVariance = 360.0;
	overrideAdvances = false;
	particles = "ShaftedTeleportParticle";
};


//--------------------------------------------------------------------------
// code goes below
//--------------------------------------------------------------------------


package Shafted
{


function SiegeGame::missionLoadDone(%game)
{
	// add forcefield platforms and indicators
	%game.findForceFields();

	// always allow atfadmin base rape
	$Shafted::oldBaseRapeToggleValue = $atfadmin::AllowAdminToggleBaseRape;
	$Shafted::oldAlwaysAllowBaseRapeValue = $atfadmin_alwaysAllowBaseRape;
	$atfadmin::AllowAdminToggleBaseRape = false;
	$atfadmin_alwaysAllowBaseRape = true;

	// call the original function
	Parent::missionLoadDone(%game);

	// reset our map scripting
	setupMapStuff();

	// fill the tunnel with rocks
	fillTunnelWithRocks();
}

function SiegeGame::halftime(%game, %reason)
{
	// stop drilling
	cancel(%game.drillCheck);

	// call the original function
	Parent::halftime(%game, %reason);
}

function SiegeGame::halftimeOver(%game)
{
	// add forcefield platforms and indicators
	%game.findForceFields();

	// reset our map scripting
	setupMapStuff();

	// reset the defensive spawnspheres
	nameToId("RemoteBaseSpawn").sphereWeight = 100;
	nameToId("UndergroundBaseSpawn1").sphereWeight = 0;
	nameToId("UndergroundBaseSpawn2").sphereWeight = 0;
	nameToId("UndergroundBaseSpawn3").sphereWeight = 0;

	// move all the rocks back to their original position
	resetRocks();

	// call the original function
	Parent::halftimeOver(%game);

	// toggle the waypoints
	toggleWaypoints();
}

function setupMapStuff()
{
	//disableAssets("UGMainGenerator1 UGMainGenerator2 AuxGenerator LaserDrill DrillGenerator EastSolarPanel WestSolarPanel TunnelSolarPanel");
	disableAssets("LaserDrill DrillGenerator EastSolarPanel WestSolarPanel TunnelSolarPanel");

	%drill = nameToId("LaserDrill");

	// drill hasn't toggled any waypoints yet
	%drill.toggledWaypoints = false;

	// no drill beam strength yet
	%drill.drillBeamStrength = 0;

	// start the drilling thread
	Game.drillCheck = schedule(1000, 0, drillCheck);
}

function disableAssets(%objects)
{
	for (%i = 0; %i < getWordCount(%objects); %i++)
	{
		%object = getWord(%objects, %i);
		%object.setDamageLevel(2.5);
	}
}

function drillCheck()
{
	%drill = nameToId("LaserDrill");

	if (%drill.isPowered() && %drill.isEnabled() && isObject(%drill.rockTarget))
	{
		%drill.damageInflicted += %drill.drillBeamStrength * 0.01;
		if (%drill.damageInflicted >= %drill.damageToInflict)
		{
			destroyDrillBeamTarget();
		}
	}

	Game.drillCheck = schedule(1000, 0, drillCheck);
}

function resetRocks()
{
	%group = nameToId("MissionGroup/Teams/Team0/ShaftedRocks");

	for (%i = 0; %i < %group.getCount(); %i++)
	{
		%rock = %group.getObject(%i);

		if (%rock.moved == true)
		{
			// only move this rock if it is out of position
			moveRock(%rock, true);
		}
	}
}

function moveRock(%rock, %direction)
{
	switch (%direction)
	{
		case true:
			// move the rock up
			%rock.position = getWords(%rock.position, 0, 1) SPC getWord(%rock.position, 2) + 200;
			%rock.setTransform(%rock.getTransform());

		case false:
			// move the rock down
			%rock.position = getWords(%rock.position, 0, 1) SPC getWord(%rock.position, 2) - 200;
			%rock.setTransform(%rock.getTransform());
	}

	// toggle the "moved" flag
	%rock.moved = (%rock.moved == true) ? false : true;
}

function fillTunnelWithRocks()
{
	// hardcode the rocks here
	// add all rocks to the MissionCleanup/ShaftedRocks group

	%group = new SimGroup("ShaftedRocks");
	nameToId("MissionGroup/Teams/Team0").add(%group);

	%rock = new InteriorInstance() {
		position = "-197.328 -449.426 54.0638";
		rotation = "0.856182 0.491334 -0.159823 85.2643";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-192.605 -454.153 55.9061";
		rotation = "0.952122 0.286729 0.106065 70.8992";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-201.487 -460.395 58.0105";
		rotation = "0.823623 -0.420552 -0.380502 49.3866";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-196.822 -469.348 65.6604";
		rotation = "0.0299621 -0.324116 0.945543 132.659";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-204.281 -470.301 68.7163";
		rotation = "0.424236 0.590131 0.686855 105.028";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-200.267 -485.963 82.5378";
		rotation = "0.117179 0.598672 0.792377 141.952";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-197.752 -501.144 93.5689";
		rotation = "0.310111 0.251219 0.916908 123.853";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-208.799 -510.1 103.125";
		rotation = "0.155367 0.0600421 0.986031 178.048";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-198.098 -516.915 110.545";
		rotation = "0.450694 -0.0386856 0.89184 235.997";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-197.883 -534.081 122.242";
		rotation = "0.714659 0.436188 -0.546811 111.664";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-206.986 -542.516 129.096";
		rotation = "-0.066193 -0.426993 0.901829 198.995";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-201.42 -555.025 136.842";
		rotation = "0.389918 -0.044759 0.919761 180.927";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-199.283 -565.151 149.495";
		rotation = "0.377066 0.230375 0.897078 167.658";
		scale = "4 4 4";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-193.388 -542.291 128.867";
		rotation = "0.226506 -0.451972 0.862795 182.25";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-203.825 -530.847 115.482";
		rotation = "0 0 -1 33.8045";
		scale = "3 3 3";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
	%rock = new InteriorInstance() {
		position = "-192.073 -529.318 114.506";
		rotation = "0.527872 0.160402 -0.83404 40.0365";
		scale = "2 2 2";
		interiorFile = "srock7.dif";
		showTerrainInside = "0";
	};
	%group.add(%rock);
}

function destroyDrillBeamTarget()
{
	%drill = nameToId("LaserDrill");
	stopDrillEffect();

	%bomb = new BombProjectile()
	{
		dataBlock = "ExplodingRock";
		initialPosition = %drill.rockTarget.getWorldBoxCenter();
		initialDirection = "0 0 -50";
		rotation = "1 0 0 0";
	};

	Game.rockRemovalThread = schedule(350, 0, "blowupRock");
	%drill.realTarget.delete();

	%drill.damageToInflict = 0;
	%drill.damageInflicted = 0;
}

function blowupRock()
{
	%drill = nameToId("LaserDrill");
	moveRock(%drill.rockTarget, false);
	%drill.rockTarget = -1;
}

function toggleWaypoints()
{
	if (Game.waypointsToggled == false)
	{
		deleteWaypoints("DrillGenerator EastSolarPanel WestSolarPanel LaserDrill");
		addWaypoints("UGMainGenerator1 UGMainGenerator2 AuxGenerator Switch", false);
		//addWaypoints("Switch", false);
		Game.waypointsToggled = true;
	}
	else
	{
		deleteWaypoints("UGMainGenerator1 UGMainGenerator2 AuxGenerator Switch");
		addWaypoints("DrillGenerator EastSolarPanel WestSolarPanel LaserDrill", true);
		Game.waypointsToggled = false;
	}
}

function deleteWaypoints(%objects)
{
	for (%i = 0; %i < getWordCount(%objects); %i++)
	{
		%object = getWord(%objects, %i);
		if (isObject(%object.waypoint))
		{
			%object.waypoint.delete();
			%object.needsObjectiveWaypoint = "0";
		}
	}
}

function addWaypoints(%objects, %toggle)
{
	// set the "needsObjectiveWaypoint" to "1"
	// for every object in the list
	for (%i = 0; %i < getWordCount(%objects); %i++)
	{
		%object = getWord(%objects, %i);
		if (isObject(%object))
		{
			%object.needsObjectiveWaypoint = "1";
		}
	}

	// add the actual waypoints
	Game.findObjectiveWaypoints();

	// if toggle is requested, then switch the waypoints
	if (%toggle)
	{
		schedule(0, 0, switchWaypointTeam, %objects);
	}
}

function switchWaypointTeam(%objects)
{
	// toggle the team of some waypoints
	// we do this if an objective is initially "down"
	for (%i = 0; %i < getWordCount(%objects); %i++)
	{
		%object = getWord(%objects, %i);
		if (isObject(%object) && %object.waypoint)
		{
			Game.switchWaypoint(%object.waypoint);
		}
	}
}

function Generator::onEnabled(%data, %obj, %prevState)
{
	Parent::onEnabled(%data, %obj, %prevState);

	%drill = nameToId("LaserDrill");

	switch (%obj)
	{
		case nameToId("DrillGenerator"):
			%drill.drillBeamStrength += 40;

		case nameToId("EastSolarPanel"):
			%drill.drillBeamStrength += 30;

		case nameToId("WestSolarPanel"):
			%drill.drillBeamStrength += 30;

		default:
			return;
	}

	// tell everyone the current strength of the drill beam
	if (!%drill.toggledWaypoints && $MatchStarted)
	{
		announceDrillPower();
	}
}

function Generator::onDisabled(%data, %obj)
{
	Parent::onDisabled(%data, %obj);

	%drill = nameToId("LaserDrill");

	switch (%obj)
	{
		case nameToId("DrillGenerator"):
			%drill.drillBeamStrength -= 40;

		case nameToId("EastSolarPanel"):
			%drill.drillBeamStrength -= 30;

		case nameToId("WestSolarPanel"):
			%drill.drillBeamStrength -= 30;

		default:
			return;
	}

	// tell everyone the current strength of the drill beam
	if (!%drill.toggledWaypoints && $MatchStarted)
	{
		announceDrillPower();
	}
}

function announceDrillPower()
{
	messageAll('MsgDrillPower', '\c1Drill power now at %1%%.', nameToId("LaserDrill").drillBeamStrength);
}

function MobileBaseVehicle::onAdd(%this, %obj)
{
	Parent::onAdd(%this, %obj);

	// add a beacon to each MPB
	%obj.beacon = new BeaconObject() {
		dataBlock = "DeployedBeacon";
		position = %obj.position;
		rotation = %obj.rotation;
		team = %obj.team;
	};
	%obj.beacon.setBeaconType(friend);
	%obj.beacon.setTarget(%obj.team);
}

function SiegeGame::displayDeathMessages(%game, %clVictim, %clKiller, %damageType, %implement)
{
	%victimGender = (%clVictim.sex $= "Male" ? 'him' : 'her');
	%victimPoss = (%clVictim.sex $= "Male" ? 'his' : 'her');
	%killerGender = (%clKiller.sex $= "Male" ? 'him' : 'her');
	%killerPoss = (%clKiller.sex $= "Male" ? 'his' : 'her');
	%victimName = %clVictim.name;
	%killerName = %clKiller.name;

	if (%damageType == $DamageType::ExplodingRock)
	{
		messageAll('msgExplosionKill', $DeathMessageExplodingRock[mFloor(getRandom() * $DeathMessageExplodingRockCount)], %victimName, %victimGender, %victimPoss, %killerName, %killerGender, %killerPoss, %damageType, $DamageTypeText[%damageType]);
		logEcho(%clVictim.nameBase@" (pl "@%clVictim.player@"/cl "@%clVictim@") killed by an exploding rock.");
	}
	else if (%damageType == $DamageType::LaserDrillBeam)
	{
		messageAll('msgCTurretKill', $DeathMessageLaserDrillBeam[mFloor(getRandom() * $DeathMessageLaserDrillBeamCount)], %victimName, %victimGender, %victimPoss, %killerName, %killerGender, %killerPoss, %damageType, $DamageTypeText[%damageType]);
		logEcho(%clVictim.nameBase@" (pl "@%clVictim.player@"/cl "@%clVictim@") killed by a laser drill beam.");
	}
	else
	{
		Parent::displayDeathMessages(%game, %clVictim, %clKiller, %damageType, %implement);
	}
}

function TurretData::selectTarget(%this, %turret)
{
	%turretTarg = %turret.getTarget();
	if (%turretTarg == -1)
		return;

	// if the turret isn't on a team, don't fire at anyone
	if (getTargetSensorGroup(%turretTarg) == 0)
	{
		%turret.clearTarget();
		return;
	}

	// stop firing if turret is disabled or if it needs power and isn't powered
	if ((!%turret.isPowered()) && (!%turret.needsNoPower))
	{
		%turret.clearTarget();
		return;
	}

	switch$ (%turret.getMountedImage(0).getName())
	{
		case "DrillBarrelLarge":
			%TargetSearchMask = $TypeMasks::InteriorObjectType | $TypeMasks::VehicleObjectType;
		default:
			%TargetSearchMask = $TypeMasks::PlayerObjectType;
	}

	InitContainerRadiusSearch(%turret.getMuzzlePoint(0), %turret.getMountedImage(0).attackRadius, %TargetSearchMask);

	switch$ (%turret.getMountedImage(0).getName())
	{
		case "DrillBarrelLarge":
			while ((%potentialTarget = ContainerSearchNext()) != 0)
			{
				if (%potentialTarget.interiorFile $= "srock7.dif" && !isObject(%turret.rockTarget))
				{
					// we have a rock in range, let's draw a line
					// from the turret to the rock
					%mask = $TypeMasks::InteriorObjectType;
					%searchResult = containerRayCast(%turret.getMuzzlePoint(0), %potentialTarget.getWorldBoxCenter(), %mask, %turret);

					if (%searchResult)
					{
						// get the point where the beam will strike
						%terrPt = posFromRaycast(%searchResult);
						%terrNrm = normalFromRaycast(%searchResult);

						// choose an axis perpendicular to the rock surface
						%intAngle = getTerrainAngle(%terrNrm);
						%rotAxis = vectorNormalize(vectorCross(%terrNrm, "0 0 1"));
						if (getWord(%terrNrm, 2) == 1 || getWord(%terrNrm, 2) == -1)
							%rotAxis = vectorNormalize(vectorCross(%terrNrm, "0 1 0"));
						%rotation = %rotAxis @ " " @ %intAngle;
						%position = VectorAdd(%terrPt, VectorScale(%terrNrm, 0.05));

						// what team should the bike be on?
						%team = (Game.offenseTeam == 1) ? 2 : 1;
						%group = nameToId("MissionGroup/Teams/Team" @ %team);

						// create the "real" target for the turret: a wildcat
						%obj = new HoverVehicle(BLOWMEUP)
						{
							dataBlock = "ScoutVehicle";
							position = %position;
							rotation = %rotation;
							scale = "1 1 1";
							team = %team;
							disableMove = "1";	// prevent it from moving
							mountable = "0";	// prevent it from being mounted
						};
						%group.add(%obj);

						// make the wildcat invisible
						%obj.setCloaked(true);
						%obj.setTarget(%team);

						Game.drillEffectThread = schedule(%turret.getMountedImage(0).activationMS + 450, 0, "startDrillEffect", %terrPt, %rotation);

						// how much "damage" will we need to inflict
						// before the rock will "blow up"?
						%turret.damageToInflict = 10;

						%turret.rockTarget = %potentialTarget;
						%turret.realTarget = %obj;
					}
					return;
				}
				else if (%potentialTarget.interiorFile $= "" && isObject(%turret.rockTarget))
				{
					%turret.setTargetObject(%potentialTarget);
					return;
				}
			}
			
			// no rocks found, time to switch the waypoints
			if (!%turret.toggledWaypoints)
			{
				toggleWaypoints();
				messageAll('MsgNextPhaseStarted', '\c1The underground base is now accessible.~wfx/misc/warning_beep.wav');
				%turret.toggledWaypoints = true;
				nameToId("RemoteBaseSpawn").sphereWeight = 0;
				nameToId("UndergroundBaseSpawn1").sphereWeight = 40;
				nameToId("UndergroundBaseSpawn2").sphereWeight = 30;
				nameToId("UndergroundBaseSpawn3").sphereWeight = 30;
			}

		default:
			while ((%potentialTarget = ContainerSearchNext()) != 0)
			{
				%potTargTarg = %potentialTarget.getTarget();
				if (%turret.isValidTarget(%potentialTarget) && (getTargetSensorGroup(%turretTarg) != getTargetSensorGroup(%potTargTarg)))
				{
					%turret.setTargetObject(%potentialTarget);
					return;
				}
			}
	}
}

function phaseSwitch(%toggle)
{
	if (!%toggle)
	{
		toggleWaypoints();
		messageAll('MsgNextPhaseStarted', '\c1The underground base is now accessible.~wfx/misc/warning_beep.wav');
		%turret.toggledWaypoints = true;
		nameToId("RemoteBaseSpawn").sphereWeight = 0;
		nameToId("UndergroundBaseSpawn1").sphereWeight = 40;
		nameToId("UndergroundBaseSpawn2").sphereWeight = 30;
		nameToId("UndergroundBaseSpawn3").sphereWeight = 30;
	}
	else
	{
		toggleWaypoints();
		%turret.toggledWaypoints = false;
		nameToId("RemoteBaseSpawn").sphereWeight = 100;
		nameToId("UndergroundBaseSpawn1").sphereWeight = 0;
		nameToId("UndergroundBaseSpawn2").sphereWeight = 0;
		nameToId("UndergroundBaseSpawn3").sphereWeight = 0;
	}
}

function startDrillEffect(%position, %rotation)
{
	%drill = nameToId("LaserDrill");
	%drill.effectsPosition = %position;
	%drill.effectsRotation = %rotation;

	// create the drilling sparks
	%drill.sparksEmitter = new particleEmissionDummy(Sparks)
	{
		position = %position;
		rotation = %rotation;
		scale = "1 1 1";
		dataBlock = "defaultEmissionDummy";
		emitter = "DrillSparksEmitter";
		velocity = "1";
	};

	// create the drilling smoke
	%drill.smokeEmitter = new ParticleEmissionDummy(Smoke)
	{
		position = %position;
		rotation = "1 0 0 0";
		scale = "1 1 1.6";
		dataBlock = "doubleTimeEmissionDummy";
		emitter = "SmallHeavyDamageSmoke";
		velocity = "1";
	};
}

function stopDrillEffect()
{
	%drill = nameToId("LaserDrill");

	// delete the drilling sparks
	if (isObject(%drill.sparksEmitter))
	{
		%drill.sparksEmitter.delete();
	}

	// delete the drilling smoke
	if (isObject(%drill.smokeEmitter))
	{
		%drill.smokeEmitter.delete();
	}
}

function TurretData::onDisabled(%data, %obj)
{
	Parent::onDisabled(%data, %obj);

	if (%obj.dataBlock $= "DrillBaseLarge")
	{
		stopDrillEffect();
	}
}

function TurretData::onEnabled(%data, %obj)
{
	Parent::onEnabled(%data, %obj);

	if (%obj.dataBlock $= "DrillBaseLarge")
	{
		%drill = nameToId("LaserDrill");
		if (isObject(%drill.rockTarget))
		{
			startDrillEffect(%drill.effectsPosition, %drill.effectsRotation);
		}
	}
}

function TurretData::onLosePowerDisabled(%data, %obj)
{
	Parent::onLosePowerDisabled(%data, %obj);

	if (%obj.dataBlock $= "DrillBaseLarge")
	{
		stopDrillEffect();
	}
}

function VehicleData::damageObject(%data, %targetObject, %sourceObject, %position, %amount, %damageType, %momVec, %theClient, %proj)
{
	// make grav bikes invincible
	// this is so our turret won't accidentally destroy
	// our invisible grav bike
	if (%data.getName() $= "mobileBaseVehicle")
	{
		Parent::damageObject(%data, %targetObject, %sourceObject, %position, %amount, %damageType, %momVec, %theClient, %proj);
	}
}

function SiegeGame::gameOver(%game)
{
	// cancel background threads
	cancel(%game.drillCheck);
	cancel(%game.drillEffectThread);
	cancel(%game.rockRemovalThread);

	// remove the sparks
	%drill = nameToId("LaserDrill");

	// stop the effects
	stopDrillEffect();

	// reset the forcefield::onAdd func
	exec("scripts/forceField.cs");

	// reset atfadmin base rape values
	$atfadmin::AllowAdminToggleBaseRape = $Shafted::oldBaseRapeToggleValue;
	$atfadmin_alwaysAllowBaseRape = $Shafted::oldAlwaysAllowBaseRapeValue;
	deleteVariables("$Shafted::*");

	// call the parent
	Parent::gameOver(%game);

	// forget this code ever existed
	deactivatePackage(Shafted);
}

//
// findForceFields
//

// finds all forcefields in a simgroup

function SiegeGame::findForceFields(%game, %group)
{
	// if no group argument is given, then
	// assume we're checking the Teams SimGroup
	if (!%group)
		%group = nameToId("MissionGroup/Teams");

	// iterate through all objects in the simgroup
	for (%i = 0; %i < %group.getCount(); %i++)
	{
		// get the next object
		%obj = %group.getObject(%i);

		// if the object is another simgroup,
		// call this function again to iterate
		// through it (this is a recursive call)
		if (%obj.getClassName() $= SimGroup)
			%game.findForceFields(%obj);

		else if (%obj.needsForceFieldTrigger $= "1" && %obj.getClassName() $= ForceFieldBare)
		{
			// if the needsForceFieldTrigger property is set to "1"
			// and the object we found is a forcefield, then:

			// add the forcefield trigger object
			%game.addForceFieldTrigger(%obj);

			// add a forcefield platform
			%game.addPlatform(%obj);

			// associate this forcefield with a barrier forcefield
			%game.addBarrier(%obj);
		}
	}
}

//
// addForceFieldTrigger
//

// adds a forcefieldtrigger to an existing forcefield

function SiegeGame::addForceFieldTrigger(%game, %forcefield)
{
	// note that %forcefield should be a forcefield

	// sanity check:
	// if the object passed in the %forcefield argument
	// doesn't have the needsForceField trigger
	// property set, then bail out
	if (%forcefield.needsForceFieldTrigger !$= "1")
		return;

	// sanity check:
	// if the object passed in the %forcefield argument
	// isn't a forcefield, then bail out
	if (%forcefield.getClassName() !$= ForceFieldBare)
		return;

	// create a new trigger object
	// and make the object a property of
	// the forcefield itself, using the
	// same position and rotation of the
	// existing forcefield, the same team
	// as the existing forcefield, and the
	// same x and y coordinates,
	// but make the height (z)
	// 1 meter higher than the forcefield
	// itself
	%forcefield.trigger = new Trigger()
	{
		position = %forcefield.position;
		rotation = %forcefield.rotation;
		scale    = getWord(%forcefield.scale, 0) SPC getWord(%forcefield.scale, 1) SPC getWord(%forcefield.scale, 2) + 1;
		dataBlock = ForceFieldTrigger; // use the trigger datablock defined at the top of this file
		polyhedron = "0 1 0 1 0 0 0 -1 0 0 0 1"; // default box shape
		team = %forcefield.team;
	};

	// add this object to the missioncleanup group
	// so that it will be automatically deleted when
	// the mission is over
	MissionCleanup.add(%forcefield.trigger);

	// set the trigger's owner to be
	// the forcefield (handy for the
	// functions below)
	%forcefield.trigger.owner = %forcefield;

	// indicate that no one is currently in the
	// trigger zone
	%forcefield.trigger.Fcount = 0;
}

//
// addPlatform
//

// adds a forcefield "platform" to an existing forcefield

function SiegeGame::addPlatform(%game, %forcefield)
{
	// sanity check:
	// if the object passed in the %forcefield argument
	// isn't a forcefield, then bail out
	if (%forcefield.getClassName() !$= ForceFieldBare)
		return;

	// create a new forcefield "platform" as
	// a property of the forcefield itself...
	// this new forcefield exists in the
	// same exact space as the original
	// forcefield, but uses a different
	// datablock than the original (to show
	// a visible change)
	%forcefield.platform = new ForceFieldBare()
	{
		position = %forcefield.position;
		rotation = %forcefield.rotation;
		scale = %forcefield.scale;
		dataBlock = "OccupiedSimonSaysSquare";
		team = %forcefield.team;
	};

	// add this object to the missioncleanup group
	// so that it will be automatically deleted when
	// the mission is over
	MissionCleanup.add(%forcefield.platform);

	// set the platform's "owner" to
	// be the original forcefield
	%forcefield.platform.owner = %forcefield;

	// make the platform "invisible" by powering
	// it off until the trigger activates it
	%forcefield.platform.getDatablock().losePower(%forcefield.platform);

	// create a new forcefield "indicator" as
	// a property of the forcefield itself.
	// this forcefield uses a different
	// datablock than the original
	%forcefield.indicator = new ForceFieldBare()
	{
		position = getWords(%forcefield.position, 0, 1) SPC getWord(%forcefield.position, 2) + 0.2;
		rotation = %forcefield.rotation;
		scale = getWords(%forcefield.scale, 0, 1) SPC getWord(%forcefield.scale, 2) + 0.2;
		dataBlock = "IndicatedSimonSaysSquare";
		team = %forcefield.team;
	};

	// add this object to the missioncleanup group
	// so that it will be automatically deleted when
	// the mission is over
	MissionCleanup.add(%forcefield.indicator);

	// set the indicator's "owner" to
	// be the original forcefield
	%forcefield.indicator.owner = %forcefield;

	// make the indicator "invisible" by powering
	// it off until the scripting activates it
	%forcefield.indicator.getDatablock().losePower(%forcefield.indicator);
}

function SiegeGame::addBarrier(%game, %forcefield)
{
	// sanity check:
	// if the object passed in the %forcefield argument
	// isn't a forcefield, then bail out
	if (%forcefield.getClassName() !$= ForceFieldBare)
		return;

	// figure out which color our ff is
	switch (%forcefield)
	{
		case nameToId("RedSquare"):
			%color = "Red";
		case nameToId("YellowSquare"):
			%color = "Yellow";
		case nameToId("GreenSquare"):
			%color = "Green";
		case nameToId("BlueSquare"):
			%color = "Blue";
		default:
			error("unknown forcefield color!");
			%color = "Unknown";
	}

	// associate this platform with a color-matched
	// forcefield barrier in the tunnel
	%forcefield.barrier = nameToId(%color @ "Field");
}

//
// ForceFieldTrigger::onEnterTrigger
//

// called when an object enters the trigger

function ForceFieldTrigger::onEnterTrigger(%data, %obj, %colObj)  
{
	// if the object is not a living player,
	// then just leave this function now
	if (%colObj.getDatablock().className !$= "Armor" || %colObj.getState() $= "Dead")
		return;

	// figure out who owns this trigger
	%forcefield = %obj.owner;

	// increment the number of players
	// that are within this trigger
	%obj.Fcount++;

	// the first player to enter the
	// trigger activates it, additional
	// players don't change the platform
	// appearance
	if (%obj.Fcount == 1)
	{
		// get the platform associated
		// with this trigger
		%platform = %forcefield.platform;

		// turn on the "platform" forcefield
		%platform.getDatablock().gainPower(%platform);
	}

	if (%colObj.team == %forcefield.team)
	{
		// the player is on defense

		// only do something if the timer isn't running
		if (%forcefield.timer $= "")
		{
			// start the timer thread and indicator
			createBarrier(%forcefield);
		}
	}
	else
	{
		// the player is on offense

		// only do something if the timer is running
		if (%forcefield.timer !$= "")
		{
			// stop the timer thread and indicator
			destroyBarrier(%forcefield);
		}
	}

	// play the "thump" sound
	%colObj.playAudio($ActivateSound, "PlatformLandSound");
}

function createBarrier(%forcefield)
{
	// figure out which "barrier" is associated with this ff
	%barrier = %forcefield.barrier;

	// turn on the barrier
	%barrier.getDatablock().gainPower(%barrier);

	// add a physical zone to the ff barrier
	addPhysicalZone(%barrier);

	// start the timer and turn on the indicator
	%forcefield.timer = schedule(0, 0, barrierTimer, %forcefield, true);
}

function destroyBarrier(%forcefield)
{
	// figure out which "barrier" is associated with this ff
	%barrier = %forcefield.barrier;

	// turn off the barrier
	%barrier.getDatablock().losePower(%barrier);

	// remove the physical zone
	removePhysicalZone(%barrier);

	// power off the indicator
	%forcefield.indicator.getDatablock().losePower(%forcefield.indicator);

	// cancel the thread
	if (isEventPending(%forcefield.timer))
	{
		cancel(%forcefield.timer);
	}

	%forcefield.timer = "";
}

function barrierTimer(%forcefield, %turnOnIndicator, %tick)
{
	%indicator = %forcefield.indicator;
	%defaultTickTime = 12;

	if (%turnOnIndicator)
	{
		// set the default barrier uptime in "ticks"
		// each tick is equal to 500ms
		%tick = %defaultTickTime;
	}

	// set the scale
	%scale = getWords(%indicator.scale, 0, 1) SPC 2 * (%tick / %defaultTickTime);
	%indicator.setScale(%scale);

	// force an update of this object
	%indicator.setTransform(%indicator.getTransform());

	if (%turnOnIndicator)
	{
		// power on the indicator
		%indicator.getDatablock().gainPower(%indicator);
	}

	// tick the counter
	%tick--;

	if (%tick > 0)
	{
		// reschedule the timer
		%forcefield.timer = schedule(500, 0, barrierTimer, %forcefield, false, %tick);
	}
	else
	{
		// time's up...
		destroyBarrier(%forcefield);
	}
}

//
// ForceFieldTrigger::onLeaveTrigger
//

// called when an object leaves the trigger
function ForceFieldTrigger::onLeaveTrigger(%data, %obj, %colObj)  
{
	// if the object is not a living player,
	// then just leave this function now
	if (%colObj.getDatablock().className !$= "Armor" || %colObj.getState() $= "Dead")
		return;

	// figure out who owns this trigger
	%forcefield = %obj.owner;

	// decrement the number of players
	// that are within the trigger
	%obj.Fcount--;

	// when the last player leaves the trigger,
	// change the "platform" and forcefield back
	// to their original states
	if (%obj.Fcount == 0)
	{
		// get the platform associated
		// with this trigger
		%platform = %forcefield.platform;

		// turn off the "platform" forcefield
		%platform.getDatablock().losePower(%platform);
	}
}

//
// ForceFieldTrigger::onTickTrigger
//

function ForceFieldTrigger::onTickTrigger(%data, %obj)
{
	// do nothing

	// NOTE: this function is called every
	// 50 milliseconds that a ForceFieldTrigger
	// is in existence (the calling period
	// can be defined in the datablock at
	// the top of this file)
}

function addPhysicalZone(%obj)
{
	// create a new physical zone
	%pz = new PhysicalZone() {
		position = %obj.position;
		rotation = %obj.rotation;
		scale    = %obj.scale;
		polyhedron = "0.000000 1.0000000 0.0000000 1.0000000 0.0000000 0.0000000 0.0000000 -1.0000000 0.0000000 0.0000000 0.0000000 1.0000000";
		velocityMod  = 0.1;
		gravityMod   = 1.0;
		appliedForce = "0 0 0";
		ffield = %obj;
	};

	// associate the new pzone with the original object
	%obj.pzone = %pz;

	// automatically clean up the pzone
	// when the game is over
	%pzGroup = nameToID("MissionCleanup/PZones");
	if (%pzGroup <= 0)
	{
		%pzGroup = new SimGroup("PZones");
		MissionCleanup.add(%pzGroup);
	}
	%pzGroup.add(%pz);
}

function removePhysicalZone(%obj)
{
	if (isObject(%obj.pzone))
	{
		%obj.pzone.delete();
		%obj.pzone = "";
	}
}

//
// teleporter functions
//

function ShaftedTeleporter::onCollision(%data, %obj, %col)
{
	if (%col.getDataBlock().className !$= "Armor" || %col.getState() $= "Dead" || %col.teleporting)
		return;

	if (isObject(%col))
	{
		if (%obj.team == %col.client.team)
		{
			if (!%obj.isDisabled())
			{
				if (%obj.isPowered())
				{
					if (nameToId("LaserDrill").toggledWaypoints)
					{
						if (!%obj.inUse)
						{
							%col.lastWeapon = (%col.getMountedImage($WeaponSlot) == 0) ? "" : %col.getMountedImage($WeaponSlot).item;
							%col.unmountImage($WeaponSlot);
							%pos = %obj.position;
							%col.setvelocity("0 0 0");
							%col.setMoveState(true);
							%rot = getWords(%col.getTransform(), 3, 6);
							%col.setTransform(getWord(%pos,0) @ " " @ getWord(%pos,1) @ " " @ getWord(%pos,2) + 0.6 @ " " @ %rot);
							%col.teleporting = 1;
							%col.startFade(1000, 0, true);
							%col.playAudio($PlaySound, StationVehicleAcitvateSound);

							%obj.inUse = true;
							%obj.setThreadDir($ActivateThread, true);
							%obj.playThread($ActivateThread, "activate");

							%data.sparkEmitter(%obj);
							%data.schedule(2000, "teleportout", %obj, %col);
							%data.schedule(3500, "teleportingDone", %obj, %col);
						}
						else
							messageClient(%col.client, 'MsgTeleportRecharging', '\c2Teleporter is recharging, please stand by.~wfx/powered/nexus_deny.wav'); 
					}
					else
						MessageClient(%col.client, 'MsgShaftBlocked', '\c2The shaft is still blocked, teleportation is not yet possible.');
				}
				else
					messageClient(%col.client, 'MsgStationNoPower', '\c2Teleporter is not powered.');
			}
			else
				messageClient(%col.client, 'MsgStationDisabled', '\c2Teleporter is disabled.');
		}
		else
			messageClient(%col.client, 'MsgStationDenied', '\c2Access Denied -- Wrong team.~wfx/powered/station_denied.wav');
	}
	else
		return;
}

function ShaftedTeleporter::teleportOut(%data, %obj, %player)
{
	// find a suitable spawn location
	// move the player
	%player.setTransform(%obj.MPB.spawnPos[%index] @ " " @ getWords(%obj.MPB.getTransform(), 3, 6));
	// "teleport" them in
	%data.schedule(1000, "teleportIn", %player);
}

function ShaftedTeleporter::teleportIn(%data, %player)
{
	%data.sparkEmitter(%player);
	%player.startFade(1000, 0, false );
	%player.playAudio($PlaySound, StationVehicleDeactivateSound);
}

function ShaftedTeleporter::reEnable(%data, %obj)
{
	%obj.inUse = false;
}

function ShaftedTeleporter::sparkEmitter(%data, %obj)
{
	if (isObject(%obj.teleportEmitter))
		%obj.teleportEmitter.delete();

	%obj.teleportEmitter = new ParticleEmissionDummy() {
		position = %obj.position;
		rotation = "1 0 0 0";
		scale = "1 1 1";
		dataBlock = defaultEmissionDummy;
		emitter = "ShaftedTeleportEmitter";
		velocity = "1";
	};
	MissionCleanup.add(%obj.teleportEmitter);
	%obj.teleportEmitter.schedule(800, "delete");

	if (isObject(%obj.teleEmitter))
		%obj.teleEmitter.delete();

	%obj.teleEmitter = new ParticleEmissionDummy() {
		position = %obj.position;
		rotation = "1 0 0 0";
		scale = "1 1 1";
		dataBlock = defaultEmissionDummy;
		emitter = "FlyerJetEmitter";
		velocity = "1";
	};
	MissionCleanup.add(%obj.teleEmitter);
	%obj.teleEmitter.schedule(700, "delete");
}

function ShaftedTeleporter::teleportingDone(%data, %obj, %player)
{
	%player.setMoveState(false);
	%player.teleporting = 0;
	%player.station = "";
	%data.reEnable(%obj);
	if (%player.getMountedImage($WeaponSlot) == 0)
	{
		if (%player.inv[%player.lastWeapon])
			%player.use(%player.lastWeapon); 
		else
			%player.selectWeaponSlot( 0 );
	}
}


}; // end of package
