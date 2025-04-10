﻿namespace CodeWars5kyuTest;

using CodeWars5kyu;

public class TalkLikeSiegfried
{
        private static string english =
    "This is KAOS!! We don't play with Code-Wars here!! " +
    "So there will be trouble for you this time Mr Maxwell Smart! " +
    "We have received all the photographic evidence we need so choose carefully what you say next! " +
    "I hope you will co-operate with KAOS and do exactly what we want Mr Smart otherwise I won't be happy with you! " +
    "In fact, if you misbehave that would make me very unhappy indeed... " +
    "And you certainly would not want to make me unnecesarily cross would you Mr Maxwell Smart?";

    private static string afterWeek1 =
    "This is KAOS!! We don't play with Kode-Wars here!! " +
    "So there will be trouble for you this time Mr Maxwell Smart! " +
    "We have reseived all the photographik evidense we need so choose karefully what you say next! " +
    "I hope you will ko-operate with KAOS and do exaktly what we want Mr Smart otherwise I won't be happy with you! " +
    "In fakt, if you misbehave that would make me very unhappy indeed... " +
    "And you sertainly would not want to make me unnesesarily kross would you Mr Maxwell Smart?";

    private static string afterWeek2 =
    "This is KAOS!! We don't play with Kode-Wars here!! " +
    "So there will be trouble for you this time Mr Maxwell Smart! " +
    "We have reseived all the fotografik evidense we need so choose karefully what you say next! " +
    "I hope you will ko-operate with KAOS and do exaktly what we want Mr Smart otherwise I won't be happy with you! " +
    "In fakt, if you misbehave that would make me very unhappy indeed... " +
    "And you sertainly would not want to make me unnesesarily kross would you Mr Maxwell Smart?";

    private static string afterWeek3 =
    "This is KAOS!! We don't play with Kod-Wars her!! " +
    "So ther wil be troubl for you this tim Mr Maxwel Smart! " +
    "We hav reseived al the fotografik evidens we ned so chos karefuly what you say next! " +
    "I hop you wil ko-operat with KAOS and do exaktly what we want Mr Smart otherwis I won't be hapy with you! " +
    "In fakt, if you misbehav that would mak me very unhapy inded... " +
    "And you sertainly would not want to mak me unesesarily kros would you Mr Maxwel Smart?";

    private static string afterWeek4 =
    "Zis is KAOS!! Ve don't play viz Kod-Vars her!! " +
    "So zer vil be troubl for you zis tim Mr Maxvel Smart! " +
    "Ve hav reseived al ze fotografik evidens ve ned so chos karefuly vat you say next! " +
    "I hop you vil ko-operat viz KAOS and do exaktly vat ve vant Mr Smart ozervis I von't be hapy viz you! " +
    "In fakt, if you misbehav zat vould mak me very unhapy inded... " +
    "And you sertainly vould not vant to mak me unesesarily kros vould you Mr Maxvel Smart?";

    private static string afterWeek5 =
    "Zis is KAOS!! Ve don't play viz Kod-Vars her!! " +
    "So zer vil be trubl for yu zis tim Mr Maxvel Schmart! " +
    "Ve hav reseived al ze fotografik evidens ve ned so chos karefuly vat yu say next! " +
    "I hop yu vil ko-operat viz KAOS und do exaktly vat ve vunt Mr Schmart ozervis I von't be hapy viz yu! " +
    "In fakt, if yu misbehav zat vuld mak me very unhapy inded... " +
    "Und yu sertainly vuld not vunt to mak me unesesarily kros vuld yu Mr Maxvel Schmart?";

    [Test]
    public void TalkLikeSiegfriedTest()
    {
        Assert.That(TalkLikeSiegfriedTask.Siegfried(1, english), Is.EqualTo(afterWeek1));
        Assert.That(TalkLikeSiegfriedTask.Siegfried(2, english), Is.EqualTo(afterWeek2));
        Assert.That(TalkLikeSiegfriedTask.Siegfried(3, english), Is.EqualTo(afterWeek3));
        Assert.That(TalkLikeSiegfriedTask.Siegfried(4, english), Is.EqualTo(afterWeek4));
        Assert.That(TalkLikeSiegfriedTask.Siegfried(5, english), Is.EqualTo(afterWeek5));
    }
}