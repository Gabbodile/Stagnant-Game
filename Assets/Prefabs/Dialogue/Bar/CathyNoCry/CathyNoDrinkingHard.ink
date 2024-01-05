#speaker:... #portrait:Cathy
...
Can I...help you?

* [You look like you're having fun, mind if I join you for a drink?] ->ThinkAboutIt
* [I was just coming by to say..."hi"?] ->HiIGuess

 === ThinkAboutIt ===
 Hmm...
 -She looks you up and down with a cautious but curious expression-
 Well you seem nice enough...
 
 * [*NEXT*] ->ThinkAboutItContinued
 
 === ThinkAboutItContinued ===
 -She smiles-
 I don't see why not?
 
 * [*NEXT*] ->Challenge
 
 === Challenge ===
 Hey, up for a challenge?
 -She hands you a shot of tequila with a cocky expression-
 
 * [Oh you're on! *Drink*] ->ThatsSpirit 
 * [On second thought...] ->Chicken
 
 === Chicken ===
 Heh, no worries, more for me.
 See ya!
 
 * [See ya *Leave*] ->MattThinkToSelf
 
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
 
 === ThatsSpirit ===
 Heh, a little stronger than you were expecting?
 
 * [Y-Yeah *cough* You could say that...] ->RoundTwo
 
 === RoundTwo ===
 You up for round two?
 
 * [Definitely] ->ThatsIt 
 * [N-No thanks, I'm good] ->Okay 
 
 === ThatsIt ===
 That's the spirit! 
 -She hands you a second shot of tequila-
  Drink up!
 
 * [*Drink*] ->DrankRound2
 
 === DrankRound2 ===
 Damn, that was good!
 Come'on let's go for another round!
 
 * [You...gots it!] ->DrinkRound3
 * [N-No thankshh...I'm *hic* good] ->MattDoneAfter2Alcohol
 
 === DrinkRound3 ===
 Hah! Good man!
 -She hands you a third shot of tequila-
 
 * [ No turnings...back *Drink*] ->DillonFindDrunkMatt
 
 === MattDoneAfter2Alcohol === 
 Heh yeah you're looking a little wobbly, nice drinking with ya man!
 
 * [Ssames to you...I'm gonna goes now...] ->MattLeaveAfter2
 
 === MattLeaveAfter2 ===
 See ya!
 
 * [*Leave*] ->MattThinkTipsy
 
 === MattThinkTipsy ===
 #speaker:Matt #portrait:Matt 
 Hmm...what's to do now?
 
 ->DONE 
 //Matt goes back to the normal bar area with 2 alcohol in his system, Cathy is locked, saying "She seems busy" thought when clicked on 
 
 === Okay ===
 Alright then.
 You did try to hold out, I can respect ya for that.
 See ya man!
 
 * [Thanks...See you *Leave*] ->MattThinksAfterOneDrink
 
 === MattThinksAfterOneDrink ===
 #speaker:Matt #portrait:Matt 
 Well, that was certainly an experience...
 ->DONE 
 //Matt is in the bar area and Cathy is now locked saying the thought "She seems busy" when clicked on, Matt has one alcohol in his system

 === HiIGuess ===
 Umm hi to you too?
 
 * [I'm gonna go now...] ->OkayThen
 
 === OkayThen ===
 O-kay then...
 
 * [*NEXT*] ->MattThinking 
 
 === MattThinking ===
 #speaker:Matt #portrait:Matt
 
 Well that was awkward...
 -Sigh-
 What should I do now?
 
 * [Go find Dillon] ->GoFindDillon
 * [Go order a drink] ->GoToBar
 
 === GoToBar ===
 May as well have something to drink while I'm here I guess...
 
 ->DONE 
 //Matt goes to look for the bar table, Cathy is now locked with the "She seems busy" thought when she's clicked on 
 
 === GoFindDillon ===
 I'll go look for Dillon, at least I won't stick out so much if I'm with him
 
 ->DONE 
 //Matt goes to find Dillon, Cathy now is locked with the "She seems busy" thought when she's clicked on 
 
 === DillonFindDrunkMatt ===
 Hey you don't look too good...
 You okay?
 
 * [*NEXT*] ->DillonArrive
 
 === DillonArrive ===
 #speaker:Dillon #portrait:Laid_Back
 Yo Matt, I was wondering where you got off to, I guess you managed to have some fun afterall?
 Woa-easy there bud, you're not looking so good... I think it's time to go home.
 
 * [Pfshhhh I'm fiiine...] ->HeDefNotFine 
 * [Yeah...I'm nots feeling that *retches* ] ->Yeesh
 
  === Yeesh ===
  Take it easy Matt, deep breaths. The car's not too far away.
  
  * [*Follow Dillon*] ->DONE 
  
  //go to car ride
 
  === HeDefNotFine === 
  What do you mean "fine"? You can barely keep yourself standing. 
  Come'on bud, let's get you home.
  
 * [You're not my dadshh, you can't tell me whats to do] ->CarryBoi
 * [*sigh and follow Dillon*] ->Attaboy

 === CarryBoi ===
 Matt, really? 
 
 -He picks you up and carries you over his shoulders-
 
 There we go. The car isn't too far, you'll be alright.
 
 ->DONE 
 
 //go to car ride

 === Attaboy ===
 Atta boy, come here -He puts your arm over his shoulder to lean against-
 
 ->DONE 
 
 //go to car ride
 
 
