#speaker:Vanessa #portrait:Vanessa
Matt? - she looks you up and down and seems disgusted by your state - 
Heh, just as I began to THINK that I could talk to you to sort things out, you're busy making an absolute fool of yourself, once again...
I don't know why I'm even surprised.

* [V-Vanessa, wait, I can explain...] ->TryExplain
* [...] ->GetScolded

 === GetScolded ===
 Not talking now huh? 
 After all this time, I would've thought you'd have at least tried to pull your shit together but I guess even that expectation was too high for you to meet.
 
 * [I'm trying okay!?] ->Annoyed
 * [I'm sorry I know what I did was wrong...What I'm doing is wrong...] ->ThenWhy

 === TryExplain ===
 Explain? Really Matt? What could you possibly say that would redeem yourself in this situation?

* [I'm still processing things, you're not the only one who was hurt you know] ->Annoyed
* [I don't actually have an explanation, I'm sorry...] ->Dissapointed 

 === Dissapointed ===
 - sigh - Matt, I had hoped that you wouldn't pull this sort of thing again, I just...I can't do this anymore

* [Vanessa please, I can change] ->Butwillyou
* [I'm sorry...] ->SoAmI

 === Annoyed ===
 That's seriously what you're going with? Enough with the bullshit excuses okay!? 
 I tried to work things out with you, I gave you time, I gave you space, I gave you all that I could give and yet you gave me nothing in return but half-assed excuses for things that were entirely your fault.
 
 * [Vanessa I...] ->Dissapointed

 === ThenWhy ===
 Then why are you still doing it? Acting the same as you did back then when times got tough, you'd just give up.
 
 * [I really am trying...] ->Doesntlooklikeit 
 * [...] ->Dissapointed

 === Doesntlooklikeit ===
 It doesn't look like it...
 
 * [...] ->Dissapointed

 === Butwillyou ===
 I know you can Matt...the question is, "Will you?"

* [...] ->GoodbyeMatt

 === GoodbyeMatt ===
 I suggest you do it for your own sake.
 Goodbye Matt...
 
 * [Bye...] ->MattFInTheChat
 * [...] ->MattFInTheChat

 === SoAmI ===
 So am I... 
 Goodbye Matt...

* [...] ->MattFInTheChat

 === MattFInTheChat ===
 #speaker:Dillon #portrait:Dillon
 That was painfull to watch... 
 You okay there Matt?
 
 * [I...don't know] ->CalmOfferHome
 * [Not really] ->OfferGoHome
 
  === CalmOfferHome ===
  Yeah I don't blame ya... 
  It's probably best if we just head home, you look like you could do with some rest
  
  * [Yeah probably right...] ->FollowDillon
  * [Maybe another drink before I go?] ->NoDrinkBro
  
  === NoDrinkBro ===
  I'm gonna have to say no to that, you need water and sleep, we've got work in the morning remember?
  
  * [Right...] ->FollowDillon
  * [No?] ->Seriously
  
  === Seriously ===
  Matt seriously, no more drinks, I'm taking you home.
  
  * [Okay fine...] -> NoThankyou
  
  === NoThankyou ===
  Not even a thank you?
  
  * [Sorry, thanks] ->Thatsbetter
  
  === Thatsbetter ===
  There we go.
  
  ->FollowDillon
  
   === OfferGoHome ===
   Yeah you look pretty out of it. I'll take you home okay bud?
   
   * [Thanks...] ->FollowDillon

 === FollowDillon ===
 The car's not too far, just around the corner.
 
 ->DONE
 //go to car ride



