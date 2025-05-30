using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
class Scripture

{
    static List<(string Reference, string Verse)> ldsScriptures = new List<(string, string)>
{
    ("1 Nephi 3:7", "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
    ("2 Nephi 2:25", "25 Adam fell that men might be; and men are, that they might have joy."),
    ("2 Nephi 2:27", "27 Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death."),
    ("2 Nephi 9:28–29", "28 O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves. Wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.\n29 But to be learned is good if they hearken unto the counsels of God."),
    ("2 Nephi 9:51", "51 Wherefore, do not spend money for that which is of no worth, nor your labor for that which cannot satisfy. Hearken diligently unto me, and remember the words which I have spoken; and come unto the Holy One of Israel, and feast upon that which perisheth not, neither can be corrupted, and let your soul delight in fatness."),
    ("2 Nephi 28:7–8", "7 Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us.\n8 And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God."),
    ("2 Nephi 31:20", "20 Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."),
    ("Jacob 2:18–19", "18 But before ye seek for riches, seek ye for the kingdom of God.\n19 And after ye have obtained a hope in Christ ye shall obtain riches, if ye seek them; and ye will seek them for the intent to do good—to clothe the naked, and to feed the hungry, and to liberate the captive, and administer relief to the sick and the afflicted."),
    ("Mosiah 2:17", "17 When ye are in the service of your fellow beings ye are only in the service of your God."),
    ("Mosiah 2:41", "41 And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God."),
    ("Mosiah 3:19", "19 For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit."),
    ("Mosiah 4:30", "30 But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, ye must perish."),
    ("Mosiah 5:2", "2 And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us."),
    ("Alma 5:14", "14 And now behold, I ask of you, my brethren of the church, have ye spiritually been born of God?"),
    ("Alma 7:11–13", "11 And he shall go forth, suffering pains and afflictions and temptations of every kind...\n12 And he will take upon him death, that he may loose the bands of death...\n13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh."),
    ("Alma 12:24", "24 And we see that death comes upon mankind..."),
    ("Alma 32:21", "21 And now as I said concerning faith—faith is not to have a perfect knowledge of things..."),
    ("Alma 34:32", "32 For behold, this life is the time for men to prepare to meet God..."),
    ("Alma 37:6–7", "6 By small and simple things are great things brought to pass...\n7 And the Lord God doth work by means to bring about his great and eternal purposes."),
    ("Alma 37:35", "35 O, remember, my son, and learn wisdom in thy youth..."),
    ("Alma 41:10", "10 Wickedness never was happiness."),
    ("Helaman 5:12", "12 Remember, that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation..."),
    ("3 Nephi 11:29", "29 He that hath the spirit of contention is not of me..."),
    ("3 Nephi 12:48", "48 Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect."),
    ("3 Nephi 18:15", "15 Verily, verily, I say unto you, ye must watch and pray always..."),
    ("3 Nephi 27:27", "27 What manner of men ought ye to be? Verily I say unto you, even as I am."),
    ("Ether 12:6", "6 Faith is things which are hoped for and not seen..."),
    ("Ether 12:27", "27 And if men come unto me I will show unto them their weakness..."),
    ("Moroni 7:16–17", "16 The Spirit of Christ is given to every man...\n17 But whatsoever thing persuadeth men to do evil..."),
    ("Moroni 10:4–5", "4 And when ye shall receive these things...\n5 And by the power of the Holy Ghost ye may know the truth of all things."),
    ("Genesis 1:26–27", "26 And God said, Let us make man in our image...\n27 So God created man in his own image..."),
    ("Exodus 20:3–17", "3 Thou shalt have no other gods before me...\n17 Thou shalt not covet thy neighbour's house..."),
    ("Joshua 24:15", "15 Choose you this day whom ye will serve..."),
    ("Psalm 24:3–4", "3 Who shall ascend into the hill of the Lord?\n4 He that hath clean hands, and a pure heart..."),
    ("Psalm 119:105", "105 Thy word is a lamp unto my feet, and a light unto my path."),
    ("Isaiah 1:18", "18 Though your sins be as scarlet, they shall be as white as snow..."),
    ("Isaiah 53:3–5", "3 He is despised and rejected of men...\n5 But he was wounded for our transgressions..."),
    ("Matthew 5:14–16", "14 Ye are the light of the world...\n16 Let your light so shine before men..."),
    ("Matthew 11:28–30", "28 Come unto me, all ye that labour and are heavy laden...\n30 For my yoke is easy, and my burden is light."),
    ("John 3:16", "16 For God so loved the world, that he gave his only begotten Son..."),
    ("John 14:6", "6 I am the way, the truth, and the life: no man cometh unto the Father, but by me."),
    ("Acts 2:38", "38 Repent, and be baptized every one of you in the name of Jesus Christ..."),
    ("Romans 1:16", "16 For I am not ashamed of the gospel of Christ..."),
    ("1 Corinthians 10:13", "13 There hath no temptation taken you but such as is common to man..."),
    ("Galatians 5:22–23", "22 But the fruit of the Spirit is love, joy, peace...\n23 Meekness, temperance: against such there is no law."),
    ("Philippians 4:13", "13 I can do all things through Christ which strengtheneth me."),
    ("James 1:5–6", "5 If any of you lack wisdom, let him ask of God...\n6 But let him ask in faith, nothing wavering."),
    ("2 Timothy 3:16–17", "16 All scripture is given by inspiration of God...\n17 That the man of God may be perfect..."),
    ("2 Peter 1:4", "4 Whereby are given unto us exceeding great and precious promises..."),
    ("Doctrine and Covenants 1:37–38", "37 Search these commandments, for they are true and faithful...\n38 What I the Lord have spoken, I have spoken..."),
    ("Doctrine and Covenants 18:10", "10 Remember the worth of souls is great in the sight of God."),
    ("Doctrine and Covenants 19:16–19", "16 For behold, I, God, have suffered these things for all...\n19 Nevertheless, glory be to the Father..."),
    ("Doctrine and Covenants 88:118", "118 And as all have not faith, seek ye diligently and teach one another words of wisdom...")
};



   private List<Word> _words;
    private Reference _reference;

    public Scripture()
    {
        var (reference, verse) = RandomChoice();
        _reference = reference;
        _words = verse.Split(' ').Select(w => new Word(w)).ToList();
    }

    public Reference GetReference() => _reference;

    public string GetVerseText()
    {
        return string.Join(" ", _words.Select(w => w.Display()));
    }

    public void HideWords(int count)
    {
        var rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    private static List<(Reference, string)> BuildReferenceList(List<(string, string)> source)
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>();
        foreach (var item in source)
        {
            string reference = item.Item1;
            var (book, chapter, startVerse, endVerse) = ParseReference(reference);

            Reference refObj = endVerse.HasValue
                ? new Reference(book, chapter, startVerse, endVerse.Value)
                : new Reference(book, chapter, startVerse);

            scriptures.Add((refObj, item.Item2));
        }
        return scriptures;
    }

    private static (string Book, int Chapter, int StartVerse, int? EndVerse) ParseReference(string reference)
    {
        int lastSpace = reference.LastIndexOf(' ');
        string book = reference.Substring(0, lastSpace);
        string chapterVerse = reference.Substring(lastSpace + 1);

        string[] parts = chapterVerse.Split(':');
        int chapter = int.Parse(parts[0]);
        string versePart = parts[1];

        int startVerse = 0;
        int? endVerse = null;

        if (versePart.Contains("-") || versePart.Contains("–"))
        {
            var separators = new[] { '-', '–' };
            var verses = versePart.Split(separators);
            startVerse = int.Parse(verses[0]);
            endVerse = int.Parse(verses[1]);
        }
        else
        {
            startVerse = int.Parse(versePart);
        }

        return (book, chapter, startVerse, endVerse);
    }

    private (Reference, string) RandomChoice()
    {
        Random rand = new Random();
        List<(Reference, string)> scriptures = BuildReferenceList(ldsScriptures);
        int index = rand.Next(scriptures.Count);
        return scriptures[index];
    }
}

   
