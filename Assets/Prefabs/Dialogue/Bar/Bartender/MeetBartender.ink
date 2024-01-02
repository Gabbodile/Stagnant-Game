Hey there, what can I get for you tonight? #speaker:Bartender #portrait:Bartender

* [A shot of whisky please] ->WhiskyOffer1
* [Actually, I'd just like some water] ->WaterOffer1

=== WhiskyOffer1
Sure thing sir.
Here you are. - He hands you a shot of whisky -

* [Thanks *take a drink*] ->DrankAlcohol1

=== DrankAlcohol1 ===
Been a long day?

* [Yeah, you could say that...] ->LaughTalkOfferAfterOneAlcohol
* [Kinda] ->UnderstandableTalkOfferAfterOneAlcohol

=== UnderstandableTalkOfferAfterOneAlcohol ===
- He smiles to himself -
Another round?

* [Yeah, same as before please] ->AlcoholOffer2
* [Yes please, some water this time] ->OneAlcoholThenOfferWater
* [Nah, I'll be good for drinks for now but thanks] ->LeaveAfterOneAlcohol

=== LaughTalkOfferAfterOneAlcohol ===
Heh, sounds like you might need another round?

* [Yeah please] ->AlcoholOffer2
* [Actually, I think I'll just have a water] ->OneAlcoholThenOfferWater
* [Nah, I'm good for drinks for now but thanks anyway] ->LeaveAfterOneAlcohol

=== OneAlcoholThenOfferWater ===
No worries, here you go.
- He hands you a glass of water -

* [*Drink water*] ->TalkAfterOneAlcoholOneWater

=== TalkAfterOneAlcoholOneWater ===
Anything else I can get for you tonight?

* [Yeah, one more shot of whisky please] ->OneAlcoholOneWaterThenOneAlcohol
* [Another glass of water thanks] ->OneAlcoholOneWaterThenOneWater
* [No thanks, I'm alright] ->LeaveAfterOneAlcoholOneWater

=== OneAlcoholOneWaterThenOneAlcohol ===
Yup, here you are.
- He hands you a second shot of whisky -

* [*Drink*] ->TalkAboutBathroomAfterAWA

=== TalkAboutBathroomAfterAWA ===
...
You doing alright there? You're looking a little tipsy

* [Yeashh...Uhh...I needs the bathroom...] ->TalkAboutBathroomAfterAWAContinued

=== TalkAboutBathroomAfterAWAContinued ===
Oh, sure thing.
It's just on your right, might be good to rinse your face with some cold water while you're there.

* [Thankshh] ->MattThinkBathroomTipsy

=== MattThinkBathroomTipsy ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having two alcohol and one water, he is tipsy

=== OneAlcoholOneWaterThenOneWater ===
Yup, here you are.
- He hands you another glass of water -

* [*Drink water*] ->TalkAboutBathroomAfterAWW

=== TalkAboutBathroomAfterAWW ===
...
You're looking a little uncomfortable, need the bathroom?

* [Yeah actually] ->DirectionsToBathroomAfterAWW

=== DirectionsToBathroomAfterAWW ===
Just on your right, there.
Have a good one.

* [Thanks, same to you] ->SameToYou

=== SameToYou ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having one alcohol then two water

=== LeaveAfterOneAlcoholOneWater ===
- He nods his head and smiles -

->DONE 
//Matt leaves the bartender after having one alcohol and one water

=== AlcoholOffer2 ===
No worries, here you are.
- He hands you a second shot of whisky -

* [*Drink up*] ->TalkAfterTwoAlcohol

=== TalkAfterTwoAlcohol ===
You doing alright there?

* [Yessh...Another whisky pleaase?] ->AreYouSure
* [Mmm...I...Think so?] ->SuggestWater
* [Yeah...I thinks I'm done for now...] ->OkayTakeCare

=== AreYouSure ===
A-Are you sure...? I don't think that would be a good idea sir...

* [I needs another...you wouldn't *hicc* understand...] ->GiveLecture
* [Okay fiiiine, jush a waatah pleasee] ->SuggestWater
* [May-be you're rights...I thinks *hicc* that's enouff] ->MattLeaveAfterTwoAlcohol

=== SuggestWater ===
Yeah I think some water would do you good, here.
- He hands you a glass of water -
Drink up. 

* [Thankshh *Drink water*] ->AskBathroomWhileTipsy

=== AskBathroomWhileTipsy ===
Might be good to get some cold water on your face while you're at it.
Bathroom is just on your right.

* [Yesss...I needed to go anyways, tank you...] ->YoureWelcome

=== YoureWelcome ===
You're welcome sir...

* [*NEXT*] ->MattThinkBathroomTipsy

=== GiveLecture ===
Sir, I think I do understand...
I may not have gone through the exact same things you're going through in your personal life but I've seen what this kind of reckless behaviour does to people.

* [*NEXT*] ->ContinueLecture

=== ContinueLecture ===
This bar has seen many poor men and women come to drink their lives away and the result is never pretty.
Whatever you're dealing with, you need to face it head on, alcohol won't solve it.

* [I don't wants a lecture. Jusht one lasht drink...please...?] ->FineGiveUp
* [...I...Sorry...I thinks I'll jusst go washh up] ->AskBathroom

=== AskBathroom ===
- He nods his head -
Bathroom is on your right

* [*NEXT*] ->MattLeaveAfterTwoAlcohol 

=== FineGiveUp ===
- Sigh - 
Alright, fine...
There's no use in trying to help someone who doesn't want it.
...
- He reluctantly hands you a third shot of whisky -

* [*Drink up* ] ->HeDrankTooMuch

=== HeDrankTooMuch ===
#speaker:Matt #portrait:Matt
...!?
I... - retches -
I don't feel so... - Vomits -

* [*NEXT*] ->HeDrankTooMuchContinued

=== HeDrankTooMuchContinued ===
#speaker:Dillon #portrait:Laid_Back
Matt!?
Hey are you okay bud?

* [No...] ->DillonHelpHimUp
* [*Groan*] ->DillonHelpHimUp

=== DillonHelpHimUp ===
Hey, take it easy, let me help you up there...
- He puts your arm over his shoulders and lifts you to your feet - 

* [*NEXT*] ->DillonSorry

=== DillonSorry ===
#speaker:Bartender #portrait:Bartender

Long time no see Dillon...

* [*NEXT*] ->DillonSorryContinued

=== DillonSorryContinued ===
#speaker:Dillon #portrait:Laid_Back

Hey man, yeah...
Uhh...really sorry about my friend here, he's not normally like this...
I'll take his drinks under my TAB

* [*NEXT*] ->BartenderResponseToDillon

=== BartenderResponseToDillon ===
#speaker:Bartender # portrait:Bartender

He's a deeply troubled one, that's for sure
It seems like he needs all the help he can get

* [*NEXT*] ->BarResponseContinued

=== BarResponseContinued ===
#speaker:Dillon #portrait:Laid_Back
Yeah, working on that...
Anyway, best be getting him home, again sorry about the trouble

* [*NEXT*] ->BarResponseContinuedAgain

=== BarResponseContinuedAgain ===
#speaker:Bartender #portrait:Bartender
- He nods his head - 

* [*Next*] ->BringMattToCar

=== BringMattToCar ===
#speaker:Dillon #portrait:Laid_Back
- Sigh -
What am I gonna do with ya bud?
Let's get you to the car

->DONE
//Matt has been taken to the car to be driven home, he is drunk 

=== OkayTakeCare ===
Yeah...you seem a little bit tipsy...
Try getting your face with some cold water, it might help?
Bathroom's just on your right.

* [Thankssh] ->MattLeaveAfterTwoAlcohol

=== MattLeaveAfterTwoAlcohol ===
#speaker:Matt #portrait:Matt
Hmmm...I really sooden't be drinking so mush...
Wheresh *Hic* bathroom again...?

->DONE
//Matt leaves bartender after two alcohol and is now tipsy


=== LeaveAfterOneAlcohol ===
No problem, bar will be open for a while so feel free to order another when you're ready

->DONE 
//Matt leaves the bartender after having one alcohol

=== WaterOffer1 ===
Sure thing sir.
Here you are. - He hands you a glass of water -

* [Thanks *take a drink*] ->DrankWater1

=== DrankWater1 ===

...

* [*Drink more water*] ->DrankMoreWater1
* [*Close eyes and take in the atmosphere*] ->TakeInAtmosphereAfterWater

=== DrankMoreWater1 ===
Thirsy eh?

* [Yeah, you could say that] ->LetHimWater
* [*Finish drinking water*] ->TakeThatAsYes

=== LetHimWater ===
 Well, I'll let you have your drink in peace, let me know if you want anything else
 
 * [Thanks *Finish water*] ->TalkAfterOneWater
 
 === TalkAfterOneWater ===
 ...
 
 * [A round of whisky please] ->OneWaterThenOfferOneAlcohol
 * [Another water if that's alright?] ->WaterOffer2
 * [No thanks, I'll be alright for now] ->LeaveAfterOneWater

=== TakeThatAsYes ===
Heh, I'll take that as a yes.
Would you like something else to drink?

* [A round of whisky please] ->OneWaterThenOfferOneAlcohol
* [Another water if that's alright?] ->WaterOffer2
* [No thanks, I'll be alright for now] ->LeaveAfterOneWater

=== OneWaterThenOfferOneAlcohol ===
Sure thing.
Here you go.
- He hands you a shot of whisky -

* [Thanks *Drink*] ->TalkAfterOneWaterOneAlcohol

=== TalkAfterOneWaterOneAlcohol ===
Anything else I can get for you tonight?

* [Yes please, one more round of whisky] ->OneWaterOneAlcoholThenOfferOneAlcohol
* [Yeah, another glass of water please] ->OneWaterOneAlcoholThenOfferOneWater
* [No thanks, I'll be alright for now] ->LeaveAfterOneWaterOneAlcohol

=== OneWaterOneAlcoholThenOfferOneWater ===
Here you are.
- He hands you a second glass of water -

* [*Drink*] ->TalkAboutBathroomAfterWAW

=== TalkAboutBathroomAfterWAW ===
...
You're looking a little uncomfortable there, do you need the bathroom?
It's just on your right.

* [Yes actually, thanks] ->NoProblemMattGoBathroomWAW

=== NoProblemMattGoBathroomWAW ===
No problem

* [*NEXT*] ->NoProblemMattGoBathroomContinuedWAW

=== NoProblemMattGoBathroomContinuedWAW ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having one water, one alcohol then one water

=== OneWaterOneAlcoholThenOfferOneAlcohol ===
Yup, here you are.
- He hands you a second shot of whisky -

* [*Drink*] ->TalkAboutBathroomAfterWAA

=== TalkAboutBathroomAfterWAA ===
...
You doing alright there? You're looking a little tipsy

* [Yeashh...Uhh...I needs the bathroom...] ->TalkAboutBathroomAfterWAAContinued

=== TalkAboutBathroomAfterWAAContinued ===
Oh, sure thing.
It's just on your right, might be good to rinse your face with some cold water while you're there.

* [Thankshh] ->MattThinkBathroomTipsyAfterWAA

=== MattThinkBathroomTipsyAfterWAA ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having one water and two alcohol, he is tipsy

=== LeaveAfterOneWaterOneAlcohol ===
- He nods his head and smiles - 

->DONE
//Matt leaves the bartender after having one water and one alcohol 

=== LeaveAfterOneWater ===
- He nods his head -

->DONE 
//Matt leaves bartender after having one water

=== WaterOffer2 ===
Yup, no worries.
Here you go. - He hands you a second glass of water -

* [Thanks *Drink up*] ->TalkAboutWaterThree

=== TalkAboutWaterThree ===
Anything else for tonight? 

* [A shot of whisky thanks] ->OneWaterOneWaterThenOfferOneAlcohol
* [Some more water please] ->WaterOffer3
* [No thanks, I'm good for the moment] ->LeaveAfterTwoWater

=== OneWaterOneWaterThenOfferOneAlcohol ===
Here you are.
- He hands you a shot of whisky -

* [*Drink*] ->TalkAboutBathroomAfterWWA

=== TalkAboutBathroomAfterWWA ===
...
You're looking a little uncomfortable there, do you need the bathroom?
It's just on your right.

* [Yes actually, thanks] ->NoProblemMattGoBathroom

=== NoProblemMattGoBathroom ===
No problem

* [*NEXT*] ->NoProblemMattGoBathroomContinued

=== NoProblemMattGoBathroomContinued ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having two water then one alcohol

=== LeaveAfterTwoWater ===
- He nods his head and smiles -

->DONE
//Matt leaves bartender after having two water

=== WaterOffer3 ===
Sure. 
- He hands you a third glass of water -

* [*Drink up*] ->TalkAboutBathroom

=== TalkAboutBathroom ===
...
You look a little uncomfortable there, bathroom is just on your right if you need it.

* [Thanks, I was just about to ask actually] ->LeaveAfterThreeWater

=== LeaveAfterThreeWater ===
Heh no worries sir, have a good one.

* [*NEXT*] ->MattThinkBathroomNormal

=== MattThinkBathroomNormal ===
#speaker:Matt #portrait:Matt
Bathroom...Bathroom...

->DONE
//Matt leaves bartender after three water and looks for bathroom, can't talk to anyone without going to bathroom now

=== TakeInAtmosphereAfterWater ===
Everything alright there? You look a bit tense...
 
 * [Yeah just remembering the nostalgia of this place] ->TalkNostalgia
 * [Just a long day at work is all...] ->LongDayWork
 
 === LongDayWork ===
 Ah I understand. Did you want something a little stronger?
 
 * [Yeah please, a round of whisky] ->OneWaterThenOfferOneAlcohol
 * [No thanks, I think I'd rather just stick to this *Drink water*] ->LetHimWater
 
 === TalkNostalgia ===
 Ah you used to come here often?
 
 * [Heh yeah something like that...] ->LetHimWater
 * [Yeah it's different from what I remember but it still feels just as it did back then] ->ISee
 
 === ISee ===
 I see. Well the place has had some recent rennovations and change of management, I'm glad it still meets the same expectations as it did back then.
 
 * [Yeah] ->AnywayLetDrinkWater
 * [Same] ->AnywayLetDrinkWater
 
 === AnywayLetDrinkWater ===
 Anyway, I'll let you have your drink in peace. Let me know if you need anything.
 
 * [*Thank and finish drinking*] ->TalkAfterOneWater 
 
 


 



