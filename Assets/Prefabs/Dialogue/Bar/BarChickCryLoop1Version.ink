...Was this girl always here?#speaker:Matt #portrait:Matt

* [Are you okay?] ->TalkCryGirl
* [*Ignore her*] ->NotTalkToCry

 === NotTalkToCry ===
 #speaker:Matt #portrait:Matt
 None of my business, I'll leave her be. 
 
 ->DillonCatchesYa

 === TalkCryGirl === 
 #speaker:... #portrait:Cathy
 
  ...Oh-sorry, I just-I didn't see you there. 
  Did you need something?
 
 * [I know it's not my business but did something happen? You seem to be crying a lot.] ->DeflectQuestion
 * [No, not really Sorry.] ->EndConvo 
 * [Nope, just passing through.] ->SadEndConvo
 
 === DeflectQuestion ===
 Oh...heh, yeah I just - wiping tears from eyes - I'm always such a screw-up at everything...with work, friends...even with the love of my life...
 I screwed it all up, it seems to be the only stupid thing I'm good for.
 
 * [No one is a complete screw up ya know, there must be something you enjoy right?] ->StartGoodConvo 
 * [*Back away slowly*] ->SadEndConvo
 * [Seems that way] ->SadEndConvo
 
 
 === SadEndConvo ===
 ...
 
 ->DillonCatchesYa
 
 === EndConvo ===
Okay then...

->DillonCatchesYa

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

* [Yeah those are pretty cool ones] ->SmilingCathy
* [I personally prefer games like Monster Seeker] ->GettingAlong 
* [Kinda basic not gonna lie] ->EveryoneOppinionMean

=== SmilingCathy ===
- She smiles -

->AskingHobbies2

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
* [...] ->ContinueStory 

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

=== ExplainAdvice ===
What do you mean?

* [Well we're human beings, being afraid of the consequences of a bad decision is completely normal, we don't live forever so we don't wanna mess up. But if you never take any chances, you'll never get to experience what life truely has to offer. Maybe take up a job that requires you to do more decision making so you can get used to it.] ->NeverThought

=== NeverThought ===
I guess you're right, yeah. I think I'll give that a try, thanks Matt.

* [No problem, I should head off soon. It was nice chatting with you] ->Same 

=== Same ===
Same to you.

* [*Leave* ] ->DillonFindsYa 

=== DillonCatchesYa ===
#speaker:Matt #portrait:Matt 
 - Stumbling - 
 
 #speaker:Dillon #portrait:Laid_Back
 Yo Matt, I was wondering where you got off to.
 Woa easy there bud, you're not looking so good... I think it's time to go home.
 
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

=== DillonFindsYa ===
#speaker:Dillon #portrait:Laid_Back
 Hey bud, I've been looking for ya. It's getting a bit late, we should head off.
 
 * [Sure.] ->CarClose
 
 === CarClose ===
 Car's just around the corner.
 
 * [*Follow Dillon*] ->DONE
 
 //go to car ride
