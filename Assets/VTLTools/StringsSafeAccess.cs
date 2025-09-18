using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VTLTools
{
    public static class StringsSafeAccess
    {
        public static string PREF_USER_DATA = "PREF_USER_DATA";

        public static string INTER_BACK_HOME = "Inter_BackHome";
        public static string INTER_START_MINIGAME = "Inter_StartMiniGame";
        public static string REWARD_ = "REWARD_";
        public static string REWARD_CLICK_SUGGEST_TAPMATCH = "REWARD_ClickSuggestTapMatch";
        public static string REWARD_UNLOCK_ = "REWARD_UNLOCK_";
        public static string MAIN_HOME_POPUP = "Main_Home_Popup";

        public static string INTER_END_ROUD_FIFTEENGAME = "Inter_EndRoundFifteenGame";
        public static string INTER_END_ROUD_JIGSAW = "Inter_EndRoundJigsaw";
        public static string INTER_END_ROUD_MEMORY = "Inter_EndRoundMemory";
        public static string INTER_END_ROUD_SHAPESLOT = "Inter_EndRoundShapeSlot";
        public static string INTER_POPIT_FIVE_FLIPS = "Inter_PopIt5Flips";
        public static string INTER_BREAKING_BALL_FIVE_RESET = "Inter_BreakingBallFiveReset";
        public static string INTER_HAMMER_FIFTY_HIT = "Inter_HammerFiftyHit";
        public static string INTER_ZIPPER_TWENTY_PULL = "Inter_ZipperTwentyPull";
        public static string INTER_END_ROUD_HANOITOWER = "Inter_EndRoundHanoiTower";
        public static string INTER_REACH_KILL_SNOWMAN = "Inter_ReachKillSnowMan";
        public static string INTER_FINISH_BAKECOOKIE = "Inter_FinishBakeCookie";
        public static string INTER_REACH_BOWLING_SCORE = "Inter_ReachBowlingScore";
        public static string INTER_POPIT2_FIVE_FLIPS = "Inter_PopIt25Flips";
        public static string INTER_REACH_KINETIC_SAND_SCORE = "Inter_ReachKineticSandScore";
        public static string INTER_REACH_CUT_BREAD_SCORE = "Inter_ReachCutBreadScore";
        public static string INTER_REACH_JELLY_CUT_SCORE = "Inter_ReachJellyCutScore";
        public static string INTER_REACH_BUBBLE_WRAP_SCORE = "Inter_ReachBubbleWrapScore";
        public static string INTER_REACH_CUT_VEGETABLE_SCORE = "Inter_ReachCutVegetableScore";
        public static string INTER_REACH_CUT_STONE_SCORE = "Inter_ReachCutStoneScore";
        public static string INTER_REACH_CUT_JELLY_FRUIT_SCORE = "Inter_ReachCutJellyFruitScore";
        public static string INTER_REACH_CUT_WATERMELONCUT_SCORE = "Inter_ReachWatermelonCutScore";
        public static string INTER_REACH_CUT_SOAP_SCORE = "Inter_ReachCutSoapScore";
        public static string INTER_REACH_SPAWN_GEM_SCORE = "Inter_ReachSpawnGemScore";
        public static string INTER_REACH_BUTTON2_SCORE = "Inter_ReachButton2Score";
        public static string INTER_REACH_MONEY_GUN_SCORE = "Inter_ReachMoneyGunScore";
        public static string INTER_REACH_CHOP_CANDY_SCORE = "Inter_ReachChopCandyScore";
        public static string INTER_REACH_STONE_SKIPPING_SCORE = "Inter_ReachStoneSkippingScore";
        public static string INTER_REACH_SOCCER_2_SCORE = "Inter_ReachSoccer2Score";
        public static string INTER_REACH_TICTACTOE_ROUND = "Inter_ReachTicTacToeRound";
        public static string INTER_WIN_0HH1 = "Inter_Win0hh1";
        public static string INTER_WIN_ArrangePencil = "Inter_WinArrangePencil";
        public static string INTER_REACH_TAP_BUBBLE_SCORE = "Inter_ReachTapBubbleScore";
        public static string INTER_REACH_SHAKE_BALL_TIME = "Inter_ReachShakeBallScore";
        public static string INTER_REACH_WHACK_MOLE_SCORE = "Inter_ReachWhackMoleScore";
        public static string INTER_REACH_CROCODILE_ROUND = "Inter_ReachCrocodileRound";
        public static string INTER_PRESSED_BUTTON_REPLAY_SOSCHESS = "Inter_PressedButtonReplaySOSChess";
        public static string INTER_PRESSED_BUTTON_REPLAY_ANIMALSCHESS = "Inter_PressedButtonReplayAnimalsChess";
        public static string INTER_SNAKE_AND_LADDER_END_ROUND = "Inter_SnakeAndLadderEndRound";
        public static string INTER_BOLT_PUZZLE_WIN_GAME = "Inter_BoltPuzzleWinGame";
        public static string INTER_REACH_PINGPONG_SCORE = "Inter_ReachPingPongScore";
        public static string INTER_REACH_PINBALL_SCORE = "Inter_ReachPinBallScore";
        public static string INTER_REACH_BALLOONPUMP_SCORE = "Inter_ReachBalloonPumpScore";

        public static string INTER_REACH_HITTHENAILS_SCORE = "Inter_ReachHitTheNailsScore";
        public static string INTER_WIN_RUBICK = "Inter_WinRubick";
        public static string INTER_RESET_2048 = "Inter_Reset2048";
        public static string INTER_RESET_0HH1 = "Inter_Reset0HH1";

        public static string INTER_END_ROUND_WHACKTHEDUMMY = "Inter_EndRoundWhackTheDummy";
        public static string INTER_RESET_SQUIDGGAME = "Inter_Reset0HH1";
        public static string INTER_REACH2000POINT_2048 = "Inter_ReachScore2048";
        public static string INTER_WIN_BILLIARD = "Inter_WinBilliard";
        public static string INTER_END_ROUND_PIRATE = "Inter_EndRoundPirate";
        public static string INTER_END_ROUND_COLORWHEEL = "Inter_EndRoundColorWheel";
        public static string INTER_NEXT_LEVEL_TAPMATCH = "Inter_NextLevelTapMatch";
        public static string INTER_REACH_20_ARROWS_ARCHERY = "Inter_ReachArrowScore";
        public static string INTER_REACH_5_VEGETABLE = "Inter_ReachVegetableScore";
        public static string INTER_REACH_SNAKEGAME_ROUND = "Inter_ReachSnakeGameRound";
        public static string INTER_REACH_PRESSSAND_ROUND = "Inter_ReachPressSandRound";
        public static string INTER_REACH_TIME_LITMIT = "Inter_ReachTimeLimit";
        public static string INTER_END_ROUND_WOODBLOCK = "Inter_EndRoundWoodBlock";
        public static string INTER_REACH_PENCILSHARPENER_ROUND = "Inter_ReachPencilShaerpenerRound";

        public static string INTER_END_ROUND_COLORWAR = "Inter_EndRoundColorWar";
        public static string INTER_RESET_COLORWAR = "Inter_ResetColorWar";
        public static string INTER_END_ROUND_DOTSANDBOXES = "Inter_EndRoundDotAndBoxes";
        public static string INTER_END_ROUND_DOTSANDBOXES_RESETSOON = "Inter_EndRoundDotAndBoxes_ResetSoon";
        public static string INTER_END_ROUND_BUILDWALL = "Inter_EndRoundBuildWall";
        public static string INTER_ENDROUND_KILLTHECOCKROACH = "Inter_EndRoundKillTheCockroach";
        public static string INTER_REACH_TICTACTOE2_ROUND = "Inter_ReachTicTacToe2Round";
        public static string INTER_REACH_WINDOWCLEANER_ROUND = "Inter_ReachWindowCleanerRound";
        public static string INTER_PRESSED_BUTTON_RESET_TICTACTOE2 = "Inter_PressedButtonResetTictactoe2";
        public static string INTER_REACH_MEMORYSOUNDGAME_ROUND = "Inter_ReachMemorySoundRound";
        public static string INTER_END_ROUND_SPEAKERCABLE = "Inter_EndRoundSpeakercable";
        public static string INTER_END_ROUND_SQUIDGAME = "Inter_EndRoundSquidGame";
        public static string INTER_END_GAME_ANIMALS_CHESS = "Inter_EndGameAnimalChess";
        public static string INTER_END_GAME_SOS_CHESS = "Inter_EndGameSosChess";
        public static string INTER_END_ROUND_DESTROYGLASS = "Inter_EndRoundDestroyGlass";
        public static string INTER_END_ROUND_CUPBALL = "Inter_EndRoundCupBall";
        public static string INTER_END_ROUND_HEARTLETTER = "Inter_EndRoundHeartLetter";
        public static string INTER_END_ROUND_BEAT14 = "Inter_EndRoundBeat14";
        public static string INTER_END_ROUND_BEAT14_PASS3000 = "Inter_EndRoundBeat14_Pass3000";
        public static string REWARD_BEAT14_BOMB = "Reward_Beat14Bomb";
        public static string REWARD_BEAT14_UNDO = "Reward_Beat14Undo";
        public static string INTER_REACH_COLORCONNECTGAME_ROUND = "Inter_ReachColorConnectEndRound";
        public static string INTER_END_ROUND_DESTROYRUBY = "Inter_EndRoundDestroyRuby";
        public static string INTER_END_ROUND_DICEBATTLE = "Inter_EndRoundDiceBattle";
        public static string INTER_END_ROUND_DICEBATTLE_RESETSOON = "Inter_EndRoundDiceBattle_ResetSoon";
        public static string INTER_FINISH_LEVEL_WORDS_SEARCH = "Inter_FinishLevelWordSearch";
        public static string INTER_REACH_10_CAKESORT = "Inter_Reach10CakeSort";
        public static string REWARD_CLICK_SUGGEST_WORDSEARCH = "Reward_SuggestWordSearch";

        public static string REWARD_COLORCONNECTGAME_HINT = "Reward_ColorConnectHint";


        public static string INTER_SOCCER1_REACH_SCORE = "Inter_Soccer1ReachScore";
        public static string INTER_BEAN_REACH_SCORE = "Inter_BeanReachScore";
        public static string INTER_HEART_FINISH = "Inter_HeartFinish";
        public static string INTER_DART_REACH_SCORE = "Inter_DartReachScore";
        public static string INTER_PIGGYBANK_REACH_SCORE = "Inter_PiggyBankReachScore";
        public static string INTER_RESET_BOLT_PUZZLE = "Inter_ResetBoltPuzzle";
        public static string INTER_COMPLETE_BENTO = "Inter_CompleteBento";
        public static string INTER_COMPLETE_CHRISTMAS_TREE = "Inter_CompleteChristmasTree";
        public static string INTER_REACH_DICE_TURN = "Inter_ReachDiceTurn";
        public static string INTER_FINISH_SCREW_GAME = "Inter_FinishScrewGame";
        public static string INTER_FINISH_BOOKSORT = "Inter_FinishBookSort";
        public static string INTER_FINISH_HAMMER_GAME = "Inter_FinishHammerGame";
        public static string INTER_REACH_GYRO_SCORE = "Inter_ReachGyroScore";
        public static string INTER_REACH_BASKETBALL_SCORE = "Inter_ReachBasketballScore";
        public static string INTER_REACH_GOLF_SCORE = "Inter_ReachGolfScore";
        public static string INTER_REACH_COMPUTER_SCORE = "Inter_ReachComputerScore";
        public static string INTER_REACH_ARRANGEPENCIL_ROUND = "Inter_ReachArrangePencilRound";
        public static string INTER_RESET_UNBLOCKME = "Inter_ResetUnblockMe";
        public static string INTER_FINISH_UNBLOCKME = "Inter_FinishUnblockMe";
        public static string INTER_LOSE_GAME_FAVO = "Inter_LoseGameFavo";
        public static string INTER_DUCK_HUNT = "Inter_DuckHunt";
        public static string INTER_FIND_THE_NUMBER = "Inter_FindTheNumber";
        public static string INTER_POPIT_MUSIC = "Inter_PopItMusic";
        public static string INTER_TAP_RUN = "Inter_TapRun";
        public static string INTER_DANCING_CACTUS = "Inter_DancingCactus";
        public static string INTER_MAKE_RAMEN = "Inter_MakeRamen";
        public static string INTER_END_ROUD_TWISTED_TANGLE = "Inter_EndRoundTwistedTangle";
        public static string INTER_RESET_TWISTED_TANGLE = "Inter_ResetTwistedTangle";
        public static string INTER_RESET_SCREW_PIN = "Inter_ResetScrewPin";
        public static string INTER_WIN_LEVEL_DROP_COLOR_JOY = "Inter_WinLevelDropColorJoy";
        public static string INTER_LOSE_LEVEL_DROP_COLOR_JOY = "Inter_LoseLevelDropColorJoy";
        public static string INTER_LOSE_COLOR_BLOCK = "Inter_LoseColorBlock";
        public static string INTER_WIN_LEVEL_COLOR_BLOCK = "Inter_WinColorBlock";
        public static string INTER_RESET_COLOR_BLOCK = "Inter_ResetColorBlock";
        public static string INTER_BUBBLE_TEA = "Inter_BubbleTea";
        public static string INTER_FRIED_POTATO = "Inter_FriedPotato";
        public static string INTER_NINJA_FRUIT = "Inter_NinjaFruit";
        public static string MATERIAL_EMMISSION = "_Emission";
        public static string MATERIAL_COLOR = "_Color";
        public static string MATERIAL_BASE_COLOR = "_BaseColor";
        public static string MATERIAL_MSAO = "_MSAO";
        public static string MATERIAL_SMOOTHNESS = "_Smoothness";

        public static string TAG_PLANE = "Plane";
        public static string TAG_GOLFBALL = "GolfBall";
        public static string Tag_HIDEBLOCK = "HiddenBlock";
        public static string TAG_BRICK = "Brick";
        public static string Tag_Slot = "Slot";
        public static string TAG_SphereElement = "SphereElement";
        public static string LAYER_STRAW = "Straw";
        public static string LAYER_TOPPING = "Topping";
        public static string TAG_PIECE = "Piece";
        public static string TAG_Obstacle = "Obstacle";
        public static string TAG_ParkingPoint = "ParkingPoint";
        public static string TAG_Car = "Car";
        public static string TAG_Head = "Head";
        public static string TAG_Body = "Body";

        public static string INTER_END_ROUND_TWENTY_3000 = "Inter_EndRoundTwenty_3000";
        public static string INTER_END_ROUND_TWENTY = "Inter_EndRoundTwenty";

        public static string INTER_END_GAME_1PLAYER = "INTER_END_GAME_1PLAYER";

        //screw pin
        public static string FAIL_LEVEL_SCREW_PIN = "Fail_ScrewPinLevel";
        public static string PASS_LEVEL_SCREW_PIN = "Pass_ScrewPinLevel";
        public static string START_LEVEL_SCREW_PIN = "Start_ScrewPinLevel";

        //
        public static string INTER_BUBBLE_MACHINE = "Inter_BubbleMachine";

        //color block
        public static string FAIL_LEVEL_COLOR_BLOCK = "Fail_ColorBlockLevel";
        public static string PASS_LEVEL_COLOR_BLOCK = "Pass_ColorBlockLevel";
        public static string START_LEVEL_COLOR_BLOCK = "Start_ColorBlockLevel";

        //pearl gem
        public static string INTER_PASS_LEVEL_PEARL_GEM = "Inter_PearlGemPassLevel";
        public static string INTER_LOSE_PEARL_GEM = "Inter_PearlGemLoseLevel";

        //Drop Color Joy
        public static string PASS_DROP_COLOR_JOY = "PassDropColorJoy";
        public static string FAIL_DROP_COLOR_JOY = "FailDropColorJoy";
        public static string START_DROP_COLOR_JOY = "StartDropColorJoy";

        //
        public static string INTER_NEXT_LEVEL_PIXEL_PUZZLE = "Inter_NextLevelPixelPuzzle";
        public static string INTER_FIRST_TIME_COUNT_0_OPEN_BOX = "Inter_FirstTimeCount_0_OpenBox";

        //draw parking
        public static string START_LEVEL_DRAW_PARKING = "StartLevelDrawParking";
        public static string PASS_LEVEL_DRAW_PARKING = "PassLevelDrawParking";
        public static string FAIL_LEVEL_DRAW_PARKING = "FailLevelDrawParking";
        public static string INTER_WIN_LEVEL_DRAW_PARKING = "Inter_WinLevelDrawParking";
        public static string INTER_LOSE_LEVEL_DRAW_PARKING = "Inter_LoseLevelDrawParking";

        //shootz
        public static string INTER_NEXT_LEVEL_SHOOTZ = "Inter_NextLevelShootz";

        //
        public static string INTER_GAME_OVER_BLOCK_SPIN = "Inter_GameOverBlockSpin";

        public static string INTER_WIN_LEVEL_BRAIN_ROT_SORT = "Inter_WinLevelBrainrotSort";
        public static string INTER_GAME_OVER_BRAIN_ROT_SORT = "Inter_GameOverBrainrotSort";
        public static string FAIL_LEVEL_BRAIN_ROT_SORT = "Fail_BrainrotSortLevel";
        public static string PASS_LEVEL_BRAIN_ROT_SORT = "Pass_BrainrotSortLevel";
        public static string START_LEVEL_BRAIN_ROT_SORT = "Start_BrainrotSortLevel";

        public static string INTER_GAME_OVER_SURIKEN_CUT = "Inter_GameOverSurikenCut";

        public static string INTER_GAME_OVER_BRAINROT_CRAFT = "Inter_GameOverBrainrotCraft";

        public static string INTER_WIN_LEVEL_LINE_CONNECT = "Inter_WinLevelLineConnect";
        public static string INTER_RESET_LINE_CONNECT = "Inter_ResetLineConnect";

        public static string INTER_WIN_LEVEL_HAPPY_CAT = "Inter_WinLevelHappyCat";
        public static string INTER_NEXT_LEVEL_HAPPY_CAT = "Inter_NextLevelHappyCat";

        public static string INTER_NEXT_LEVEL_PIXEL_DRAW = "Inter_NextLevelPixelDraw";
        public static string INTER_RETRY_LEVEL_PIXEL_DRAW = "Inter_RetryLevelPixelDraw";

        public static string INTER_RESET_TIME_BASEBALL = "Inter_ResetTime_Baseball";

        public static string INTER_GAME_OVER_MAZE = "Inter_GameOverMaze";

        public static string INTER_WIN_LEVEL_MAZE = "Inter_WinLevelMaze";
    }
}