INCLUDE GlobalFunctions.ink

// DO NOT WRITE EXTERNAL FUNCTIONS AS THE LAST LINE. this will lead to a blank line at the end of the dialouge. If you need an external function at the end of the dialouge, write it before the last line as seen in the badChoiceSelected example below.

-> main

=== main ===
Mario wonder releases this Friday! #speaker:Laid Back #portrait:Laid_Back
LAD Gaiden isn't too far off as well.
-> question

=== question ===
Which one are you getting?
    + [Mario Wonder]
        ~goodChoice(2)
        -> goodChoiceSelected("Mario Wonder")
    + [LAD Gaiden]
        ~goodChoice(1)
        -> goodChoiceSelected("LAD Gaiden")
    + [Forespoken]
        -> badChoiceSelected("Forespoken")

=== goodChoiceSelected(game)
You're getting {game}? Good choice. #speaker:Galaxy 2 #portrait:Test_SMG2
-> END

=== badChoiceSelected(game) ===
You're getting {game}? What the hell is wrong with you? #speaker:Judgement #portrait:Test_JE
 ~badChoice(5)
Get away from me!
-> END