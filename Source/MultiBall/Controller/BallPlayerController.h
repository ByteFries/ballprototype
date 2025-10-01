// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/PlayerController.h"
#include "BallPlayerController.generated.h"

class UInputMappingContext;
/**
 * 
 */
UCLASS()
class MULTIBALL_API ABallPlayerController : public APlayerController
{
	GENERATED_BODY()
public:
	ABallPlayerController();

	virtual void SetupInputComponent() override;

protected:

	TObjectPtr<UInputMappingContext> PlayerIMC;
};
