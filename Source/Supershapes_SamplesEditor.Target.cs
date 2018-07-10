// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Supershapes_SamplesEditorTarget : TargetRules
{
	public Supershapes_SamplesEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Supershapes_Samples" } );
	}
}
