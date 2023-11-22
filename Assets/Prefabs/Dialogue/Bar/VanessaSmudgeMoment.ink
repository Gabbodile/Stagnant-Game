#speaker:Stranger #portrait:Vanessa_Smudged
...

 * [ - Stare Blankly - ] ->VanessaSmudgeDisappear
 * [Wait...] ->VanessaSmudgeDisappear

=== VanessaSmudgeDisappear ===
#speaker:Dillon #portrait:Dillon
Matt...?
Everything okay?

 * [Yeah I just thought I saw something...] ->AllGood
 * [I thought I saw her...] ->Whomst
 * [There was someone right there] ->Imagination

=== Imagination ===
Hmm...I can't see anyone, must've been your imagination

* [I know I saw someone] ->Denial
* [Maybe...] ->Anyway

=== Denial ===
Whether you did or not, there's no one there now. No use losing sleep over it.

* [Yeah...You're right] ->CarClose
* [I guess...] ->CarClose

=== CarClose ===
Come'on let's head home, the car isn't too far.

->DONE 

//go to car ride

=== Whomst ===
Saw who?

* [I...nevermind] ->AlrightThen
* [I'm not sure...] ->TrickOfTheLight

=== TrickOfTheLight ===
Huh, maybe it was just a trick of the light?

* [I guess...] ->Anyway 
* [...] ->Anyway 

=== Anyway ===
Well anyway, the car's just around the corner, we should head home. 

->DONE 

//go to car ride

=== AlrightThen ===
Alright then. Come'on, car's just around the corner.

->DONE

//go to car ride

=== AllGood ===
Ah okay all good. Car's just around the corner.

->DONE

//go to car ride








