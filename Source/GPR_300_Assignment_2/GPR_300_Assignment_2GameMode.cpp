// Copyright Epic Games, Inc. All Rights Reserved.

#include "GPR_300_Assignment_2GameMode.h"
#include "GPR_300_Assignment_2Pawn.h"

AGPR_300_Assignment_2GameMode::AGPR_300_Assignment_2GameMode()
{
	// set default pawn class to our character class
	DefaultPawnClass = AGPR_300_Assignment_2Pawn::StaticClass();
}

