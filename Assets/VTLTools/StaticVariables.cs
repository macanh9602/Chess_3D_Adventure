// using AntiStress.MiniGame.BreakingBall;
// using AntiStress.MiniGame.ChristmasTree;
// using AntiStress.MiniGame.FidgetSpinner;
// using AntiStress.MiniGame.Jigsaw;
// using AntiStress.MiniGame.PopIt.PopIt1;
// using I2.Loc;
// using Sirenix.OdinInspector;
// using UnityEngine;
// using System;
// using System.Collections.Generic;
// using AntiStress;
// using System.Linq;
// using System.Globalization;
// using AntiStress.MiniGame.MoneyGun;
// using AntiStress.MiniGame.PressSand;
// using AntiStress.MiniGame.Slime3;
// using AntiStress.MiniGame.CutVegetable;
// using AntiStress.MiniGame.Pirate;
// using AntiStress.MiniGame.CrocodileDentist;
// using EasyUI.PickerWheelUI;
// using PopIt2.BlindBox;
// using PopIt2.MiniGame.GunSimulator;
// using PopIt2.MiniGame.MiniFan;
// using AntiStress.MiniGame.ChopCandy;
// using AntiStress.MiniGame.WhackTheDummy;
// using AntiStress.MiniGame.MakeRamen;
// using AntiStress.MiniGame.BubbleMachine;
// using AntiStress.MiniGame.BubbleTea;
// using AntiStress.MiniGame;
// using AntiStress.MiniGame.JellyCut;
// using AntiStress.MiniGame.FriedPotatoMaker;
// using AntiStress.MiniGame.CutStone;
// using AntiStress.MiniGame.BurgerDecor;
// using AntiStress.MiniGame.CutJellyFruit;
// using DP.Utilities;
// using AntiStress.MiniGame.GunZ;
// using OfflineGames.BrainrotCraft;



// namespace VTLTools
// {
//     public class StaticVariables
//     {
//         #region Public Variables
//         [ShowInInspector, BoxGroup("Setting")]
//         public static bool IsSoundOn
//         {
//             get => UserData.isSoundOn;
//             set
//             {
//                 UserData.isSoundOn = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Setting")]
//         public static bool IsMusicOn
//         {
//             get => UserData.isMusicOn;
//             set
//             {
//                 UserData.isMusicOn = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Setting")]
//         public static bool IsVibrationOn
//         {
//             get => UserData.isVibrationOn;
//             set
//             {
//                 UserData.isVibrationOn = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Setting")]
//         public static string CurrentLanguage
//         {
//             get => UserData.currentLanguage;
//             set
//             {
//                 UserData.currentLanguage = value;
//                 I2.Loc.LocalizationManager.CurrentLanguage = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static int CountGamePlayed
//         {
//             get => UserData.countGamePlayed;
//             set
//             {
//                 UserData.countGamePlayed = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<PopItUnlockProgress> PopItProgress
//         {
//             get => UserData.popItUnlockProgressList;
//         }
//         public static void UnlockPopIt(PopItFidgetId _id)
//         {
//             UserData.popItUnlockProgressList.Add(new PopItUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopItFidgetId
//         {
//             get => UserData.currentPopItFidgetId;
//             set
//             {
//                 UserData.currentPopItFidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopIt3FidgetId
//         {
//             get => UserData.currentPopIt3FidgetId;
//             set
//             {
//                 UserData.currentPopIt3FidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopIt4FidgetId
//         {
//             get => UserData.currentPopIt4FidgetId;
//             set
//             {
//                 UserData.currentPopIt4FidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopIt5FidgetId
//         {
//             get => UserData.currentPopIt5FidgetId;
//             set
//             {
//                 UserData.currentPopIt5FidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopIt6FidgetId
//         {
//             get => UserData.currentPopIt6FidgetId;
//             set
//             {
//                 UserData.currentPopIt6FidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PopItFidgetId CurrentPopItMusicFidgetId
//         {
//             get => UserData.currentPopItMusicFidgetId;
//             set
//             {
//                 UserData.currentPopItMusicFidgetId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<JigsawUnlockProgress> JigsawProgress
//         {
//             get
//             {
//                 return UserData.jigsawUnlockProgressList;
//             }
//         }

//         public static void UnlockJigsaw(JigsawId _id)
//         {
//             if (UserData.jigsawUnlockProgressList.Any(x => x.id == _id))
//             {
//                 return;
//             }
//             UserData.jigsawUnlockProgressList.Add(new JigsawUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<WoodCanUnlockProgress> WoodCanProgress
//         {
//             get => UserData.woodCanUnlockProgressList;
//         }
//         public static void UnlockWoodCan(WoodCanId _id)
//         {
//             UserData.woodCanUnlockProgressList.Add(new WoodCanUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static WoodCanId CurrentWoodCanId
//         {
//             get => UserData.currentWoodCanId;
//             set
//             {
//                 UserData.currentWoodCanId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<PlasticBallUnlockProgress> PlasticBallProgress
//         {
//             get => UserData.plasticBallUnlockProgressList;
//         }
//         public static void UnlockPlasticBall(PlasticBallId _id)
//         {
//             UserData.plasticBallUnlockProgressList.Add(new PlasticBallUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static PlasticBallId CurrentPlasticBallId
//         {
//             get => UserData.currentPlasticBallId;
//             set
//             {
//                 UserData.currentPlasticBallId = value;
//                 SaveData();
//             }
//         }
//         #region Vuz
//         [ShowInInspector, BoxGroup("Data")]
//         public static List<DummyWeaponUnlockProgress> DummyWeaponUnlockProgressList
//         {
//             get => UserData.dummyWeaponUnlockProgressList;
//         }
//         public static void UnlockWeapon(WeaponID _id)
//         {
//             UserData.dummyWeaponUnlockProgressList.Add(new DummyWeaponUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static WeaponID CurrentDummyWeaponId
//         {
//             get => UserData.currentDummyWeaponId;
//             set
//             {
//                 UserData.currentDummyWeaponId = value;
//                 SaveData();
//             }
//         }

//         #endregion
//         [ShowInInspector, BoxGroup("Data")]
//         public static List<SpinnerUnlockProgress> SpinnerProgress
//         {
//             get => UserData.spinnerUnlockProgressList;
//         }
//         public static void UnlockSpinner(FidgetSpinnerId _id)
//         {
//             UserData.spinnerUnlockProgressList.Add(new SpinnerUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static FidgetSpinnerId CurrentSpinnerId
//         {
//             get => UserData.currentSpinnerId;
//             set
//             {
//                 UserData.currentSpinnerId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<BowlUnlockProgress> BowlProgress
//         {
//             get => UserData.bowlUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<CupUnlockProgress> CupProgress
//         {
//             get => UserData.cupUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<ColorTeaUnlockProgress> ColorTeaProgress
//         {
//             get => UserData.colorTeaUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<DecorBubbleTeaUnlockProgress> DecorBubbleTeaProgress
//         {
//             get => UserData.decorBubbleTeaUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<JellyUnlockProgress> JellyProgress
//         {
//             get => UserData.jellyUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<IngredientUnlockProgress> IngredientProgress
//         {
//             get => UserData.ingredientUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<BubbleMachineUnlockProgress> BubbleProgress
//         {
//             get => UserData.bubbleMachineUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<BoxFriedPotatoUnlockProgress> BoxFriedPotatoUnlockProgresses
//         {
//             get => UserData.boxFriedPotatoUnlockProgresses;
//         }

//         //stone
//         [ShowInInspector, BoxGroup("Data")]
//         public static List<StoneUnlockProgress> StoneUnlockProgresses
//         {
//             get => UserData.stoneUnlockProgresses;
//         }

