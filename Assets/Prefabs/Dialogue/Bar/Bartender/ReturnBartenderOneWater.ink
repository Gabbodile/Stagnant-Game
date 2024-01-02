Hey, welcome back! What can I get for you sir? #speaker:Bartender #portrait:Bartender

* [Some more water please] ->BartenderWaterOfferWater
* [Hey! A shot of whisky thanks] ->BartenderWaterOfferAlcohol
* [Actually, I'm good for now] ->LeaveWithoutDrinking

=== BartenderWaterOfferWater ===
Sure thing.
Here you go.
- He hands you a second glass of water -

* [*Drink up*] ->TalkAfterTwoWater

=== TalkAfterTwoWater ===
Need something stronger? 

* [Yeah, some whisky if you have it, please?] ->BartenderTwoWaterOfferAlcohol
* [No thanks, can I get another glass of water though?] ->BartenderTwoWaterOfferWater
* [Yeah nah, I'm good for drinks for the moment thanks] ->LeaveAfterTwoWater

=== BartenderTwoWaterOfferAlcohol ===
Of course!
There you are.
- He hands you a shot of whisky -

* [Thanks *Drink*] ->TalkAfterTwoWaterOneAlcohol

=== TalkAfterTwoWaterOneAlcohol ===
...
You're looking a little uncomfortable there, did you need the bathroom? 
It's just on the right.

* [Yeah, thanks] ->NoProblemMattGoBathroom

=== NoProblemMattGoBathroom ===
No problem

* [*NEXT*] ->NoProblemMattGoBathroomContinued

=== NoProblemMattGoBathroomContinued ===
#speaker:Matt #portrait:Matt
Hmm Bathroom, Bathroom...

->DONE 
//Matt leaves the bartender after having two water then one alcohol

=== BartenderTwoWaterOfferWater
Yup, here you are.
- He hands you another glass of water -

* [*Drink*] ->TalkAboutBathroom 

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

=== BartenderWaterOfferAlcohol ===
Sure thing. 
Here you are.
- He hands you a shot of whisky -

* [Thanks *Drink*] ->TalkAfterWA 

=== TalkAfterWA ===
Can I get you anything else?

* [Another water please] ->GiveWAW
* [Another round of whisky please] ->GiveWAA
* [Nah, I'm done drinking for now] ->LeaveAfterWaterAlcohol 

=== GiveWAW ===
Sure.
Here you go.
- He hands you another glass of water -

* [Thanks *Drink*] ->TalkAfterTwoWaterOneAlcohol

=== GiveWAA ===
Can do, here you go.
- He hands you another shot of whisky -

* [*Drink*] ->HeDrankWAA

=== HeDrankWAA ===
...Are you alright there? 
You're looking a little uneasy, did you need the bathroom?

* [Uhmm...Probsably...] ->HeDrankWAAContinued

=== HeDrankWAAContinued ===
It's just on your right.
Might be good to rinse your face with some cold water while you're there.

* [Thankshh] ->MattThinkBathroomTipsyAfterWAA

=== MattThinkBathroomTipsyAfterWAA ===
#speaker:Matt #portrait:Matt
Uhh Bathroomss...man, I gotsta go soons...

->DONE
//Matt leaves the bartender after having one water and two alcohol, he is tipsy

=== LeaveAfterWaterAlcohol ===
All good, feel free to come back if you feel like having another one.

* [Thanks] ->DONE 
//Matt leaves the bartender after having one water and one alcohol in his system

=== LeaveWithoutDrinking ===
Ah okay, no problem.
Feel free to come back and order if you change your mind

* [Thanks] ->DONE
//Matt leaves Bartender without drinking anything but has one water in his system

=== LeaveAfterTwoWater ===
No worries, feel free to order another if you change your mind

* [Thanks] ->DONE 
//Matt leaves the bartender with two water in his system
