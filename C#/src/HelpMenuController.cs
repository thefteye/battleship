using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using System.IO;
using SwinGameSDK;

static class HelpMenuController
{

	public static void DrawHelpMenu()
	{
		const int HELP_MENU_LEFT = 15;
		const int HELP_MENU_GAP = 25;
		const int HELP_MENU_HEADING = 100;

		SwinGame.DrawText("HOW TO PLAY BATTLESHIP GAME", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING);
		SwinGame.DrawText("Battleship is a board game for two players who try to guess the location of the ships each player", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*2);
		SwinGame.DrawText("hides on a plastic grid that can't be seen by his opponent.", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*3);	
		SwinGame.DrawText("Players take turns calling out a row and column on the other player's grid in an attempt to name", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*4);
		SwinGame.DrawText("a square that contains an opponent's ship.", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*5);
		SwinGame.DrawText("Originally published as a pencil and paper game known by several names in the 1930s, the game was", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*6);
		SwinGame.DrawText("eventually released in the late '60s by Milton Bradley as the board game Battleship.", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*7);
		SwinGame.DrawText("Each player receives a board with two grids, five ships, and a supply", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*8);
		SwinGame.DrawText("of hit and miss markers (white and red pegs).", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*9);
		SwinGame.DrawText("One of the grids contains a player's ships and the other is used to record shots fired and", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*10);
		SwinGame.DrawText("an opponent's ships and whether they hit or missed. The goal of the game is to sink", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*11);
		SwinGame.DrawText("all of the opponent's ships by correctly guessing their location.", Color.White, GameResources.GameFont("Courier"), HELP_MENU_LEFT, HELP_MENU_HEADING + HELP_MENU_GAP*12);
		SwinGame.RefreshScreen();
	}

	public static void HandleHelpMenuInput()
	{
		if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE) || SwinGame.KeyTyped(KeyCode.vk_RETURN)) {
			GameController.EndCurrentState();
		}
	}
}