//         //StickerUnlockProgressList
//         [ShowInInspector, BoxGroup("Data")]
//         public static List<StickerUnlockProgress> StickerUnlockProgresses
//         {
//             get => UserData.stickerUnlockProgresses;
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static int HighScoreSnake
//         {
//             get => UserData.highScoreSnake;
//             set
//             {
//                 UserData.highScoreSnake = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Cheat")]
//         public static bool IsCheatNoAd
//         {
//             get => UserData.isCheatNoAds;
//             set
//             {
//                 UserData.isCheatNoAds = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Cheat")]
//         public static bool IsShowFps
//         {
//             get => UserData.isShowFps;
//             set
//             {
//                 UserData.isShowFps = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Cheat")]
//         public static bool IsShowDebug
//         {
//             get => UserData.isShowDebug;
//             set
//             {
//                 UserData.isShowDebug = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Cheat")]
//         public static bool IsShowMaxMediationDebug
//         {
//             get => UserData.isShowMediationDebug;
//             set
//             {
//                 UserData.isShowMediationDebug = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("PushRate")]
//         public static bool IsRated
//         {
//             get => UserData.isRated;
//             set
//             {
//                 UserData.isRated = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("PushRate")]
//         public static bool IsShowRateAtLeastOne
//         {
//             get => UserData.isShowRateAtLeastOne;
//             set
//             {
//                 UserData.isShowRateAtLeastOne = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("PushRate")]
//         public static int CurrentIndexShowRate
//         {
//             get => UserData.currentIndexShowRate;
//             set
//             {
//                 UserData.currentIndexShowRate = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Ads")]
//         public static bool IsRemovedAds
//         {
//             get => UserData.isRemovedAds;
//             set
//             {
//                 UserData.isRemovedAds = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Ads")]
//         public static bool IsRalaxPackPaid
//         {
//             get => UserData.isRelaxPackPaid;
//             set
//             {
//                 UserData.isRelaxPackPaid = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Static")]
//         public static bool isCheckedUpdate;

//         [ShowInInspector, BoxGroup("Tutorial")]
//         public static bool IsGyroscopeTutorialShowed
//         {
//             get => UserData.isGyroscopeTutorialShowed;
//             set
//             {
//                 UserData.isGyroscopeTutorialShowed = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Tutorial")]
//         public static bool IsFifteenGameTutorialShowed
//         {
//             get => UserData.isFifteenGameTutorialShowed;
//             set
//             {
//                 UserData.isFifteenGameTutorialShowed = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Tutorial")]
//         public static bool IsHanoiTowerTutorialShowed
//         {
//             get => UserData.isHanoiTowerTutorialShowed;
//             set
//             {
//                 UserData.isHanoiTowerTutorialShowed = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<DecorUnlockProgress> DecorUnlockProgress
//         {
//             get
//             {
//                 return UserData.decorUnlockProgressList;
//             }
//         }



//         public static void UnlockDecor(DecorId _id)
//         {
//             UserData.decorUnlockProgressList.Add(new DecorUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<MiniGameId> FavoriteMiniGames
//         {
//             get
//             {
//                 return UserData.favoriteMiniGameList;
//             }
//         }

//         public static void AddGameToFavorite(MiniGameId _id)
//         {
//             UserData.favoriteMiniGameList.Add(_id);
//             SaveData();
//         }

//         public static void RemoveGameFromFavorite(MiniGameId _id)
//         {
//             UserData.favoriteMiniGameList.Remove(_id);
//             SaveData();
//         }

//         public static bool IsFavoriteGame(MiniGameId _id)
//         {
//             return UserData.favoriteMiniGameList.Contains(_id);
//         }

//         [ShowInInspector, BoxGroup("Data")]
//         public static List<PremiumGameUnlockProgress> PremiumGameUnlockProgressList
//         {
//             get
//             {
//                 return UserData.premiumGameUnlockProgressList;
//             }
//         }

//         public static void UnlockPremiumMiniGame(MiniGameId _id)
//         {
//             UserData.premiumGameUnlockProgressList.Add(new PremiumGameUnlockProgress()
//             {
//                 id = _id,
//             });
//             UnlockedPremiumGameCount++;
//             SaveData();
//         }

//         public static bool IsPremiumGameUnlocked(MiniGameId _id)
//         {
//             return UserData.premiumGameUnlockProgressList.Any(x => x.id == _id);
//         }

//         public static int UnlockedPremiumGameCount
//         {
//             get
//             {
//                 return UserData.unlockedPremiumGameCount;
//             }
//             set
//             {
//                 UserData.unlockedPremiumGameCount = value;
//                 SaveData();
//             }
//         }

//         public static int CountPurchasePremiumFail
//         {
//             get
//             {
//                 return UserData.countPurchasePremiumFail;
//             }
//             set
//             {
//                 UserData.countPurchasePremiumFail = value;
//                 SaveData();
//             }
//         }

//         public static bool IsSaleTime
//         {
//             get
//             {
//                 return UserData.isSaleTime;
//             }
//             set
//             {
//                 UserData.isSaleTime = value;
//                 SaveData();
//             }
//         }

//         public static DateTime EndTimeSale
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.endSaleTime, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.endSaleTime = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }



//         [ShowInInspector, BoxGroup("Data")]
//         public static List<MoneyUnlockProgress> MoneyUnlockProgressList
//         {
//             get => UserData.moneyUnlockProgressList;
//         }
//         public static void UnlockMoney(MoneyId _id)
//         {
//             UserData.moneyUnlockProgressList.Add(new MoneyUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static MoneyId CurrentMoneyId
//         {
//             get => UserData.currentMoneyId;
//             set
//             {
//                 UserData.currentMoneyId = value;
//                 SaveData();
//             }
//         }

//         //BunUnlockProgress
//         [ShowInInspector, BoxGroup("Data")]
//         public static List<BunUnlockProgress> BunUnlockProgressList
//         {
//             get => UserData.bunUnlockProgressList;
//         }

//         //UnlockBun
//         public static void UnlockBun(BunType _id)
//         {
//             UserData.bunUnlockProgressList.Add(new BunUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         //CurrentBunType
//         public static BunType CurrentBunType
//         {
//             get => UserData.currentBunType;
//             set
//             {
//                 UserData.currentBunType = value;
//                 SaveData();
//             }
//         }

//         public static List<GunUnlockProgress> GunUnlockProgressList
//         {
//             get => UserData.gunUnlockProgressList;
//         }
//         public static void UnlockGun(GunId _id)
//         {
//             UserData.gunUnlockProgressList.Add(new GunUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static GunId CurrentGunId
//         {
//             get => UserData.currentGunId;
//             set
//             {
//                 UserData.currentGunId = value;
//                 SaveData();
//             }
//         }

//         public static List<SandShapeUnlockProgress> SandShapeUnlockProgressList
//         {
//             get => UserData.sandShapeUnlockProgressList;
//         }
//         public static void UnlockSandShape(SandShapeID _id)
//         {
//             UserData.sandShapeUnlockProgressList.Add(new SandShapeUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }


//         public static SandShapeID CurrentSandShapeId
//         {
//             get => UserData.currentSandShapeId;
//             set
//             {
//                 UserData.currentSandShapeId = value;
//                 SaveData();
//             }
//         }

//         public static List<SlimeUnlockProgress> SlimeUnlockProgressList
//         {
//             get => UserData.slimeUnlockProgressList;
//         }
//         public static void UnlockSlime(SlimeId _id)
//         {
//             UserData.slimeUnlockProgressList.Add(new SlimeUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }


