using System.Collections.Generic;

namespace Score21
{
    public class Cards 
    {
        public enum CardsScore : byte
        {
            sixHearts = 6,
            sixDiamonds = 6,
            sixSpades = 6,
            sixCrosses = 6,
            sevenHearts = 7,
            sevenDiamonds = 7,
            sevenSpades = 7,
            sevenCrosses = 7,
            eightHearts = 8,
            eightDiamonds = 8,
            eightSpades = 8,
            eightCrosses = 8,
            nineHearts = 9,
            nineDiamonds = 9,
            nineSpades = 9,
            nineCrosses = 9,
            tenHearts = 10,
            tenDiamonds = 10,
            tenSpades = 10,
            tenCrosses = 10,
            jackHearts = 2,
            jackDiamonds = 2,
            jackSpades = 2,
            jackCrosses = 2,
            ladyHearts = 3,
            ladyDiamonds = 3,
            ladySpades = 3,
            ladyCrosses = 3,
            kingHearts = 4,
            kingDiamonds = 4,
            kingSpades = 4,
            kingCrosses = 4,
            aceHearts = 11,
            aceDiamonds = 11,
            aceSpades = 11,
            aceCrosses = 11,

        }

        public enum CardsScoreAgreed : byte
        {
            sixHearts = 6,
            sixDiamonds = 6,
            sixSpades = 6,
            sixCrosses = 6,
            sevenHearts = 7,
            sevenDiamonds = 7,
            sevenSpades = 7,
            sevenCrosses = 7,
            eightHearts = 8,
            eightDiamonds = 8,
            eightSpades = 8,
            eightCrosses = 8,
            nineHearts = 9,
            nineDiamonds = 9,
            nineSpades = 9,
            nineCrosses = 9,
            tenHearts = 10,
            tenDiamonds = 10,
            tenSpades = 10,
            tenCrosses = 10,
            jackHearts = 2,
            jackDiamonds = 2,
            jackSpades = 2,
            jackCrosses = 2,
            ladyHearts = 3,
            ladyDiamonds = 3,
            ladySpades = 3,
            ladyCrosses = 3,
            kingHearts = 4,
            kingDiamonds = 4,
            kingSpades = 4,
            kingCrosses = 4,
            aceHearts = 1,
            aceDiamonds = 1,
            aceSpades = 1,
            aceCrosses = 1,
        }

        public static List<string> CardsName = new List<string>()
        {
            "sixHearts",
            "sixDiamonds",
            "sixSpades",
            "sixCrosses",
            "sevenHearts",
            "sevenDiamonds",
            "sevenSpades",
            "sevenCrosses",
            "eightHearts",
            "eightDiamonds",
            "eightSpades",
            "eightCrosses",
            "nineHearts",
            "nineDiamonds",
            "nineSpades",
            "nineCrosses",
            "tenHearts",
            "tenDiamonds",
            "tenSpades",
            "tenCrosses",
            "jackHearts",
            "jackDiamonds",
            "jackSpades",
            "jackCrosses",
            "ladyHearts",
            "ladyDiamonds",
            "ladySpades",
            "ladyCrosses",
            "kingHearts",
            "kingDiamonds",
            "kingSpades",
            "kingCrosses",
            "aceHearts",
            "aceDiamonds",
            "aceSpades",
            "aceCrosses"
        };

        public static List<string> AceCards = new List<string>()
        {
            "aceHearts",
            "aceDiamonds",
            "aceSpades",
            "aceCrosses"
        };

        public static List<string> CanvasCards = new List<string>()
        {
            "jackHearts",
            "jackDiamonds",
            "jackSpades",
            "jackCrosses",
            "ladyHearts",
            "ladyDiamonds",
            "ladySpades",
            "ladyCrosses",
            "kingHearts",
            "kingDiamonds",
            "kingSpades",
            "kingCrosses",
            "aceHearts",
            "aceDiamonds",
            "aceSpades",
            "aceCrosses"
        };

        public static List<string> SevensCards = new List<string>()
        {
            "sevenHearts",
            "sevenDiamonds",
            "sevenSpades",
            "sevenCrosses",
        };

        public static CardsScore[] ArrayCards = { 
            CardsScore.sixHearts, CardsScore.sixDiamonds, CardsScore.sixSpades, CardsScore.sixCrosses,
            CardsScore.sevenHearts, CardsScore.sevenDiamonds, CardsScore.sevenSpades, CardsScore.sevenCrosses,
            CardsScore.eightHearts, CardsScore.eightDiamonds, CardsScore.aceSpades, CardsScore.eightCrosses,
            CardsScore.nineHearts, CardsScore.nineDiamonds, CardsScore.nineSpades, CardsScore.nineCrosses,
            CardsScore.tenHearts, CardsScore.tenDiamonds, CardsScore.tenSpades, CardsScore.tenCrosses,
            CardsScore.jackHearts, CardsScore.jackDiamonds, CardsScore.jackSpades, CardsScore.jackCrosses,
            CardsScore.ladyHearts, CardsScore.ladyDiamonds, CardsScore.ladySpades, CardsScore.ladyCrosses,
            CardsScore.kingHearts, CardsScore.kingDiamonds, CardsScore.kingSpades, CardsScore.kingCrosses,
            CardsScore.aceHearts, CardsScore.aceDiamonds, CardsScore.aceSpades, CardsScore.aceCrosses
        };

        public static CardsScoreAgreed[] ArrayCardsAgreed = {
            CardsScoreAgreed.sixHearts, CardsScoreAgreed.sixDiamonds, CardsScoreAgreed.sixSpades, CardsScoreAgreed.sixCrosses,
            CardsScoreAgreed.sevenHearts, CardsScoreAgreed.sevenDiamonds, CardsScoreAgreed.sevenSpades, CardsScoreAgreed.sevenCrosses,
            CardsScoreAgreed.eightHearts, CardsScoreAgreed.eightDiamonds, CardsScoreAgreed.aceSpades, CardsScoreAgreed.eightCrosses,
            CardsScoreAgreed.nineHearts, CardsScoreAgreed.nineDiamonds, CardsScoreAgreed.nineSpades, CardsScoreAgreed.nineCrosses,
            CardsScoreAgreed.tenHearts, CardsScoreAgreed.tenDiamonds, CardsScoreAgreed.tenSpades, CardsScoreAgreed.tenCrosses,
            CardsScoreAgreed.jackHearts, CardsScoreAgreed.jackDiamonds, CardsScoreAgreed.jackSpades, CardsScoreAgreed.jackCrosses,
            CardsScoreAgreed.ladyHearts, CardsScoreAgreed.ladyDiamonds, CardsScoreAgreed.ladySpades, CardsScoreAgreed.ladyCrosses,
            CardsScoreAgreed.kingHearts, CardsScoreAgreed.kingDiamonds, CardsScoreAgreed.kingSpades, CardsScoreAgreed.kingCrosses,
            CardsScoreAgreed.aceHearts, CardsScoreAgreed.aceDiamonds, CardsScoreAgreed.aceSpades, CardsScoreAgreed.aceCrosses
        };
    }
}
