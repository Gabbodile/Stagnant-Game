...Was this girl always here?#speaker:Matt #portrait:Matt

* [Are you okay?] ->TalkCryGirl
* [*Ignore her*] ->NotTalkToCry

 === NotTalkToCry ===
 #speaker:Matt #portrait:Matt
 None of my business, I'll leave her be. 
 
 * [*Leave*] ->DillonFindsYa

 === TalkCryGirl === 
 #speaker:Cathy #portrait:Cathy
 
  ...Oh-sorry, I just-I didn't see you there. 
  Did you need something?
 
 * [I know it's not my business but did something happen? You seem to be crying a lot.] ->DeflectQuestion
 * [No, not really Sorry.] ->EndConvo 
 
 === DeflectQuestion ===
 Oh...heh, yeah I just - wiping tears from eyes - I'm always such a screw-up at everything...with work, friends...even with the love of my life...
 I screwed it all up, it seems to be the only stupid thing I'm good for.
 
 * [No one is a complete screw up ya know, there must be something you enjoy right?] ->StartGoodConvo 
 * [Seems that way...] ->SadEndConvo
 
 === SadEndConvo ===
 ...
 I...I think I just want to be alone, sorry...
 
 * [Sorry, that's not what I meant] ->Rephrasing
 * [I understand... *Leave*] ->DillonFindsYa
 
 === Rephrasing ===
 ...
 - She waits expectantly -
 
 * [Feeling like you're screwing up in everything is normal, even if you're doing everything right] ->MattContinuesConvo 
 
 === MattContinuesConvo ===
 #speaker:Matt #portrait:Matt
 
 It's just a normal thing everyone goes through but it defineitely isn't a walk in the park either.
 ...
 I guess it's easier to handle when you're not overwhelmed thinking about it right?
 
 * [*NEXT*] ->ConvoContinuedAgain
 
 === ConvoContinuedAgain ===
 
 #speaker:Cathy #portrait:Cathy 
 You could say that...
 
 * [Would you like to talk about something you enjoy doing to get your mind off it? It might help a bit?] ->StartGoodConvo
 
 === EndConvo ===
Okay then...

* [*Leave*] ->DillonFindsYa

=== StartGoodConvo ===
I guess so...
Like hobbies and stuff?

* [Yeah, things you do in your pass-time for fun.] ->HobbyTalk 

=== HobbyTalk ===
- She sits up and stops crying -
Well...I like playing videogames and gardening...reading in the park is fun too.

 ->AskingHobbies1

=== AskingHobbies1 ===

* [What kind of videogames do you play?] ->AskingGaming

=== AskingGaming ===
I like to play first person shooters, Boom Killer is my favourite but I also like fantasy RPGs like the Legend of Lunk: Wind of the Outback.

* [Yeah those are pretty cool ones] ->AskingHobbies2
* [I personally prefer games like Monster Seeker] ->GettingAlong 
* [Kinda basic not gonna lie] ->EveryoneOppinionMean

=== GettingAlong ===
Oh yeah, that's a good one too -smiles-

->AskingHobbies2

=== EveryoneOppinionMean ===
Everyone has their own oppinion, it's just something I enjoy

* [Fair enough] ->AskingHobbies2
* [I guess so yeah...] ->AskingHobbies2

=== AskingHobbies2 ===

* [What kinds of plants have you grown?] ->AskGardening

=== AskingHobbies3 ===

* [What sorts of books do you read?] ->AskReading

=== AskingHobbies4 ===

* [*Finish asking about Hobbies*] ->DoneAskingHobbies

=== AskGardening ===
Oh not too many, just a few house plants, it's a more recent hobby I got into. Last week I managed to make it to 5 weeks without accidentally forgetting to water them. 
It's not much but I'm making progress at least - she laughs to herself -

* [Even small progress is still progress, it's something to be proud of] ->HappyAboutGardening
* [Be careful not watering plants, I've heard their behaviour can get pretty unbeleafable] ->FunnyBadJoke 
* [I think the plants would expect you to do better] ->GardeningMean

=== GardeningMean ===
Hey, I did say it was a recent hobby, I'm still learning

->AskingHobbies3

=== FunnyBadJoke ===
- Laughing - Okay that was funny but it's still bad.

* [*Laugh along*] ->AskingHobbies3
* [I'm trying my best here] ->Appreciative 

=== Appreciative ===
- Her laughing dies down - Sorry, I appreciate it

->AskingHobbies3

=== HappyAboutGardening ===
- She smiles - Thanks

->AskingHobbies3

=== AskReading ===
I've been really getting into the Five days at Benny's series lately, I love the mystery involved in it and the scary factor of it gives me goosebumps...but like in a good way ya know?

* [Yeah I get what you mean] ->HappyAboutReading
* [Wait you like it too? I thought it was just me, small world] ->NicetomeetFan
* [Not really, I'm not into horror] ->Spooked

=== Spooked ===
Well I suppose it's not for everyone, that's why people have made so many different genres to choose from

* [Yeah] ->AskingHobbies4

=== NicetomeetFan ===
It's nice to meet another fan of the series

* [Likewise] ->AskingHobbies4

=== HappyAboutReading ===
- She smiles -

->AskingHobbies4

=== DoneAskingHobbies ===
 #speaker:Cathy #portrait:Cathy
Thanks for helping me calm down...I'm Cathy by the way, what about you?

* [Matt, I'm glad I could help] ->SmileCathy

=== SmileCathy ===
- She smiles then looks away -
I really appreciate your help but...I feel like I'm still at square one. I'm no longer drinking my sorrows but I don't know where to go from here. 
With my life that is...

* [What do you mean?] ->QuestionCathy

=== QuestionCathy ===
I was once engaged to the love of my life but when it came to making the big decisions, I always hesitated, even the small decisions. 

They were the one always making the first move, always having to make the decisions for me cause I could never make up my mind.

I was never sure of what I wanted, I felt like there was never enough time to make risky decisions so I never made them, I stayed stagnant in my mind waiting for the decisions to be made for me...

But you can't exactly do that when it's your turn to say "I do" can you?

* [No, I suppose not] ->ContinueStory
* [*Say nothing*] ->ContinueStory 

=== ContinueStory ===
I broke their heart and in turn broke my own. My family, my friends, they won't even talk to me and my coworkers? They treat me like crap for messing things up as I always did.
I mean sure, I could go move countries and change my name but what would I do after that? 
I'm scared of overthinking every little thing and not being able to live my life, just being stuck in this endless loop.

* [It's only natural isn't it?] ->ExplainAdvice
* [Sorry I don't know how to help you with that] ->Dissapoint

=== Dissapoint ===
... 
That's alright, sorry it's not your problem to solve. I'm sure the answer will come to me eventually.

* [Good luck] ->EndConvoCathyButSober
* [Actually, I think I might know of something you can do.] ->ExplainAdvice

=== EndConvoCathyButSober ===
Thanks

* [*Leave*] ->DillonFindsYa 

 === DillonFindsYa ===
 #speaker:Dillon #portrait:Laid_Back
 
 Hey bud, I've been looking for ya. Guess who just showed up?
 
 * [Who?] ->Seenfound 

 === Seenfound ===
 Go on, have a look.
 
 ->DONE
 //Vanessa shows up 
 
=== ExplainAdvice ===
What do you mean?

* [*NEXT*] ->AdviceContinued

=== AdviceContinued ===

#speaker:Matt #portrait:Matt 

Well we're human beings, being afraid of the consequences of a bad decision is completely normal, we don't live forever so we don't wanna mess up. 
But if you never take any chances, you'll never get to experience what life truely has to offer. 
Maybe take up a job that requires you to do more decision making so you can get used to it.

* [*NEXT*] ->NeverThought

=== NeverThought ===
#speaker:Cathy #portrait:Cathy 

I guess you're right, yeah. I think I'll give that a try, thanks Matt.

* [No problem] ->NeverThoughtContinued

=== NeverThoughtContinued ===
Hey...Um, I know it's probably kind of sudden but would you like to maybe catch up for a coffee sometime?
 - She expresses a hopeful smile -
 
 * [Sure *Pull out phone and hand it to Cathy*] ->CathyGetNumber
 
 === CathyGetNumber ===
 - Her face lights up joyfully as she puts her number into your phone -
 There we go, now we can keep in touch.
 
 * [*Smile and nod*] ->GettingLate
 * [Yup] ->GettingLate
 
 === GettingLate ===
 Well it was nice getting to meet you but I should probably head off before it get's too late.
 
 * [Will you be alright getting home on your own?] ->CathySafeHome
 * [Right, same here. Take care Cathy] ->CathySayGoodbye
 
 === CathySayGoodbye ===
 Same to you, Matt. See ya.
 
 * [See ya] ->CathyLeavesContinued
 //Cathy leaves the scene and Vanessa is there
 
 === CathySafeHome === 
 Oh-yeah, I'll be fine, I know this area pretty well but thanks. Get home safe okay?
 
 * [Will do, and same to you] ->CathyLeaves
 
 === CathyLeaves ===
 Thanks, see ya.
 
 * [*Wave goodbye*] ->CathyLeavesContinued
 //Cathy leaves the scene and Vanessa is there
 
 === CathyLeavesContinued ===
 #speaker:??? #portrait:Vanessa 
 Matt? Is that you?
 
 ->DONE
 //Vanessa shows up and good ending happens and with Matt having Cathy phone number, the true good ending can happen when Matt wakes up 








