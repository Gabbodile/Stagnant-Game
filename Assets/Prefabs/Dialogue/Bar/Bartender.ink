Hey there, what can I get for you tonight? #speaker:Bartender #portrait:Bartender

* [Oh umm something light?] ->SomethingLight
* [Got anything strong?] ->SomethingStrong
* [Actually I'd just like some water] ->DrinkWater

 === DrinkWater ===
 Sure thing sir. 
 Here you are. - He hands you a glass of water -
 
 * [Thanks *take a drink*] ->WaterDrinking1
 
  === WaterDrinking1 ===
  ...
  
 * [*Drink more water*] ->WaterDrinking2
 * [*Close eyes and take in the atmosphere*] ->TakeInAtmosphere
 
 === TakeInAtmosphere ===
 Everything alright there? You look a bit tense...
 
 * [Yeah just remembering the nostalgia of this place] ->RememberNostalgia
 * [Just a long day at work is all...] ->LongDayWork
 
 === LongDayWork ===
 Ah I understand. Did you want something a little stronger?
 
 * [Yeah actually, might be good] ->OfferDrinkAgain
 * [No thanks, I think I'd rather just stick to this *Drink water*] ->NoWorries
 
 === NoWorries ===
 No worries, let me know if you change your mind.
 
 * [Thanks *Finish water*] ->AskBathroom
 * [Actually I might take you up on that] ->OfferDrinkAgain
 
 === RememberNostalgia ===
 Ah you used to come here often?
 
 * [Heh yeah something like that...] ->HaveGoodOne
 * [Yeah it's different from what I remember but it still feels just as it did back then] ->ISee
 
 === HaveGoodOne ===
 Well, I'll let you have your drink in peace, let me know if you want anything else
 
 * [Thanks *Finish water*] ->AskBathroom
 
 === ISee ===
 I see. Well the place has had some recent rennovations and change of management, I'm glad it still meets the same expectations as it did back then.
 
 * [Yeah] ->AnywayLetDrinkWater
 * [Same] ->AnywayLetDrinkWater
 
 === AnywayLetDrinkWater ===
 Anyway, I'll let you have your drink in peace. Let me know if you need anything.
 
 * [*Thank and finish drinking*] ->AskBathroom
 * [Thanks, could I get another drink?] ->OfferDrinkAgain
 
 === WaterDrinking2 ===
 Thirsty eh? 
 
 * [Yeah, you could say that] ->WaterDrinking3
 * [*Finish water*] ->OkayThen
 
 === WaterDrinking3 ===
 Heh, all good. If you want anything else to drink, just let me know.
 
 * [*Nod head and finish drinking water*] ->AskBathroom
 * [Thanks. Speaking of, can I get something else drink?] ->OfferDrinkAgain
 
 === AskBathroom ===
 Oh yeah, if you need the bathroom, it's just on your right.
 
 * [Thanks] ->NoProblem
 
 === NoProblem ===
 No problem
 
 * [Hey actually can I get another drink?] ->OfferDrinkAgain
 * [*Leave*] ->LeaveAfterWater

 === OfferDrinkAgain ===
 Sure thing.
 What'll you be having?
 
 * [Something light] ->SomethingLight
 * [Something strong] ->SomethingStrong
 
 === SomethingStrong ===
 Here you go.
 
 * [Thanks *Drink*] ->StrongDrinkAgainOffer
 
 === StrongDrinkAgainOffer ===
 How are you feeling? That one was one of our stronger ones so I'll only be able to give you something weaker if you want another drink.
 
 * [That's alright, I'm done drinking...Not feeling too great.] ->NoProblemBathroomThere
 * [Yeah I'd like another please] ->SomethingStrongSomethingWeak
 
 === NoProblemBathroomThere ===
 No problem, bathroom is on your right if you need it.
 
 * [Thanks *Leave*] ->LeaveAfterVeryDrunk
 
 === SomethingLight ===
 Alright here you are 
 
 * [Thanks *Drink*] ->LightDrink1
 
 === LightDrink1 ===
 Anything else?
 
 * [Another round please] ->LightDrink2Handed
 * [Something stronger this time] ->LightStrongComboHanded
 * [No thanks, I'm alright. I'm done drinking for now] ->CoolCool
 
 === LightStrongComboHanded ===
 Alright then, here you go.
 
 * [Thanks *Drink*] ->LightStrongDrinkAreSure
 
 === LightStrongDrinkAreSure ===
 I think that'll be enough for you, you're looking a bit drunk...
 
 * [Yeah...I'm done for the night.] ->NoWorriesBathroomThere
 * [No, I want another one.] ->NotGoodIdea
 
 === NotGoodIdea ===
 I don't think that's a good idea sir, you need to slow down.
 
 * [I don't want to slow down, I want another drink.] ->AbsolutelyNot
 * [Sorry, you're right...Where's the bathroom?] ->JustOnTheRight
 
 === JustOnTheRight ===
 Just on the right.
 
 * [Thanks *Leave*] ->LeaveAfterSlightDrunk
 
 === NoWorriesBathroomThere ===
 No worries, try rinsing your face with some water. It'll help.
 
 * [*Nod head*] ->SuggestBathroom
 
 === SuggestBathroom ===
 Bathroom is on your right.
 
 * [Thanks] ->LeaveAfterSlightDrunk
 
 === CoolCool ===
 Alright then, bathroom's just on your right if you need it. Let me know if you want something else to drink.

* [Thanks *Leave*] ->LeaveAfterWater
* [I'd like something else to drink] ->Sure

 === Sure ===
 Sure, what'll it be?
 
 * [Something light] ->LightDrink2Handed
 * [Something strong] ->SomethingLightSomethingStrong
 
 === SomethingLightSomethingStrong ===
 Here you go.
 
 * [Thanks *Drink*] ->ProbablyWashUp
 
 === ProbablyWashUp ===
 I think you've had enough to drink tonight.
 
 * [It sure feels like it...] ->BathroomHelps
 * [I'm not done yet, get me another.] ->Denied
 
 === BathroomHelps ===
 Yeah try washing up, it'll help you feel better. Bathroom's on your right.
 
 * [Thanks *Leave*] ->LeaveAfterVeryDrunk
 
 === LightDrink2Handed ===
 Here you go.
 
 * [Another please *Drink*] ->YouSure
 * [*Drink* I'm done now ] ->AlrightBathroomThere
 
 === AlrightBathroomThere ===
 Alright then, bathroom is on your right in case you need it. Let me know if there's anything else you need.
 
 * [Thanks *Leave*] ->LeaveAfterWater
 * [Actually one more drink couldn't hurt...] ->YouSure
 
 === YouSure ===
 Hey are you sure? You're looking a bit tipsy...
 
 * [I want another drink] ->FineLightDrinkFinal
 * [Maybe you're right...] ->CalmDownOfferBathroom
 
 === CalmDownOfferBathroom ===
 Bathroom is on your right, try rinsing your face with some water, it'll help.
 
 * [Thanks *Leave*] ->LeaveAfterSlightDrunk
 * [No, I want one more...] ->FineLightDrinkFinal
 
 === FineLightDrinkFinal ===
 Alright but you need to take it easy...
 Here.
 
 * [*Drink* I want another ] ->Denied
 * [*Drink* I don't feel too good] -> SendHimBathroomWillingly
 
 === Denied ===
 No, you've had too much already. Go wash up in the bathroom.
 
 * [I want another NOW.] ->AbsolutelyNot
 * [Fine *Leave*] ->LeaveAfterSlightDrunk
 
 === AbsolutelyNot ===
 Look sir, I don't know what kind of problems you're dealing with in your personal life but drinking everything away is NOT going to help you.
 We've seen many a poor men and women down on their luck come through here and the result is never pretty. 
 You need to sober up if you want to even start to deal with your issues.
 
 * [...] ->ContinueAbsolutelyNot
 
 === ContinueAbsolutelyNot ===
 I'm not responsible for what you do with your life but I will not be serving you any more drinks tonight, I suggest you either sober up or leave.
 
 * [Sorry...I didn't mean to cause trouble] ->BathroomFind
 * [I understand...] ->GoodFindBathroom
 
 === GoodFindBathroom ===
 Good, bathroom is on your right.
 
 * [Thanks... *Leave*] ->LeaveAfterVeryDrunk
 * [*Leave*] ->LeaveAfterVeryDrunk
 
 === BathroomFind ===
 - Nods head -
 Bathroom is on your right.
 
 * [Thanks... *Leave*] ->LeaveAfterVeryDrunk
 * [*Leave*] ->LeaveAfterVeryDrunk
 
 === SendHimBathroomWillingly ===
 Go to the bathroom and wash up, don't push yourself.
 
 * [*Leave*] ->LeaveAfterSlightDrunk
 
 
 === SomethingStrongSomethingWeak ===
 Here you go.
 
 * [*Drink*] ->SomethingStrongSomethingWeakDrink
 
 === SomethingStrongSomethingWeakDrink ===
 Okay that'll have to be your last one for the night, you're looking a bit drunk.
 
 * [Yeah, I'm not feeling too great, where's the bathroom again?] ->JustOnTheRight
 * [No, I need another one] ->NotGoodIdea

 === OkayThen ===
 ...I guess so
 
 ->LeaveAfterWater
 
 === LeaveAfterSlightDrunk ===
 #speaker:Matt #portrait:Matt
 Bathroom...Bathroom...
 
 ->DONE
 //go to bar bathroom
 
 === LeaveAfterVeryDrunk ===
 Bathroom...Everything feels so nausiating...
 ->DONE
 //go to bathroom
 
 === LeaveAfterWater ===
 Damn I need the bathroom...
 ->DONE
 //go to bar bathroom
 



