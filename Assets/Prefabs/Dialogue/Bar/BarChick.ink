
#speaker:Cathy #portrait:Cathy
Hey there! 
You look like you know how to party, wanna grab some drinks?

* [Sure why not?] ->ThatsTheSpirit
* [Um not exactly...] ->ConvinceHim
* [Just coming by to...say "hi"?] ->MattAwkward

 === ThatsTheSpirit ===
 That's the spirit! I've got something nice and strong to get us started, here you go.
 
 * [Bottoms up] ->DrinkFirstRound
 
 === DrinkFirstRound ===
 How was that? Has a good kick to it doesn't it?
 
 * [Y-Yeah  - cough - You could say that...] ->TookItLikeAChamp
 * [Yeah, maybe too much of one...] ->WannaGo
 
 === WannaGo ===
 You alright? Need some air?
 
 * [Nah, I'm fine, ready for another round?] ->GoodMan
 * [Yeah I think so...] ->GoGetAir
 
 === TookItLikeAChamp ===
 You took it like a champ man! Wanna go another round?
 
 * [Um sure?] ->GoodMan
 * [Maybe not, I think I need some air...] ->GoGetAir
 
 === GoGetAir ===
 No worries, if you wanna go another round, let me know.
 
 * [Actually, I think I'll be alright for another one.] ->GoodMan
 * [Thanks *Leave*] ->MattThinkToSelf
 
 === GoodMan ===
 Good man! Here you go.
 
 * [Really doing this? Okay then! *Drink* ] ->DrunkBeforeDillonFindsYa
 
 === DrunkBeforeDillonFindsYa ===
 Nice! Have another!
 
 * [ No turning back *Drink*] ->DillonFindDrunkMatt
 * [Sorry, I need the bathroom] ->OhSure
 
 === OhSure ===
 Oh sure, no problem. It's just over there.
 
 * [Thanks *Leave*] ->DONE
 //go to bar bathroom

 === ConvinceHim ===
Aww come'on, it'll be fun! 

* [I guess it couldn't hurt...?] ->ThatsTheSpirit
* [No thanks, I'm okay. Nice meeting you though] ->SuitSelfMeeting

 === SuitSelfMeeting ===
 Alright then, suit yourself!
 It was nice to meet you too stranger!
 
 * [*Leave*] ->MattThinkToSelf

 === MattAwkward ===
 Oh...Well hi there! 
 You sure you don't wanna have a drink? Come'on, it'll be fun!
 
 * [I suppose one won't hurt?] ->ThatsTheSpirit
 * [N-No thanks... I'll be alright] ->SuitYourself
 
 === SuitYourself ===
 Okay then! Suit yourself!
 - She smiles and continues dancing -
 
 * [*Walk away*] ->MattThinkToSelf
 
 === DillonFindDrunkMatt ===
 Hey you don't look too good...
 You okay?
 
 * [...] ->DillonArrive
 
 === DillonArrive ===
 #speaker:Dillon #portrait:Laid_Back
 Yo Matt, I was wondering where you got off to, I guess you managed to have some fun afterall?
 Woa-easy there bud, you're not looking so good... I think it's time to go home.
 
 * [Pfshhhh I'm fiiine...] ->HeDefNotFine 
 * [Yeah...I'm not feeling that *retches* ] ->Yeesh
 
  === Yeesh ===
  Take it easy Matt, deep breaths. The car's not too far away.
  
  * [*Follow Dillon*] ->DONE 
  
  //go to car ride
 
  === HeDefNotFine === 
  What do you mean "fine"? You can barely keep yourself standing. 
  Come on'bud, let's get you home.
  
 * [You're not my dad, you can't tell me what to do] ->CarryBoi
 * [*sigh and follow Dillon*] ->Attaboy

 === CarryBoi ===
 Matt, really? 
 
 -He picks up a drunk Matt and carries him over his shoulders-
 
 There we go. The car isn't too far, you'll be alright.
 
 ->DONE 
 
 //go to car ride

 === Attaboy ===
 Atta boy, come here -He puts his arm over Matt's shoulder to lean against-
 
 ->DONE 
 
 //go to car ride
 
 === MattThinkToSelf ===
 #speaker:Matt #portrait:Matt
 That girl was a bit intense. I want to rinse my face in the bathroom to calm down but maybe I should find Dillon first?
 
 * [*Wash up*] ->WashUp 
 * [*Find Dillon*] ->LookForDillon
 
 === LookForDillon ===
 I'll go find Dillon first.
 
 ->DONE
 
 === WashUp ===
 I'll wash up first, I won't be gone too long 
 
 ->DONE
 //go to bar bathroom






