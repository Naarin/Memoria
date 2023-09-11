﻿using System;
using System.Collections.Generic;
using Memoria.Prime.Ini;

namespace Memoria
{
	public sealed partial class Configuration
	{
		private sealed class InterfaceSection : IniSection
		{
			public readonly IniValue<Boolean> PSXBattleMenu;
			public readonly IniValue<Boolean> ScanDisplay;
			public readonly IniValue<Int32> BattleRowCount;
			public readonly IniValue<Int32> BattleColumnCount;
			public readonly IniValue<Int32> BattleMenuPosX;
			public readonly IniValue<Int32> BattleMenuPosY;
			public readonly IniValue<Int32> BattleMenuWidth;
			public readonly IniValue<Int32> BattleMenuHeight;
			public readonly IniValue<Int32> BattleDetailPosX;
			public readonly IniValue<Int32> BattleDetailPosY;
			public readonly IniValue<Int32> BattleDetailWidth;
			public readonly IniValue<Int32> BattleDetailHeight;
			public readonly IniValue<String> BattleDamageTextFormat;
			public readonly IniValue<String> BattleRestoreTextFormat;
			public readonly IniValue<String> BattleMPDamageTextFormat;
			public readonly IniValue<String> BattleMPRestoreTextFormat;
			public readonly IniValue<String> BattleCommandTitleFormat;

			public readonly IniValue<Int32> MenuItemRowCount;
			public readonly IniValue<Int32> MenuAbilityRowCount;
			public readonly IniValue<Int32> MenuEquipRowCount;
			public readonly IniValue<Int32> MenuChocographRowCount;

			public InterfaceSection() : base(nameof(InterfaceSection), true)
			{
				PSXBattleMenu = BindBoolean(nameof(PSXBattleMenu), false);
				ScanDisplay = BindBoolean(nameof(ScanDisplay), true);
				BattleRowCount = BindInt32(nameof(BattleRowCount), 5);
				BattleColumnCount = BindInt32(nameof(BattleColumnCount), 1);
				BattleMenuPosX = BindInt32(nameof(BattleMenuPosX), -400);
				BattleMenuPosY = BindInt32(nameof(BattleMenuPosY), -362);
				BattleMenuWidth = BindInt32(nameof(BattleMenuWidth), 630);
				BattleMenuHeight = BindInt32(nameof(BattleMenuHeight), 236);
				BattleDetailPosX = BindInt32(nameof(BattleDetailPosX), 345);
				BattleDetailPosY = BindInt32(nameof(BattleDetailPosY), -380);
				BattleDetailWidth = BindInt32(nameof(BattleDetailWidth), 796);
				BattleDetailHeight = BindInt32(nameof(BattleDetailHeight), 230);
				BattleDamageTextFormat = BindString(nameof(BattleDamageTextFormat), String.Empty);
				BattleRestoreTextFormat = BindString(nameof(BattleRestoreTextFormat), String.Empty);
				BattleMPDamageTextFormat = BindString(nameof(BattleMPDamageTextFormat), String.Empty);
				BattleMPRestoreTextFormat = BindString(nameof(BattleMPRestoreTextFormat), String.Empty);
				BattleCommandTitleFormat = BindString(nameof(BattleCommandTitleFormat), String.Empty);

				MenuItemRowCount = BindInt32(nameof(MenuItemRowCount), 8); // Default PC: 8, PSX: 11
				MenuAbilityRowCount = BindInt32(nameof(MenuAbilityRowCount), 6); // Default PC: 6, PSX: 8
				MenuEquipRowCount = BindInt32(nameof(MenuEquipRowCount), 5); // Default PC: 5, PSX: 6
				MenuChocographRowCount = BindInt32(nameof(MenuChocographRowCount), 5); // Default PC: 5, PSX: 7
				// Shop menu -- Default PC: 5/8, PSX: 7/11 (with/without portraits)
				// Status menu -- Default PC: 8, PSX: 8
				// Config menu -- Default PC: 6/8, PSX: 9
			}
		}
	}
}