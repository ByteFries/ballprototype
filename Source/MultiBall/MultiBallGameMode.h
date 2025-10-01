// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "MultiBallGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AMultiBallGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AMultiBallGameMode();
};