//         public static SlimeId CurrentSlimeId
//         {
//             get => UserData.currentSlimeId;
//             set
//             {
//                 UserData.currentSlimeId = value;
//                 SaveData();
//             }
//         }

//         public static List<ToppingUnlockProgress> ToppingUnlockProgressList
//         {
//             get => UserData.toppingUnlockProgressList;
//         }
//         public static void UnlockTopping(ToppingId _id)
//         {
//             UserData.toppingUnlockProgressList.Add(new ToppingUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }


//         public static ToppingId CurrentToppingId
//         {
//             get => UserData.currentToppingId;
//             set
//             {
//                 UserData.currentToppingId = value;
//                 SaveData();
//             }
//         }

//         public static List<VegetableUnlockProgress> VegetableUnlockProgressList
//         {
//             get => UserData.vegetableUnlockProgresses;
//         }
//         public static void UnlockVegetable(VegetableId _id)
//         {
//             UserData.vegetableUnlockProgresses.Add(new VegetableUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }


//         public static VegetableId CurrentVegetableId
//         {
//             get => UserData.currentVegetableId;
//             set
//             {
//                 UserData.currentVegetableId = value;
//                 SaveData();
//             }
//         }

//         public static List<PirateUnlockProgress> PirateUnlockProgressList
//         {
//             get => UserData.pirateUnlockProgresses;
//         }
//         public static void UnlockPirate(PirateId _id)
//         {
//             Helpers.LogCaller($"UnlockPirate {_id}");
//             UserData.pirateUnlockProgresses.Add(new PirateUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static PirateId CurrentPirateId
//         {
//             get => UserData.currentPirateId;
//             set
//             {
//                 UserData.currentPirateId = value;
//                 SaveData();
//             }
//         }

//         public static List<BarrelUnlockProgress> BarrelUnlockProgressList
//         {
//             get => UserData.barrelUnlockProgresses;
//         }
//         public static void UnlockBarrel(BarrelId _id)
//         {
//             UserData.barrelUnlockProgresses.Add(new BarrelUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static BarrelId CurrentBarrelId
//         {
//             get => UserData.currentBarrelId;
//             set
//             {
//                 UserData.currentBarrelId = value;
//                 SaveData();
//             }
//         }

//         [ShowInInspector, BoxGroup("PushRate")]
//         public static int CurrentIndexShowRateReview
//         {
//             get => UserData.currentIndexShowRateReview;
//             set
//             {
//                 UserData.currentIndexShowRateReview = value;
//                 SaveData();
//             }
//         }

//         public static bool IsShowSnakeAndLadderTutorial
//         {
//             get => UserData.isShowSnakeAndLadderTutorial;
//             set
//             {
//                 UserData.isShowSnakeAndLadderTutorial = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentBoltPuzzleLevel
//         {
//             get => UserData.currentBoltPuzzleLevel;
//             set
//             {
//                 UserData.currentBoltPuzzleLevel = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentDropJoyLevel
//         {
//             get => UserData.currentDropJoyLevel;
//             set
//             {
//                 UserData.currentDropJoyLevel = value;
//                 SaveData();
//             }
//         }

//         public static int HighScore2048
//         {
//             get => UserData.highScore2048;
//             set
//             {
//                 UserData.highScore2048 = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentTapMatchLevel
//         {
//             get => UserData.currentTapMatchLevel;
//             set
//             {
//                 UserData.currentTapMatchLevel = value;
//                 SaveData();
//             }
//         }


//         public static int CurrentUnblockMeLevel
//         {
//             get => UserData.currentUnblockMeLevel;
//             set
//             {
//                 UserData.currentUnblockMeLevel = value;
//                 SaveData();
//             }
//         }
//         public static int FavoHighScore
//         {
//             get => UserData.favoHighScore;
//             set
//             {
//                 UserData.favoHighScore = value;
//                 SaveData();
//             }
//         }
//         public static bool IsShowUnblockMeTutorial
//         {
//             get => UserData.isShowUnblockMeTutorial;
//             set
//             {
//                 UserData.isShowUnblockMeTutorial = value;
//                 SaveData();
//             }
//         }

//         public static List<AnimalDentistUnlockProgress> AnimalDentistUnlockProgressList
//         {
//             get => UserData.animalDentistUnlockProgresses;
//         }
//         public static void UnlockAnimalDentist(AnimalDentistId _id)
//         {
//             UserData.animalDentistUnlockProgresses.Add(new AnimalDentistUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static AnimalDentistId CurrentAnimalDentistId
//         {
//             get => UserData.currentAnimalDentistId;
//             set
//             {
//                 UserData.currentAnimalDentistId = value;
//                 SaveData();
//             }
//         }

//         public static bool IsSpinLuckyWheelAtLeastOne
//         {
//             get => UserData.isSpinLuckyWheelAtLeastOne;
//             set
//             {
//                 UserData.isSpinLuckyWheelAtLeastOne = value;
//                 SaveData();
//             }
//         }

//         public static List<LuckyWheelRewardProgress> LuckyWheelRewardProgressList
//         {
//             get
//             {
//                 return UserData.luckyWheelRewardProgressList;
//             }
//         }

//         public static void UnlockLuckyWheelReward(LuckyWheelRewardId _id)
//         {
//             UserData.luckyWheelRewardProgressList.Add(new LuckyWheelRewardProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static bool isRemindOfferLater;

//         public static int TwistedTangleLevel
//         {
//             get => UserData.twistedTangleLevel;
//             set
//             {
//                 UserData.twistedTangleLevel = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentDrawParkingLevel
//         {
//             get => UserData.currentDrawParkingLevel;
//             set
//             {
//                 UserData.currentDrawParkingLevel = value;
//                 SaveData();
//             }
//         }

//         public static bool IsAskForPermissionOne
//         {
//             get => UserData.isAskForPermissionOne;
//             set
//             {
//                 UserData.isAskForPermissionOne = value;
//                 SaveData();
//             }
//         }

//         public static DateTime FirstTimeOpenGame
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.firstTimeOpenGame, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.firstTimeOpenGame = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }

//         public static DateTime FirstTimeSpinLuckyWheel
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.firstTimeSpinLuckyWheel, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.firstTimeSpinLuckyWheel = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }
//         public static int CountTurnOpenBox
//         {
//             get => UserData.countTurnOpenBox;
//             set
//             {
//                 UserData.countTurnOpenBox = value;
//                 EventDispatcher.Instance.Dispatch(EventName.OnChanegCountBoxInBlindBox, null);
//                 SaveData();
//             }
//         }

//         // public static bool IsFirstTimeOpenFullFreeBox
//         // {
//         //     get => UserData.isFirstTimeOpenFullFreeBox;
//         //     set
//         //     {
//         //         UserData.isFirstTimeOpenFullFreeBox = value;
//         //         SaveData();
//         //     }
//         // }

