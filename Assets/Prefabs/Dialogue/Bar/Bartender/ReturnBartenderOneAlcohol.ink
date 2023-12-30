Hey, welcome back! What can I get for you sir? #speaker:Bartender #portrait:Bartender

* [A shot of whisky thanks] ->OneAlcoholThenOfferAlcoholCathy
* [A glass of water please] ->OneAlcoholThenOfferWaterCathy
* [Actually, I'm good for now] ->LeaveWithoutDrinking

=== OneAlcoholThenOfferAlcoholCathy
Sure thing sir.
Here you are. 
- He hands you a shot of whisky -

* [Thanks *Drink up*] ->TalkAfterAACathy

=== TalkAfterAACathy ===
Uhh...Are you feeling alright there? 

* [Yessh...Another whisky pleaase?] ->AreYouSure
* [Mmm...I...Think so?] ->SuggestWater
* [Yeah...I thinks I'm done for now...] ->OkayTakeCare

=== AreYouSure ===
A-Are you sure...? I don't think that would be a good idea sir...

* [I needs another...you wouldn't *hicc* understand...] ->GiveLecture
* [Okay fiiiine, jush a waatah pleasee] ->SuggestWater
* [May-be you're rights...I thinks *hicc* that's enouff] ->MattLeaveAfterTwoAlcohol

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

=== SuggestWater ===
Yeah I think some water would do you good, here.
- He hands you a glass of water -
Drink up. 

* [Thankshh *Drink water*] ->AskBathroomWhileTipsy

=== AskBathroomWhileTipsy ===
Might be good to get some cold water on your face while you're at it.
Bathroom is just on your right.

* [Yesss...tank youss...] ->YoureWelcome

=== YoureWelcome ===
You're welcome sir...

* [*NEXT*] ->MattThinkBathroomTipsy

=== MattThinkBathroomTipsy ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having two alcohol and one water, he is tipsy

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

=== OneAlcoholThenOfferWaterCathy ===
Sure, here you are.
- He hands you a glass of water -

* [Thanks *Drink*] ->TalkAfterAWCathy

=== TalkAfterAWCathy ===
Can I get you anything else?

* [Just a shot of whisky please] ->AWCathyOfferAlcohol
* [Some more water?] ->AWCathyOfferWater
* [No thanks, I'll be alright] ->LeaveAfterAW 

=== AWCathyOfferWater ===
Sure thing sir.
- He hands you another glass of water - 

* [*Drink*] ->NeedBathrromNormal

=== NeedBathrromNormal ===
You're looking a bit uncomfortable...did you need the bathroom?

* [Yeah actually] ->DirectionsToBathroomAfterAWW

=== DirectionsToBathroomAfterAWW ===
It's just on your right, there.
Have a good one.

* [Thanks, same to you] ->SameToYou

=== SameToYou ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having one alcohol then two water

=== AWCathyOfferAlcohol ===
Yup, there you are.
- He hands you a shot of whisky -

* [*Drink*] ->LookingTipsy

=== LookingTipsy ===
You're looking a little uncomfortable there, did you need the bathroom?

* [Yessh tanks...] ->AskBathroomWhileTipsy

=== LeaveAfterAW ===
All good, feel free to come back to order if you change your mind

* [Thanks] ->DONE
//Matt leaves Bartender one Alcohol and one water

=== LeaveWithoutDrinking ===
Ah okay, no problem.
Feel free to come back and order if you change your mind

* [Thanks] ->DONE
//Matt leaves Bartender without drinking anything but has one Alcohol in his system

