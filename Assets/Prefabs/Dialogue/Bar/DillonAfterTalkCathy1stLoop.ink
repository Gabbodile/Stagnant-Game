#speaker:Dillon #portrait:Dillon
Oh hey there you are! How did things go?

 * [She was fine...] ->NotYourType
 * [She was alright, a little bit intense for me though] ->NotYourType
 * [Not that great, I kind of just want to go home] ->ConvinceDrink

 === NotYourType ===
 Not your type eh?
 No worries bud, there's plenty of other fish in the sea.
 Say why don't we go for a drink?
 
 * [Maybe just one] ->HeyWayToGo
 * [Nah I think I'm ready to head off] ->YouSure
 
 === YouSure ===
 Oh you sure? Well alright, I guess we can head back.
 
 * [Actually you know what? One drink won't hurt] ->HeyWayToGo
 * [Thanks] ->Trippin

 === HeyWayToGo ===
 Atta boy. I grabbed one for ya while I was waiting. Here.
 
 * [Thanks *Drink*] ->MediumDrinkStrength
 
 === MediumDrinkStrength ===
 How is it?
 
 * [It's pretty good actually.] ->NeedAnother
 * [It's alright.] ->NeedAnother
 * [I've had better...] ->Agree 
 
 === Agree ===
 Yeah same. But you gotta admit it isn't too bad.
 
 * [I guess...] ->WantAnother
 * [Eh] ->WantAnother
 
 === WantAnother ===
 Well anyway, did you want another?
 
 * [Yeah] ->Drink2 
 * [Nah, I'm alright] ->NoWorries
 
 === NeedAnother ===
 Need another one?
 
 * [Sure] ->Drink2 
 * [No thanks, I'm okay] ->NoWorries 
 
 === Drink2 ===
 Here ya go 
 
 * [*Drink*] ->MattYouOkay
 
 === MattYouOkay ===
 Okay I think that's enough drinking for now. It's starting to get late, we should probably head off.
 
 * [Yeah...Hang on-What was that...?]
 ->DONE 
 //main bar shot. Smudge Vanessa shows up. 
 
 === NoWorries ===
 All good Matt, I guess we should probably head off soon anyway.
 Ready to go?
 
 * [Yeah-Wait...What was that?] 
 ->DONE 
 //main bar shot. Smudge Vanessa shows up.
 
 === Trippin ===
 It's not too far to the car
 
 * [Wait...what was that?]
 ->DONE 
 //main bar shot. Smudge Vanessa shows up.
 
 === ConvinceDrink ===
 Oh you sure? I'm sorry you're not having a good time, wanna just have something small to drink?
 
 * [Yeah I guess it couldn't hurt] ->HeyWayToGo
 * [No thanks, I want to just go home] ->AllGood
 
 === AllGood ===
 All good man, we can head back to the car.
 
 * [Wait...what was that?] 
 ->DONE
 //main bar shot. Smudge Vanessa shows up
 