//         public static DateTime TimeFreeBoxInShop
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.timeFreeBoxInShop, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.timeFreeBoxInShop = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }
//         public static DateTime TimeFreeBoxDay
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.timeFreeBoxDay, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.timeFreeBoxDay = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }
//         public static List<BlindContenUnlockProgress> BlindContenUnlockProgressesList
//         {
//             get => UserData.blindContenUnlockProgresses;
//         }
//         public static void AddBlindContenUnlockProgressesList(BlindBoxID _id)
//         {
//             UserData.blindContenUnlockProgresses.Add(new BlindContenUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static List<int> GetBlindItemUsedList(BlindBoxID _blindBoxID)
//         {
//             switch (_blindBoxID)
//             {
//                 case BlindBoxID.BabyThree:
//                     return UserData.blindItemBabyThreeUsedList;
//                 case BlindBoxID.Labubu:
//                     return UserData.blindItemLabubuUsedList;
//                 case BlindBoxID.Capybara:
//                     return UserData.blindItemCapybaraUsedList;
//                 case BlindBoxID.Sanrio:
//                     return UserData.blindItemSanrioUsedList;
//                 case BlindBoxID.Kuromi:
//                     return UserData.blindItemKuromiUsedList;
//                 case BlindBoxID.Cinnamoroll:
//                     return UserData.blindItemCinnamorollUsedList;
//                 case BlindBoxID.Melody:
//                     return UserData.blindItemMelodyUsedList;
//                 case BlindBoxID.LabubuV2:
//                     return UserData.blindItemLabubuV2UsedList;
//                 case BlindBoxID.Loopy:
//                     return UserData.blindItemLoopyUsedList;
//                 case BlindBoxID.Nezha:
//                     return UserData.blindItemNezhaUsedList;
//                 case BlindBoxID.ShinChan:
//                     return UserData.blindItemShinChanUsedList;
//                 case BlindBoxID.LabubuV3:
//                     return UserData.blindItemLabubuV3UsedList;
//                 case BlindBoxID.BrainRotV1:
//                     return UserData.blindItemBrainRotV1UsedList;
//                 default: return null;
//             }
//         }
//         public static void UnlockBlindItem(BlindBoxID _blindBoxID, int _index)
//         {
//             switch (_blindBoxID)
//             {
//                 case BlindBoxID.BabyThree:
//                     UserData.blindItemBabyThreeUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Labubu:
//                     UserData.blindItemLabubuUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Capybara:
//                     UserData.blindItemCapybaraUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Sanrio:
//                     UserData.blindItemSanrioUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Kuromi:
//                     UserData.blindItemKuromiUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Cinnamoroll:
//                     UserData.blindItemCinnamorollUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Melody:
//                     UserData.blindItemMelodyUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.LabubuV2:
//                     UserData.blindItemLabubuV2UsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Loopy:
//                     UserData.blindItemLoopyUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.Nezha:
//                     UserData.blindItemNezhaUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.ShinChan:
//                     UserData.blindItemShinChanUsedList.Add(_index);
//                     break;
//                 case BlindBoxID.LabubuV3:
//                     UserData.blindItemLabubuV3UsedList.Add(_index);
//                     break;
//                 case BlindBoxID.BrainRotV1:
//                     UserData.blindItemBrainRotV1UsedList.Add(_index);
//                     break;
//             }
//             SaveData();

//         }
//         public static TaskBlindBoxProgress GetTaskBlindBoxProgress(TaskID _taskID)
//         {
//             if (!UserData.taskBlindBoxProgressList.Any(x => x.id == _taskID))
//             {
//                 UserData.taskBlindBoxProgressList.Add(new TaskBlindBoxProgress { id = _taskID, progress = 0, levelTask = 0 });
//                 SaveData();
//             }
//             return UserData.taskBlindBoxProgressList.Find(x => x.id == _taskID);
//         }
//         public static void SetTaskBlindBoxProgress(TaskID _taskID, int _progress = 0, int _levelTask = 0)
//         {
//             if (!UserData.taskBlindBoxProgressList.Any(x => x.id == _taskID))
//             {
//                 UserData.taskBlindBoxProgressList.Add(new TaskBlindBoxProgress { id = _taskID, progress = 0, levelTask = 0 });
//             }
//             var _task = UserData.taskBlindBoxProgressList.Find(x => x.id == _taskID);
//             _task.progress += _progress;
//             _task.levelTask += _levelTask;
//             SaveData();
//         }
//         public static void RemovelTaskBlindBoxProgress(TaskID _taskID)
//         {
//             if (UserData.taskBlindBoxProgressList.Any(x => x.id == _taskID))
//             {
//                 UserData.taskBlindBoxProgressList.Remove(UserData.taskBlindBoxProgressList.Find(x => x.id == _taskID));
//                 SaveData();
//             }
//         }

//         public static bool IsFistTimePlay
//         {
//             get => UserData.isFirstTimePlay;
//             set
//             {
//                 UserData.isFirstTimePlay = value;
//                 SaveData();
//             }
//         }

//         public static List<GunSimulatorUnlockProgress> GunSimulatorUnlockProgressList
//         {
//             get => UserData.gunSimulatorUnlockProgressList;
//         }
//         public static void UnlockGunSimulator(GunSimulatorDataId _id)
//         {
//             UserData.gunSimulatorUnlockProgressList.Add(new GunSimulatorUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static GunSimulatorDataId GunSimulatorCurrentId
//         {
//             get => UserData.gunSimulatorCurrentId;
//             set
//             {
//                 UserData.gunSimulatorCurrentId = value;
//                 SaveData();
//             }
//         }

//         public static List<FanUnlockProgress> FanUnlockProgressList
//         {
//             get => UserData.fanUnlockProgressList;
//         }
//         public static void UnlockFan(FanDataId _id)
//         {
//             UserData.fanUnlockProgressList.Add(new FanUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static FanDataId FanCurrentId
//         {
//             get => UserData.fanCurrentId;
//             set
//             {
//                 UserData.fanCurrentId = value;
//                 SaveData();
//             }
//         }

//         public static List<CandyUnlockProgress> CandyUnlockProgressList
//         {
//             get => UserData.candyUnlockProgresses;
//         }
//         public static void UnlockCandy(CandyId _id)
//         {
//             UserData.candyUnlockProgresses.Add(new CandyUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static CandyId CurrentCandyId
//         {
//             get => UserData.currentCandyId;
//             set
//             {
//                 UserData.currentCandyId = value;
//                 SaveData();
//             }
//         }

//         //decorBurgerUnlockProgressList
//         public static List<DecorBurgerUnlockProgress> DecorBurgerUnlockProgressList
//         {
//             get => UserData.decorBurgerUnlockProgressList;
//         }

//         public static void UnlockDecorBurger(DecorBurgerType _id)
//         {
//             UserData.decorBurgerUnlockProgressList.Add(new DecorBurgerUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static DecorBurgerType CurrentDecorBurgerId
//         {
//             get => UserData.currentBurgerDecorType;
//             set
//             {
//                 UserData.currentBurgerDecorType = value;
//                 SaveData();
//             }
//         }

//         public static FruitId CurrentFruitId
//         {
//             get => UserData.currentJellyCutFruitId;
//             set
//             {
//                 UserData.currentJellyCutFruitId = value;
//                 SaveData();
//             }
//         }

//         public static List<JellyCutFruitUnlockProgress> JellyCutFruitUnlockProgressList
//         {
//             get => UserData.jellyCutFruitUnlockProgresses;
//         }

//         public static void UnlockJellyCutFruit(FruitId _id)
//         {
//             if (UserData.jellyCutFruitUnlockProgresses.Any(x => x.id == _id))
//             {
//                 DPDebug.Log($"<color=red>[DA]</color> JellyCutFruit {_id} is already unlocked");
//                 return;
//             }
//             UserData.jellyCutFruitUnlockProgresses.Add(new JellyCutFruitUnlockProgress()
//             {
//                 id = _id,
//             });
//             DPDebug.Log($"<color=green>[DA]</color> {UserData.jellyCutFruitUnlockProgresses.Count}");

//             SaveData();
//         }

