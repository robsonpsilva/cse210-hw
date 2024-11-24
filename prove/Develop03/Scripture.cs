
class Scripture
{
    List<Reference> reference = new List<Reference>();

    public Scripture()
    {
        //Exceeding Requirements 
        //Loading the first reference scripture.
        Reference r = new Reference("Psalm", 103, 2, 3);
        r.setVerse(2,"Praise the Lord, my soul, and forget not all his benefits.");
        r.setVerse(3,"Who forgives all your sins, and heals all your diseases");
        reference.Add(r);

        //Loading the second reference scripture.
        Reference r1 = new Reference("Deuteronomy", 32, 39, 39);
        r1.setVerse(39,"See now that I myself am he! There is no god besides me. I put to death and I bring to life, I have wounded and I will heal, and no one can deliver out of my hand.");
        reference.Add(r1);

        //Loading the third reference scripture.
        Reference r2 = new Reference("1 Nephi", 3, 7, 7);
        r2.setVerse(7,"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        reference.Add(r2);

        //Loading the fourth reference scripture.
        Reference r3 = new Reference("2 Nephi", 2, 25, 25);
        r3.setVerse(25,"Adam fell that men might be; and men are, that they might have joy.");
        reference.Add(r3);

        //Loading the fifth reference scripture.
        Reference r4 = new Reference("2 Nephi", 32, 3, 3);
        r4.setVerse(3,"Feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");
        reference.Add(r4);

        //Loading the sixth reference scripture.
        Reference r5 = new Reference("Doctrine and Covenants", 82, 10, 10);
        r5.setVerse(10,"I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");
        reference.Add(r5);

        //Loading the seventh reference scripture.
        Reference r6 = new Reference("Doctrine and Covenants", 88, 118, 118);
        r6.setVerse(118,"And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith.");
        reference.Add(r6);

        //Loading the eighth reference scripture.
        Reference r7 = new Reference("Helaman", 5, 12, 12);
        r7.setVerse(12,"And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        reference.Add(r7);
    }

    public Reference getScreenScripture(int referenceNumber)
    {
        return reference[referenceNumber];
    }
}