//         public static void UnlockBowl(BowlType _id)
//         {
//             UserData.bowlUnlockProgresses.Add(new BowlUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static BowlType currentBowlId
//         {
//             get => UserData.currentBowlId;
//             set
//             {
//                 UserData.currentBowlId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockCup(CupType _id)
//         {
//             UserData.cupUnlockProgresses.Add(new CupUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static CupType currentCupId
//         {
//             get => UserData.currentCupId;
//             set
//             {
//                 UserData.currentCupId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockColorTea(ColorTeaType _id)
//         {
//             UserData.colorTeaUnlockProgresses.Add(new ColorTeaUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static ColorTeaType currentColorTeaId
//         {
//             get => UserData.currentColorTeaId;
//             set
//             {
//                 UserData.currentColorTeaId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockDecorBubbleTeaItem(DecorItemType type)
//         {
//             UserData.decorBubbleTeaUnlockProgresses.Add(new DecorBubbleTeaUnlockProgress()
//             {
//                 id = type,
//             });
//             SaveData();
//         }

//         public static DecorItemType currentDecorBubbleTeaId
//         {
//             get => UserData.currentDecorBubbleTeaId;
//             set
//             {
//                 UserData.currentDecorBubbleTeaId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockJelly(JellyType _id)
//         {
//             UserData.jellyUnlockProgresses.Add(new JellyUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static JellyType currentJellyId
//         {
//             get => UserData.currentJellyId;
//             set
//             {
//                 UserData.currentJellyId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockBoxFriedPotato(BoxType _id)
//         {
//             UserData.boxFriedPotatoUnlockProgresses.Add(new BoxFriedPotatoUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static BoxType CurrentBoxFriedPotatoId
//         {
//             get => UserData.currentBoxFriedPotatoId;
//             set
//             {
//                 UserData.currentBoxFriedPotatoId = value;
//                 SaveData();
//             }
//         }

//         //stone
//         public static void UnlockStone(StoneType _id)
//         {
//             UserData.stoneUnlockProgresses.Add(new StoneUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static StoneType CurrentStoneType
//         {
//             get => UserData.currentStoneType;
//             set
//             {
//                 UserData.currentStoneType = value;
//                 SaveData();
//             }
//         }

//         //UnlockSticker
//         public static void UnlockSticker(DecorStickerType _id)
//         {
//             UserData.stickerUnlockProgresses.Add(new StickerUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         //CurrentStickerType
//         public static DecorStickerType CurrentStickerType
//         {
//             get => UserData.currentStickerType;
//             set
//             {
//                 UserData.currentStickerType = value;
//                 SaveData();
//             }
//         }
//         //
//         public static GunType CurrentGunSelectedType
//         {
//             get => UserData.selectedGunType;
//             set
//             {
//                 UserData.selectedGunType = value;
//                 SaveData();
//             }
//         }

//         //unlock gun
//         public static void UnlockGunType(GunType _id)
//         {
//             UserData.shootzUnlockProgressList.Add(new GunShootzUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static List<GunShootzUnlockProgress> ShootzUnlockProgressList
//         {
//             get => UserData.shootzUnlockProgressList;
//         }

//         public static int CurrentScrewPinLevel
//         {
//             get => UserData.currentScrewPinLevel;
//             set
//             {
//                 UserData.currentScrewPinLevel = value;
//                 SaveData();
//             }
//         }

//         //currentShootzLevel
//         public static int CurrentShootzLevel
//         {
//             get => UserData.currentShootzLevel;
//             set
//             {
//                 UserData.currentShootzLevel = value;
//                 SaveData();
//             }
//         }

//         public static bool IsShowScrewPinCheat;

//         // public static bool IsUnLockAllMiniGames;
//         public static int CurrentColorBlockLevel
//         {
//             get => UserData.currentColorBlockLevel;
//             set
//             {
//                 UserData.currentColorBlockLevel = value;
//                 SaveData();
//             }
//         }
//         public static bool IsShowColorBlockCheat;

//         public static int CurrentPearlGemLevel
//         {
//             get => UserData.CurrentPearlGemLevel;
//             set
//             {
//                 UserData.CurrentPearlGemLevel = value;
//                 SaveData();
//             }
//         }
//         public static bool IsShowPearlGemCheat;

//         public static int CurrentPixelPuzzleLevel
//         {
//             get => UserData.currentPixelPuzzleLevel;
//             set
//             {
//                 UserData.currentPixelPuzzleLevel = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockIngredient(IngredientType _id)
//         {
//             UserData.ingredientUnlockProgresses.Add(new IngredientUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }

//         public static IngredientType currentIngredientId
//         {
//             get => UserData.currentIngredientId;
//             set
//             {
//                 UserData.currentIngredientId = value;
//                 SaveData();
//             }
//         }

//         public static void UnlockBubbleMachine(BubbleMachineType _id)
//         {
//             UserData.bubbleMachineUnlockProgresses.Add(new BubbleMachineUnlockProgress()
//             {
//                 id = _id,
//             });
//             SaveData();
//         }
//         public static BubbleMachineType currentBubbleMachineId
//         {
//             get => UserData.currentBubbleMachineId;
//             set
//             {
//                 UserData.currentBubbleMachineId = value;
//                 SaveData();
//             }
//         }




//         public static int BestScoreSuika
//         {
//             get => UserData.bestScoreSuika;
//             set
//             {
//                 UserData.bestScoreSuika = value;
//                 SaveData();
//             }
//         }

//         public static int BestScoreBaseball
//         {
//             get => UserData.bestScoreBaseball;
//             set
//             {
//                 UserData.bestScoreBaseball = value;
//                 SaveData();
//             }
//         }

//         public static int BestScoreBrainrotMerge
//         {
//             get => UserData.bestScoreBrainrotMerge;
//             set
//             {
//                 UserData.bestScoreBrainrotMerge = value;
//                 SaveData();
//             }
//         }

//         public static int BestScoreBlockSpin
//         {
//             get => UserData.bestScoreBlockSpin;
//             set
//             {
//                 UserData.bestScoreBlockSpin = value;
//                 SaveData();
//             }
//         }

//         public static DateTime LastOnlineTime
//         {
//             get
//             {
//                 return DateTime.Parse(UserData.lastOnlineTime, CultureInfo.InvariantCulture);
//             }
//             set
//             {
//                 UserData.lastOnlineTime = value.ToString(CultureInfo.InvariantCulture);
//                 SaveData();
//             }
//         }

//         //brainrot craft
//         public static void AddBrainrotCraftOwnedList(CraftType _type)
//         {
//             if (_type == CraftType.None) return;
//             UserData.brainrotCraftOwnedList.Add(new BrainrotCraftProgress { Type = _type });
//             SaveData();
//         }

//         //sort
//         public static int CurrentBrainrotSortLevel
//         {
//             get => UserData.currentBrainrotSortLevel;
//             set
//             {
//                 UserData.currentBrainrotSortLevel = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentLineConnectLevel
//         {
//             get => UserData.currentLineConnectLevel;
//             set
//             {
//                 UserData.currentLineConnectLevel = value;
//                 SaveData();
//             }
//         }

//         public static int CurrentHappyCatLevel
//         {
//             get => UserData.currentHappyCatLevel;
//             set
//             {
//                 UserData.currentHappyCatLevel = value;
//                 SaveData();
//             }
//         }

//         //currentPixelDrawLevel
//         public static int CurrentPixelDrawLevel
//         {
//             get => UserData.currentPixelDrawLevel;
//             set
//             {
//                 UserData.currentPixelDrawLevel = value;
//                 SaveData();
//             }
//         }

//         //currentMazeLevel
//         public static int CurrentMazeLevel
//         {
//             get => UserData.currentMazeLevel;
//             set
//             {
//                 UserData.currentMazeLevel = value;
//                 SaveData();
//             }
//         }

//         public static int GetCountBrainrotCraftOwnedList()
//         {
//             return UserData.brainrotCraftOwnedList.Count;
//         }

//         public static bool IsBrainrotCraftOwned(CraftType _type)
//         {
//             return UserData.brainrotCraftOwnedList.Any(x => x.Type == _type);
//         }

//         public static int CountBrainrotGiftOwned
//         {
//             get => UserData.countBrainrotGiftOwned;
//             set
//             {
//                 UserData.countBrainrotGiftOwned = value;
//                 SaveData();
//             }
//         }

//         public static int BestScoreBrainrotCraft
//         {
//             get => UserData.bestScoreBrainrotCraft;
//             set
//             {
//                 if (value < UserData.bestScoreBrainrotCraft) return;
//                 UserData.bestScoreBrainrotCraft = value;
//                 SaveData();
//             }
//         }

//         #endregion

//         #region User Data
//         public static UserData UserData { get; private set; }

//         public static void SetUserData(UserData _data)
//         {
//             UserData = _data;
//             SaveData();
//         }

//         static StaticVariables()
//         {
//             UserData = GetData();
//             if (UserData == null)
//             {
//                 UserData = new UserData();
//                 SaveData();
//             }
//         }

//         static void SaveData()
//         {
//             VTLPlayerPrefs.SetObjectValue(StringsSafeAccess.PREF_USER_DATA, UserData);
//         }
//         static UserData GetData()
//         {
//             return VTLPlayerPrefs.GetObjectValue<UserData>(StringsSafeAccess.PREF_USER_DATA);
//         }
//         #endregion
//     }

//     [Serializable]
//     public class UserData
//     {
//         public bool isSoundOn;
//         public bool isMusicOn;
//         public bool isVibrationOn;
//         public string currentLanguage;

//         public int countGamePlayed;

//         public bool isCheatNoAds;
//         public bool isShowFps;
//         public bool isShowDebug;
//         public bool isShowMediationDebug;

//         public bool isRemovedAds;

//         public bool isRated;
//         public bool isShowRateAtLeastOne;
//         public int currentIndexShowRate;

//         public List<PopItUnlockProgress> popItUnlockProgressList;
//         public PopItFidgetId currentPopItFidgetId;
//         public PopItFidgetId currentPopIt3FidgetId;
//         public PopItFidgetId currentPopIt4FidgetId;
//         public PopItFidgetId currentPopIt5FidgetId;
//         public PopItFidgetId currentPopIt6FidgetId;
//         public PopItFidgetId currentPopItMusicFidgetId = PopItFidgetId.ToyMusic1Blue;
//         public List<JigsawUnlockProgress> jigsawUnlockProgressList;
//         public List<WoodCanUnlockProgress> woodCanUnlockProgressList;
//         public WoodCanId currentWoodCanId;
//         public List<PlasticBallUnlockProgress> plasticBallUnlockProgressList;
//         public PlasticBallId currentPlasticBallId;
//         public List<SpinnerUnlockProgress> spinnerUnlockProgressList;
//         public FidgetSpinnerId currentSpinnerId;
//         public int highScoreSnake;

//         public bool isGyroscopeTutorialShowed;
//         public bool isFifteenGameTutorialShowed;
//         public bool isHanoiTowerTutorialShowed;

//         public List<DecorUnlockProgress> decorUnlockProgressList;
//         public List<MiniGameId> favoriteMiniGameList;
//         public List<PremiumGameUnlockProgress> premiumGameUnlockProgressList;
//         public int unlockedPremiumGameCount;
//         public bool isRelaxPackPaid;
//         public int countPurchasePremiumFail;

//         public bool isSaleTime;

//         public string endSaleTime;

//         public List<MoneyUnlockProgress> moneyUnlockProgressList;
//         public MoneyId currentMoneyId;

//         //currentBunType
//         //bunUnlockProgressList
//         public List<BunUnlockProgress> bunUnlockProgressList;
//         public BunType currentBunType;

//         public List<GunUnlockProgress> gunUnlockProgressList;
//         public GunId currentGunId;

//         public List<SandShapeUnlockProgress> sandShapeUnlockProgressList;
//         public SandShapeID currentSandShapeId;

//         public List<SlimeUnlockProgress> slimeUnlockProgressList;
//         public SlimeId currentSlimeId;

//         public List<ToppingUnlockProgress> toppingUnlockProgressList;
//         public ToppingId currentToppingId;

//         public List<VegetableUnlockProgress> vegetableUnlockProgresses;
//         public VegetableId currentVegetableId;

//         public List<PirateUnlockProgress> pirateUnlockProgresses;
//         public PirateId currentPirateId;

//         public List<BarrelUnlockProgress> barrelUnlockProgresses;
//         public BarrelId currentBarrelId;

//         #region Vuz
//         public List<DummyWeaponUnlockProgress> dummyWeaponUnlockProgressList;
//         public WeaponID currentDummyWeaponId;

//         #endregion

//         #region DucAn
//         public List<BowlUnlockProgress> bowlUnlockProgresses;
//         public BowlType currentBowlId;

//         public List<IngredientUnlockProgress> ingredientUnlockProgresses;
//         public IngredientType currentIngredientId;
//         public List<BubbleMachineUnlockProgress> bubbleMachineUnlockProgresses;
//         public BubbleMachineType currentBubbleMachineId;

//         public List<CupUnlockProgress> cupUnlockProgresses;
//         public CupType currentCupId;
//         public List<ColorTeaUnlockProgress> colorTeaUnlockProgresses;
//         public ColorTeaType currentColorTeaId;
//         public List<DecorBubbleTeaUnlockProgress> decorBubbleTeaUnlockProgresses;
//         public DecorItemType currentDecorBubbleTeaId;
//         public List<JellyUnlockProgress> jellyUnlockProgresses;
//         public JellyType currentJellyId;

//         public List<BoxFriedPotatoUnlockProgress> boxFriedPotatoUnlockProgresses;
//         //stone
//         public List<StoneUnlockProgress> stoneUnlockProgresses;
//         public BoxType currentBoxFriedPotatoId;
//         public StoneType currentStoneType;

//         //CurrentStickerType
//         public List<StickerUnlockProgress> stickerUnlockProgresses;
//         public DecorStickerType currentStickerType;

//         //
//         public GunType selectedGunType;
//         public int currentShootzLevel = 0;
//         public List<GunShootzUnlockProgress> shootzUnlockProgressList;

//         //brain rot merge
//         public List<BrainrotCraftProgress> brainrotCraftOwnedList;
//         public int countBrainrotGiftOwned;
//         public int bestScoreBrainrotCraft;

//         public int currentScrewPinLevel;
//         public int currentColorBlockLevel = 1;
//         public int CurrentPearlGemLevel = 1;
//         public int currentPixelPuzzleLevel = 1;
//         #endregion

//         public int currentIndexShowRateReview;

//         public bool isShowSnakeAndLadderTutorial;

//         public int currentBoltPuzzleLevel;
//         public int currentDropJoyLevel;

//         public int highScore2048;

//         public int currentTapMatchLevel;

//         public int currentUnblockMeLevel;

//         public bool isShowUnblockMeTutorial;
//         public int favoHighScore;

//         public List<AnimalDentistUnlockProgress> animalDentistUnlockProgresses;
//         public AnimalDentistId currentAnimalDentistId;

//         public bool isSpinLuckyWheelAtLeastOne;
//         public List<LuckyWheelRewardProgress> luckyWheelRewardProgressList;

//         public int twistedTangleLevel;

//         public bool isAskForPermissionOne;

//         public string firstTimeOpenGame;

//         public string firstTimeSpinLuckyWheel;

//         public int countTurnOpenBox;
//         //public bool isFirstTimeOpenFullFreeBox;
//         public string timeFreeBoxInShop;
//         public string timeFreeBoxDay;
//         public List<BlindContenUnlockProgress> blindContenUnlockProgresses;
//         public List<int> blindItemBabyThreeUsedList;
//         public List<int> blindItemLabubuUsedList;
//         public List<int> blindItemCapybaraUsedList;
//         public List<int> blindItemSanrioUsedList;
//         public List<int> blindItemKuromiUsedList;
//         public List<int> blindItemCinnamorollUsedList;
//         public List<int> blindItemMelodyUsedList;
//         public List<int> blindItemLabubuV2UsedList;
//         public bool isFirstTimePlay;

//         public List<GunSimulatorUnlockProgress> gunSimulatorUnlockProgressList;
//         public GunSimulatorDataId gunSimulatorCurrentId;

//         public List<FanUnlockProgress> fanUnlockProgressList;
//         public FanDataId fanCurrentId;

//         public List<CandyUnlockProgress> candyUnlockProgresses;
//         public CandyId currentCandyId;

//         //CurrentBurgerDecorType

//         public List<DecorBurgerUnlockProgress> decorBurgerUnlockProgressList;
//         public DecorBurgerType currentBurgerDecorType;

//         //jelly cut fruit
//         public List<JellyCutFruitUnlockProgress> jellyCutFruitUnlockProgresses;
//         public FruitId currentJellyCutFruitId;

//         //draw parking
//         public int currentDrawParkingLevel;

//         public int currentBrainrotSortLevel;

//         //
//         public int currentLineConnectLevel;

//         //
//         public int currentHappyCatLevel;

//         //
//         public int currentPixelDrawLevel;

//         //
//         public int currentMazeLevel;


//         public List<int> blindItemLoopyUsedList;
//         public List<int> blindItemNezhaUsedList;
//         public List<int> blindItemShinChanUsedList;
//         public List<int> blindItemLabubuV3UsedList;
//         public List<int> blindItemBrainRotV1UsedList;

//         public int bestScoreSuika;
//         public int bestScoreBrainrotMerge;
//         public int bestScoreBlockSpin;
//         public int bestScoreBaseball;
//         public List<TaskBlindBoxProgress> taskBlindBoxProgressList;
//         public string lastOnlineTime;
//         public UserData()
//         {
//             isSoundOn = true;
//             isMusicOn = true;
//             isVibrationOn = true;
//             currentLanguage = I2.Loc.LocalizationManager.CurrentLanguage;

//             countGamePlayed = 0;

//             isCheatNoAds = false;
//             isShowFps = false;
//             isShowDebug = false;
//             isShowMediationDebug = false;

//             isRated = false;
//             isShowRateAtLeastOne = false;
//             currentIndexShowRate = 0;

//             isRemovedAds = false;

//             popItUnlockProgressList = new();
//             currentPopItFidgetId = PopItFidgetId.toyRoundYellow;
//             currentPopIt3FidgetId = PopItFidgetId.toyUnicon;
//             currentPopIt4FidgetId = PopItFidgetId.ToyOptimus;
//             currentPopIt5FidgetId = PopItFidgetId.ToyStitch;
//             currentPopIt6FidgetId = PopItFidgetId.ToyGirl3;

//             jigsawUnlockProgressList = new()
//             {
//                 // new()
//                 // {
//                 //     id = JigsawId.Jigsaw_BrainRot_8,
//                 // },
//             };
//             woodCanUnlockProgressList = new()
//                         {
//                             new()
//                             {
//                                 id = WoodCanId.LightClassicCan
//                             }
//                         };
//             currentWoodCanId = WoodCanId.LightClassicCan;
//             plasticBallUnlockProgressList = new()
//                         {
//                             new()
//                             {
//                                 id = PlasticBallId.Ball1
//                             }
//                         };
//             currentPlasticBallId = PlasticBallId.Ball1;
//             spinnerUnlockProgressList = new()
//                         {
//                             new()
//                             {
//                                 id = FidgetSpinnerId.Spinner01
//                             }
//                         };
//             currentSpinnerId = FidgetSpinnerId.Spinner01;
//             highScoreSnake = 0;

//             isGyroscopeTutorialShowed = false;
//             isFifteenGameTutorialShowed = false;
//             isHanoiTowerTutorialShowed = false;

//             decorUnlockProgressList = new();

//             favoriteMiniGameList = new();
//             premiumGameUnlockProgressList = new();
//             unlockedPremiumGameCount = 0;
//             isRelaxPackPaid = false;
//             countPurchasePremiumFail = 0;
//             isSaleTime = false;
//             endSaleTime = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);

//             moneyUnlockProgressList = new();
//             currentMoneyId = MoneyId.US;

//             bunUnlockProgressList = new();
//             currentBunType = BunType.BunType_00;

//             gunUnlockProgressList = new();
//             currentGunId = GunId.Default;

//             sandShapeUnlockProgressList = new();
//             currentSandShapeId = SandShapeID.Shape1;

//             slimeUnlockProgressList = new();
//             currentSlimeId = SlimeId.RainbowSmooth;

//             toppingUnlockProgressList = new();
//             currentToppingId = ToppingId.Cubes;

//             vegetableUnlockProgresses = new();
//             currentVegetableId = VegetableId.Carrot;

//             pirateUnlockProgresses = new();
//             currentPirateId = PirateId.White;

//             barrelUnlockProgresses = new();
//             currentBarrelId = BarrelId.Default;

//             dummyWeaponUnlockProgressList = new();
//             currentDummyWeaponId = WeaponID.BoxingGloves;

//             decorBurgerUnlockProgressList = new();
//             currentBurgerDecorType = DecorBurgerType.DecorBurgerType_00;

//             jellyCutFruitUnlockProgresses = new();
//             currentJellyCutFruitId = FruitId.Apple;

//             currentIndexShowRateReview = 0;
//             isShowSnakeAndLadderTutorial = false;

//             currentBoltPuzzleLevel = 1;
//             currentDropJoyLevel = 1;
//             highScore2048 = 0;

//             currentTapMatchLevel = 1;
//             currentUnblockMeLevel = 1;
//             favoHighScore = 0;
//             isShowUnblockMeTutorial = false;

//             animalDentistUnlockProgresses = new();
//             currentAnimalDentistId = AnimalDentistId.Crocodile;
//             isSpinLuckyWheelAtLeastOne = false;
//             luckyWheelRewardProgressList = new();

//             twistedTangleLevel = 1;

//             isAskForPermissionOne = false;
//             firstTimeOpenGame = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);
//             firstTimeSpinLuckyWheel = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);

//             countTurnOpenBox = 3;
//             timeFreeBoxInShop = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);
//             timeFreeBoxDay = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);
//             blindContenUnlockProgresses = new();
//             blindItemBabyThreeUsedList = new();
//             blindItemLabubuUsedList = new();
//             blindItemCapybaraUsedList = new();
//             blindItemSanrioUsedList = new();
//             blindItemKuromiUsedList = new();
//             blindItemCinnamorollUsedList = new();
//             blindItemMelodyUsedList = new();
//             blindItemLabubuV2UsedList = new();
//             isFirstTimePlay = true;
//             //isFirstTimeOpenFullFreeBox = true;
//             gunSimulatorUnlockProgressList = new();
//             gunSimulatorCurrentId = GunSimulatorDataId.Gun_1911;

//             fanUnlockProgressList = new();
//             fanCurrentId = FanDataId.Tiger;

//             candyUnlockProgresses = new();
//             currentCandyId = CandyId.Candy1;

//             blindItemLoopyUsedList = new();
//             blindItemNezhaUsedList = new();
//             blindItemShinChanUsedList = new();
//             blindItemLabubuV3UsedList = new();
//             blindItemBrainRotV1UsedList = new();
//             bestScoreSuika = 0;
//             bestScoreBrainrotMerge = 0;
//             taskBlindBoxProgressList = new();
//             lastOnlineTime = DateTime.MinValue.ToString(CultureInfo.InvariantCulture);

//             bowlUnlockProgresses = new();
//             currentBowlId = BowlType.Bowl01;

//             ingredientUnlockProgresses = new();
//             bubbleMachineUnlockProgresses = new();
//             currentBubbleMachineId = BubbleMachineType.Car;
//             currentIngredientId = IngredientType.BellPepper01;

//             cupUnlockProgresses = new();
//             currentCupId = CupType.Cup_00;
//             colorTeaUnlockProgresses = new();
//             currentColorTeaId = ColorTeaType.Milo;
//             decorBubbleTeaUnlockProgresses = new();
//             currentDecorBubbleTeaId = DecorItemType.Decor_00;

//             jellyUnlockProgresses = new();
//             currentJellyId = JellyType.Jelly_01_Orange;

//             boxFriedPotatoUnlockProgresses = new();
//             currentBoxFriedPotatoId = BoxType.Box01;

//             stoneUnlockProgresses = new();
//             currentStoneType = StoneType.Stone1;

//             stickerUnlockProgresses = new();
//             currentStickerType = DecorStickerType.DecorStickerType_00;

//             currentDrawParkingLevel = 1;

//             selectedGunType = GunType.Gun_1;
//             shootzUnlockProgressList = new();

//             bestScoreBlockSpin = 0;

//             //
//             brainrotCraftOwnedList = new List<BrainrotCraftProgress>();
//             countBrainrotGiftOwned = 0;
//             bestScoreBrainrotCraft = 0;

//             //
//             currentBrainrotSortLevel = 1;
//             //
//             currentLineConnectLevel = 1;

//             //
//             currentHappyCatLevel = 1;
//             //
//             currentPixelDrawLevel = 1;

//             //
//             bestScoreBaseball = 0;
//             //
//             currentMazeLevel = 1;
//         }

//         public override string ToString()
//         {
//             return $"userData: \n" +
//                    $"isSoundOn: {isSoundOn}\n" +
//                    $"isMusicOn: {isMusicOn}\n" +
//                    $"isVibrationOn: {isVibrationOn}\n" +
//                    $"currentLanguage: {currentLanguage}\n" +
//                    $"countGamePlayed: {countGamePlayed}\n" +
//                    $"isCheatNoAds: {isCheatNoAds}\n" +
//                    $"isShowFps: {isShowFps}\n" +
//                    $"isShowDebug: {isShowDebug}\n" +
//                    $"isShowMediationDebug: {isShowMediationDebug}\n" +
//                    $"isRemovedAds: {isRemovedAds}\n" +
//                    $"isRated: {isRated}\n" +
//                    $"isShowRateAtLeastOne: {isShowRateAtLeastOne}\n" +
//                    $"currentIndexShowRate: {currentIndexShowRate}\n" +
//                    $"popItUnlockProgressList: {string.Join(", ", popItUnlockProgressList)}\n" +
//                    $"currentPopItFidgetId: {currentPopItFidgetId}\n" +
//                    $"jigsawUnlockProgressList: {string.Join(", ", jigsawUnlockProgressList)}\n" +
//                    $"woodCanUnlockProgressList: {string.Join(", ", woodCanUnlockProgressList)}\n" +
//                    $"currentWoodCanId: {currentWoodCanId}\n" +
//                    $"plasticBallUnlockProgressList: {string.Join(", ", plasticBallUnlockProgressList)}\n" +
//                    $"currentPlasticBallId: {currentPlasticBallId}\n" +
//                    $"spinnerUnlockProgressList: {string.Join(", ", spinnerUnlockProgressList)}\n" +
//                    $"currentSpinnerId: {currentSpinnerId}\n" +
//                    $"isGyroscopeTutorialShowed: {isGyroscopeTutorialShowed}\n" +
//                    $"isFifteenGameTutorialShowed: {isFifteenGameTutorialShowed}\n" +
//                    $"isHanoiTowerTutorialShowed: {isHanoiTowerTutorialShowed}\n" +
//                    $"decorUnlockProgressList: {string.Join(", ", decorUnlockProgressList)}" +
//                    $"favoHighScore:{favoHighScore}\n";
//         }
//     }

//     [Serializable]
//     public class PopItUnlockProgress
//     {
//         public PopItFidgetId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class JigsawUnlockProgress
//     {
//         public JigsawId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class WoodCanUnlockProgress
//     {
//         public WoodCanId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class PlasticBallUnlockProgress
//     {
//         public PlasticBallId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class SpinnerUnlockProgress
//     {
//         public FidgetSpinnerId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class DecorUnlockProgress
//     {
//         public DecorId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class PremiumGameUnlockProgress
//     {
//         public MiniGameId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class MoneyUnlockProgress
//     {
//         public MoneyId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     //BunUnlockProgresses
//     [Serializable]
//     public class BunUnlockProgress
//     {
//         public BunType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class GunUnlockProgress
//     {
//         public GunId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class SandShapeUnlockProgress
//     {
//         public SandShapeID id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class SlimeUnlockProgress
//     {
//         public SlimeId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class ToppingUnlockProgress
//     {
//         public ToppingId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     //DecorBurgerUnlockProgress
//     [Serializable]
//     public class DecorBurgerUnlockProgress
//     {
//         public DecorBurgerType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class JellyCutFruitUnlockProgress
//     {
//         public FruitId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class VegetableUnlockProgress
//     {
//         public VegetableId id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class PirateUnlockProgress
//     {
//         public PirateId id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class BarrelUnlockProgress
//     {
//         public BarrelId id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class AnimalDentistUnlockProgress
//     {
//         public AnimalDentistId id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class LuckyWheelRewardProgress
//     {
//         public LuckyWheelRewardId id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class BlindContenUnlockProgress
//     {
//         public BlindBoxID id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }
//     [Serializable]
//     public class GunSimulatorUnlockProgress
//     {
//         public GunSimulatorDataId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }
//     [Serializable]
//     public class FanUnlockProgress
//     {
//         public FanDataId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class CandyUnlockProgress
//     {
//         public CandyId id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class DummyWeaponUnlockProgress
//     {
//         public WeaponID id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class TaskBlindBoxProgress
//     {
//         public TaskID id;
//         public int progress;
//         public int levelTask;

//         public override string ToString()
//         {
//             return id.ToString() + " : " + progress + " : " + levelTask;
//         }

//     }
//     [Serializable]
//     public class BowlUnlockProgress
//     {
//         public BowlType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class IngredientUnlockProgress
//     {
//         public IngredientType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class BubbleMachineUnlockProgress
//     {
//         public BubbleMachineType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class CupUnlockProgress
//     {
//         public CupType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }
//     [Serializable]
//     public class ColorTeaUnlockProgress
//     {
//         public ColorTeaType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }
//     [Serializable]
//     public class DecorBubbleTeaUnlockProgress
//     {
//         public DecorItemType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class JellyUnlockProgress
//     {
//         public JellyType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class BoxFriedPotatoUnlockProgress
//     {
//         public BoxType id;
//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     //stone
//     [Serializable]
//     public class StoneUnlockProgress
//     {
//         public StoneType id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     //StickerUnlockProgress
//     [Serializable]
//     public class StickerUnlockProgress
//     {
//         public DecorStickerType id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class GunShootzUnlockProgress
//     {
//         public GunType id;

//         public override string ToString()
//         {
//             return id.ToString();
//         }
//     }

//     [Serializable]
//     public class BrainrotCraftProgress
//     {
//         public CraftType Type;

//         public override string ToString()
//         {
//             return Type.ToString();
//         }
//     }
// }